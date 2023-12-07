using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyModel;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Rio.Administration;
using Rio.Common;
using Rio.Web;
using Rio.Workspace;

using Serenity;
using Serenity.Abstractions;
using Serenity.Data;
using Serenity.Extensions;
using Serenity.Services;
using Serenity.Web;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static com.sun.tools.@internal.xjc.reader.xmlschema.bindinfo.BIConversion;

namespace Rio.Membership.Pages
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [JsonRequest, IgnoreAntiforgeryToken]
    [Route("Api/Account/[action]")]
    public partial class AccountApiController : Controller
    {
        protected ITwoLevelCache Cache { get; }
        protected ITextLocalizer Localizer { get; }

        public AccountApiController(ITwoLevelCache cache, ITextLocalizer localizer)
        {
            Localizer = localizer ?? throw new ArgumentNullException(nameof(localizer));
            Cache = cache ?? throw new ArgumentNullException(nameof(cache));
        }

        [HttpGet]
        public ActionResult Login(int? denied, string activated, string returnUrl)
        {
            if (denied == 1)
                return View(MVC.Views.Errors.AccessDenied,
                    (object)("~/Account/Login?returnUrl=" + Uri.EscapeDataString(returnUrl)));

            ViewData["Activated"] = activated;
            ViewData["HideLeftNavigation"] = true;

            return View(MVC.Views.Membership.Account.AccountLogin);
        }

        [HttpGet]
        public ActionResult AccessDenied(string returnURL)
        {
            ViewData["HideLeftNavigation"] = !User.IsLoggedIn();

            return View(MVC.Views.Errors.AccessDenied, (object)returnURL);
        }

        [HttpPost, JsonRequest]
        public Result<ServiceResponse> Login(LoginRequest request,
            [FromServices] IUserPasswordValidator passwordValidator,
            [FromServices] IUserRetrieveService userRetriever,
            [FromServices] IEmailSender emailSender = null,
            [FromServices] ISMSService smsService = null)
        {
            return this.ExecuteMethod(() =>
            {
                if (request is null)
                    throw new ArgumentNullException(nameof(request));

                if (string.IsNullOrEmpty(request.Username))
                    throw new ArgumentNullException(nameof(request.Username));

                if (passwordValidator is null)
                    throw new ArgumentNullException(nameof(passwordValidator));

                if (userRetriever is null)
                    throw new ArgumentNullException(nameof(userRetriever));

                var username = request.Username;
                var result = passwordValidator.Validate(ref username, request.Password);
                if (result == PasswordValidationResult.Valid)
                {
                    CheckTwoFactorAuthentication(username, request, userRetriever, emailSender, smsService);

                    var principal = UserRetrieveService.CreatePrincipal(userRetriever, username, authType: "Password");
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal).GetAwaiter().GetResult();
                    return new ServiceResponse();
                }

                throw new ValidationError("AuthenticationError", Texts.Validation.AuthenticationError.ToString(Localizer));
            });
        }

        [Serializable]
        private class TwoFactorData
        {
            public string Username { get; set; }
            public int RetryCount { get; set; }
            public int TwoFactorCode { get; set; }
        }

        private void CheckTwoFactorAuthentication(string username, LoginRequest request, IUserRetrieveService userRetriever,
            IEmailSender emailSender, ISMSService smsService)
        {
            bool isTwoFactorReq = !string.IsNullOrEmpty(request.TwoFactorGuid) || request.TwoFactorCode != null;

            if (isTwoFactorReq)
            {
                if (string.IsNullOrEmpty(request.TwoFactorGuid))
                    throw new ArgumentNullException(nameof(request.TwoFactorGuid));
                if (request.TwoFactorCode is null)
                    throw new ArgumentNullException(nameof(request.TwoFactorCode));

                var key = "TwoFactorAuth:" + request.TwoFactorGuid;
                var data = Cache.Distributed.GetAutoJson<TwoFactorData>(key);
                if (data == null || data.Username == null || data.Username != username)
                    throw new ValidationError("Can't validate credentials. Please try login again!");

                data.RetryCount++;
                if (data.RetryCount > 3)
                {
                    Cache.Distributed.Remove(key);
                    throw new ValidationError("Can't validate credentials. Please try login again!");
                }
                else
                {
                    Cache.Distributed.SetAutoJson(key, data);
                }

                if (data.TwoFactorCode != request.TwoFactorCode)
                    throw new ValidationError("Validation code is invalid. Please check and try again.");

                // login success. clear to not let same two factor guid/two factor code two be reused later
                Cache.Distributed.Remove(key);

                return;
            }

            if (userRetriever is null)
                throw new ArgumentNullException(nameof(userRetriever));

            if (userRetriever.ByUsername(username) is UserDefinition user &&
                ((user.TwoFactorAuth == TwoFactorAuthType.SMS &&
                  user.MobilePhoneVerified &&
                  UserHelper.IsValidPhone(user.MobilePhoneNumber)) ||
                 (user.TwoFactorAuth == TwoFactorAuthType.Email)))
            {
                var data = new TwoFactorData
                {
                    RetryCount = 0,
                    Username = username,
                    TwoFactorCode = new Random().Next(9000) + 1000
                };

                // this is to prevent users from sending too many SMS in a certain time interval
                var throttler = new Throttler(Cache.Memory, "TwoFactorAuthThrottle:" + username, TimeSpan.FromMinutes(5), 10);
                if (!throttler.Check())
                    throw new ValidationError("Can't proceed with two factor authentication. You are over your validation limit!");

                var twoFactorGuid = Guid.NewGuid().ToString("N");

                string authenticationMessage;
                if (user.TwoFactorAuth == TwoFactorAuthType.SMS)
                {
                    if (smsService is null)
                        throw new ArgumentNullException(nameof(smsService));

                    var mobile = user.MobilePhoneNumber.Trim();
                    smsService.Send(
                        phoneNumber: mobile,
                        text: "Please use code " + data.TwoFactorCode + " for Rio login.",
                        reason: "Sent by Rio system for two factor authenication by SMS (" + user.Username + ")");

                    // mask mobile number
                    mobile = mobile.Substring(0, 2) + new string('*', mobile.Length - 4) + mobile.Substring(mobile.Length - 2, 2);
                    authenticationMessage = "Please enter code sent to your mobile phone with number " + mobile + " in <span class='counter'>{0}</span> seconds." +
                        (smsService is FakeSMSService ?
                            " (You can find a text file under App_Data/SMS directory, as you haven't configured SMS service yet)" : "");
                }
                else
                {
                    if (emailSender is null)
                        throw new ArgumentNullException(nameof(emailSender));

                    emailSender.Send(
                        mailTo: user.Email,
                        subject: "Your two-factor authentication code for Rio login",
                        body: "Please use code " + data.TwoFactorCode + " for Rio login.");

                    authenticationMessage = "Please enter code sent to your e-mail adress in {0} seconds." +
                        " (If you didn't configure an SMTP server, you can find e-mails under App_Data/Mail directory";
                }

                Cache.Distributed.SetAutoJson("TwoFactorAuth:" + twoFactorGuid, data, TimeSpan.FromMinutes(2));
                throw new ValidationError("TwoFactorAuthenticationRequired",
                    authenticationMessage + "|" + twoFactorGuid, "Two factor authentication is required!");
            }
        }

        public ActionResult ImpersonateAs(string token, [FromServices] IUserRetrieveService userRetriever)
        {
            if (userRetriever is null)
                throw new ArgumentNullException(nameof(userRetriever));

            var bytes = HttpContext.RequestServices.GetDataProtector("ImpersonateAs")
                .Unprotect(Convert.FromBase64String(token));

            using var ms = new MemoryStream(bytes);
            using var br = new BinaryReader(ms);
            var dt = DateTime.FromBinary(br.ReadInt64());
            if (dt < DateTime.UtcNow)
                return new ContentResult { Content = "Your impersonation token is expired. Please refresh the page you were using and try again." };

            var loginAsUser = br.ReadString();

            if (string.Compare(loginAsUser, "admin", StringComparison.OrdinalIgnoreCase) != 0)
                return new ContentResult { Content = "Only admin can use impersonation functionality!" };

            var loginAs = br.ReadString();

            if (string.Compare(loginAs, "admin", StringComparison.OrdinalIgnoreCase) == 0)
                return new ContentResult { Content = "Can't impersonate as admin!" };

            var remoteIp = HttpContext.Connection.RemoteIpAddress.ToString();
            remoteIp = remoteIp == "::1" ? "127.0.0.1" : remoteIp;
            var currentClientId = Request.Headers["User-Agent"] + "|" + remoteIp;
            using (var md5 = MD5.Create())
            {
                var currentHash = md5.ComputeHash(Encoding.UTF8.GetBytes(currentClientId));
                if (!currentHash.SequenceEqual(br.ReadBytes(currentHash.Length)))
                    return new ContentResult { Content = "Invalid token! User-agent or IP mismatch!" };
            }

            if (userRetriever.ByUsername(loginAs) is not UserDefinition user)
                return new ContentResult { Content = loginAs + " is not a valid username!" };

            if (User?.Identity.Name?.ToLowerInvariant() == loginAsUser.ToLowerInvariant())
                return new ContentResult
                {
                    Content = "Please use Incognito mode by right clicking the impersonation link! " +
                        "If you are already in Incognito mode, signout or close all Incognito browser windows and try again."
                };

            var principal = UserRetrieveService.CreatePrincipal(userRetriever, user.Username, authType: "Impersonation");
            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal).Wait();

            return new RedirectResult("~/");
        }

        private ActionResult Error(string message)
        {
            return View(MVC.Views.Errors.ValidationError, new ValidationError(message));
        }

        public string KeepAlive()
        {
            return "OK";
        }

        public ActionResult Signout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return new RedirectResult("~/");
        }

        #region JWT Token Methods
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> GenerateToken(LoginRequest request,
                        [FromServices] IUserPasswordValidator passwordValidator,
                        [FromServices] IUserRetrieveService userRetriever,
                        [FromServices] IEmailSender emailSender = null,
                        [FromServices] ISMSService smsService = null)
        {
            bool loggedIn = false;
            if (ModelState.IsValid)
            {
                if (request is null)
                    throw new ArgumentNullException(nameof(request));

                if (string.IsNullOrEmpty(request.Username))
                    throw new ArgumentNullException(nameof(request.Username));

                if (passwordValidator is null)
                    throw new ArgumentNullException(nameof(passwordValidator));

                if (userRetriever is null)
                    throw new ArgumentNullException(nameof(userRetriever));

                await Task.Run(() =>
                {
                    var username = request.Username;
                    var result = passwordValidator.Validate(ref username, request.Password);
                    if (result == PasswordValidationResult.Valid)
                    {
                        loggedIn = true;
                    }
                });
                if (loggedIn)
                {
                    UserDefinition userDefinition = (UserDefinition)userRetriever.ByUsername(request.Username);
                    var claims = new[]
                    {
                        new Claim(JwtRegisteredClaimNames.NameId,userDefinition.Id),
                        new Claim(ClaimTypes.Name,request.Username),
                        new Claim(ClaimTypes.NameIdentifier,request.Username),
                        new Claim(JwtRegisteredClaimNames.UniqueName,request.Username),
                        new Claim(JwtRegisteredClaimNames.Sub, request.Username),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim("TenantId",userDefinition.TenantId.ToString()),
                };

                    //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6LftZ6gUAAAAAD1Ken7Eep9Wv3Z_WISb9lrxh_QN"));
                    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken("https://omrapp.azurewebsites.net", "https://omrapp.azurewebsites.net",
                      claims,
                      expires: DateTime.Now.AddDays(365),
                      signingCredentials: creds);

                    return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
                }
                else
                {
                    //var error = new ServiceError();
                    //error.Code = "400A";
                    //error.Message = "Admission already taken";

                    return BadRequest(Texts.Validation.AuthenticationError);

                }
            }
            return BadRequest("Could not create token");
        }

        [HttpPost]
        public RetrieveResponse<UserDefinition> UserData([FromServices] IUserRetrieveService userRetriever, [FromServices] ISqlConnections sqlConnections)
        {
            UserDefinition userDefinition = userRetriever.ByUsername(HttpContext.User.Identity.Name) as UserDefinition;
            RetrieveResponse<UserDefinition> response = new RetrieveResponse<UserDefinition>();
            using var connection = sqlConnections.NewByKey("Default");
            {
                var userpermission = connection.List<UserRoleRow>(UserRoleRow.Fields.UserId == userDefinition.UserId);
                if (userpermission.Count > 0)
                {
                    userDefinition.RoleIds = "";
                    foreach (UserRoleRow row in userpermission)
                    {
                        if (row.RoleId != 0)
                        {
                            var role = connection.TryFirst<RoleRow>(RoleRow.Fields.RoleId == row.RoleId.Value);
                            if (string.IsNullOrEmpty(userDefinition.RoleIds))
                            {
                                userDefinition.RoleIds = row.RoleId.ToString();

                            }
                            else
                            {
                                userDefinition.RoleIds = userDefinition.RoleIds + "," + row.RoleId.ToString();

                            }


                        }
                    }

                }
            }
            response.Entity = userDefinition;
            return response;
        }


        #endregion


        [AllowAnonymous, HttpPost]
        public Result<ServiceResponse> SignUpAsTeacher(SignUpRequest request , [FromServices] IOptions<EnvironmentSettings> options = null)

        {
            return this.UseConnection("Default", connection =>
            {
                if (request is null)
                    throw new ArgumentNullException(nameof(request));

                if (string.IsNullOrWhiteSpace(request.Email))
                    throw new ArgumentNullException(nameof(request.Email));
                if (string.IsNullOrEmpty(request.Password))
                    throw new ArgumentNullException(nameof(request.Password));

                UserHelper.ValidatePassword(request.Password, Localizer);
                if (string.IsNullOrWhiteSpace(request.DisplayName))
                    throw new ArgumentNullException(nameof(request.DisplayName));

                if (connection.Exists<UserRow>(
                        UserRow.Fields.Username == request.Email |
                        UserRow.Fields.Email == request.Email))
                {
                    throw new ValidationError("EmailInUse", Texts.Validation.EmailInUse.ToString(Localizer));
                }

                if (connection.Exists<TeachersRow>(new Criteria(TeachersRow.Fields.FullName) == request.DisplayName))
                {
                    throw new ValidationError("TeacherInUse", "Teacher Already Exists!");

                }
                if (connection.Exists<UserRow>(
                        UserRow.Fields.Username == request.Email |
                        UserRow.Fields.Email == request.Email))
                {
                    throw new ValidationError("EmailInUse", Texts.Validation.EmailInUse.ToString(Localizer));
                }
                using var uow = new UnitOfWork(connection);
                string salt = null;
                var hash = UserHelper.GenerateHash(request.Password, ref salt);
                var displayName = request.DisplayName.TrimToEmpty();
                var email = request.Email;
                var username = request.Email;

                var fld = UserRow.Fields;
                var userId = (int)connection.InsertAndGetID(new UserRow
                {
                    Username = username,
                    Source = "sign",
                    DisplayName = displayName,
                    Email = email,
                    PasswordHash = hash,
                    PasswordSalt = salt,
                    IsActive = 1,
                    InsertDate = DateTime.Now,
                    InsertUserId = 1,
                    LastDirectoryUpdate = DateTime.Now
                });


                connection.Execute(string.Format(@"INSERT INTO UserPermissions (UserId, PermissionKey, Granted)
                                                       VALUES ({0}, 'Administration:Teachers', 1)", userId));

                connection.Execute(string.Format(@"INSERT INTO UserRoles (UserId, RoleId)
                                               VALUES ({0}, 2)", userId));

                var mobile = request.Mobile.TrimToEmpty();
                var users = uow.Connection.TryFirst<UserRow>(UserRow.Fields.Username == request.Email);

                TeachersRow teachersRow = new TeachersRow();
                teachersRow.FirstName = request.FirstName;
                teachersRow.LastName = request.LastName;
                teachersRow.FullName = request.DisplayName;
                teachersRow.Mobile = mobile;
                teachersRow.Email = request.Email;
                teachersRow.UserId = userId;
                teachersRow.IsActive = 1;
                teachersRow.TenantId = users.TenantId;
                teachersRow.InsertDate = DateTime.Now;
                teachersRow.InsertUserId = Convert.ToInt32(User.GetIdentifier());
                long teachersId = (long)connection.InsertAndGetID(teachersRow);

                byte[] bytes;
                using (var ms = new MemoryStream())
                using (var bw = new BinaryWriter(ms))
                {
                    bw.Write(DateTime.UtcNow.AddHours(3).ToBinary());
                    bw.Write(userId);
                    bw.Flush();
                    bytes = ms.ToArray();
                }
                var token = Convert.ToBase64String(HttpContext.RequestServices
                                   .GetDataProtector("Activate").Protect(bytes));

                var externalUrl = options?.Value?.SiteExternalUrl ??
                    Request.GetBaseUri().ToString();

                var activateLink = UriHelper.Combine(externalUrl, "Account/Activate?t=");
                activateLink += Uri.EscapeDataString(token);
                var LoginLink = UriHelper.Combine(externalUrl, "Account/Login");
                var emailModel = new ActivateEmailModel
                {
                    Username = username,
                    DisplayName = displayName,
                    ActivateLink = activateLink,
                    LoginLink=LoginLink,
                    Password=request.Password,

                };

                var emailSubject = "OMR Registration Successful";
                var emailBody = TemplateHelper.RenderViewToString(HttpContext.RequestServices,
                    MVC.Views.Membership.Account.SignUp.TeacherSignupEmail, emailModel);
                emailModel.ActivateLink = activateLink;
               
                emailModel.Username = username;
                emailModel.DisplayName = displayName;
                emailModel.Password = request.Password;
                #region Email
                var mail = new MailRow();
                mail.Uid = Guid.NewGuid();
                mail.Subject = emailSubject;
                mail.Body = emailBody;
                mail.Priority = MailQueuePriority.High;
                mail.Status = MailStatus.InQueue;
                mail.LockExpiration = DateTime.Now.AddDays(-1);
                mail.InsertDate = DateTime.Now;
                mail.InsertUserId = Convert.ToInt32(User.GetIdentifier());
                mail.RetryCount = 0;
                var AwsuserId = "AKIAJRD5ISHDUSMDQY3A";
                var AwsPassword = "AiT6XWNew81FxpC2bFlG03qXtICsATCofb7buTYE1rwg";
                var FromEmail = "hello@antargyan.com";
                mail.MailFrom = FromEmail;
                mail.AwsUserId = AwsuserId;
                mail.AwsPassword = AwsPassword;
                mail.MailTo = email;
                connection.Insert<MailRow>(mail);
                #endregion
               
                uow.Commit();

                return new ServiceResponse();
            });
        }
    }
}