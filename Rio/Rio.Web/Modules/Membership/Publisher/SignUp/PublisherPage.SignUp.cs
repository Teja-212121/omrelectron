using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Rio.Administration;
using Rio.Administration.Repositories;
using Rio.Common;
using Rio.Web.Enums;
using Serenity;
using Serenity.Abstractions;
using Serenity.Data;
using Serenity.Extensions;
using Serenity.Services;
using Serenity.Web;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace Rio.Membership.Pages
{
    [Route("Publisher/[action]")]
    public partial class PublisherController : Controller
    {
        protected ITwoLevelCache Cache { get; }
        protected ITextLocalizer Localizer { get; }
        [HttpGet]
        public ActionResult SignUp()
        {
            return View(MVC.Views.Membership.Account.SignUp.PublisherSignUp);
        }

        [HttpPost, JsonRequest]
        public Result<ServiceResponse> SignUp(PublisherSignUpRequest request,
            [FromServices] IEmailSender emailSender,
            /*[FromServices] ISMSService smsService,*/
            [FromServices] IOptions<EnvironmentSettings> options = null)
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
                if (string.IsNullOrWhiteSpace(request.Name))
                    throw new ArgumentNullException(nameof(request.Name));

                if (connection.Exists<UserRow>(
                        UserRow.Fields.Username == request.Email |
                        UserRow.Fields.Email == request.Email))
                {
                    throw new ValidationError("EmailInUse", Texts.Validation.EmailInUse.ToString(Localizer));
                }

                if (connection.Exists<TenantRow>(new Criteria(TenantRow.Fields.TenantName) == request.Organization))
                {
                     throw new ValidationError("TenantInUse", "Organization Already Exists!");
                   
                }

                TenantRow tenantRow = new TenantRow();
                tenantRow.TenantName = request.Organization;               
                tenantRow.IsActive = 0;               
                tenantRow.EApprovalStatus = EApprovalStatus.Pending;               
                Int32 tenantId = (Int32)connection.InsertAndGetID<TenantRow>(tenantRow);

                using var uow = new UnitOfWork(connection);
                string salt = null;
                var hash = UserHelper.GenerateHash(request.Password, ref salt);
                var displayName = request.Name.TrimToEmpty();
                var mobile = request.Mobile.TrimToEmpty();
                var email = request.Email;
                var username = request.Email;

                var fld = UserRow.Fields;
                var userId = (int)connection.InsertAndGetID(new UserRow
                {
                    Username = username,
                    Source = "sign",
                    DisplayName = displayName,
                    Email = email,
                    MobilePhoneNumber = mobile,
                    PasswordHash = hash,
                    PasswordSalt = salt,
                    IsActive = 0,
                    InsertDate = DateTime.Now,
                    InsertUserId = 1,
                    TenantId=tenantId,
                    LastDirectoryUpdate = DateTime.Now
                });

                connection.Execute(string.Format(@"INSERT INTO UserPermissions (UserId, PermissionKey, Granted)
                                                       VALUES ({0}, 'Administration.Tenants', 1)", userId));

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

                 var activateLink = UriHelper.Combine("https://omrapp.azurewebsites.net/", "Account/Activate?t=");
                //var activateLink = UriHelper.Combine("https://localhost:59252/", "Account/Activate?t=");
                activateLink += Uri.EscapeDataString(token);

                var emailModel = new PublisherEmailModel();
                emailModel.Username = username;
                emailModel.Organization = request.Organization;
                emailModel.DisplayName = displayName;
                emailModel.ActivateLink = activateLink;
                //emailModel.LoginLink = LoginLink;

                var emailSubject = "OMR Registration Successful";
                var emailBody = TemplateHelper.RenderViewToString(HttpContext.RequestServices,
                    MVC.Views.Membership.Account.SignUp.PublisherActivateEmail, emailModel);

                #region Email                   

                var mail = new MailRow();
                mail.Uid = Guid.NewGuid();
                mail.Subject = emailSubject;
                mail.Body = emailBody;
                mail.Priority = MailQueuePriority.High;
                mail.Status = MailStatus.InQueue;
                mail.LockExpiration = DateTime.Now.AddDays(-1);
                mail.InsertDate = DateTime.Now;
                mail.InsertUserId = 1;
                mail.RetryCount = 0;
                var AwsuserId = "AKIAJRD5ISHDUSMDQY3A";
                var AwsPassword = "AiT6XWNew81FxpC2bFlG03qXtICsATCofb7buTYE1rwg";
                var FromEmail = "hello@antargyan.com";
                mail.MailFrom = FromEmail;
                mail.AwsUserId = AwsuserId;
                mail.AwsPassword = AwsPassword;
                mail.MailTo = email;
                //if (message.CC.Count > 0)
                //    mail.Cc = string.Join(";", message.CC.Select(x => x.ToString()));
                //if (message.Bcc.Count > 0)
                //    mail.Bcc = string.Join(";", message.Bcc.Select(x => x.ToString()));
                //if (message.ReplyToList.Count > 0)
                //    mail.ReplyTo = string.Join(";", message.ReplyToList.Select(x => x.ToString()));
                connection.Insert<MailRow>(mail);
                #endregion

                /*#region SMS

                var body = "Dear " + request.Name + ",UserName: " + request.Email + " and Password: " + request.Password + " For OMRApp Thanks, Team OMR";

                string source = "MTSExa";
                string requestUrl = "https://vas.sevenomedia.com/domestic/sendsms/bulksms_v2.php?";
                HttpWebRequest SMSrequest = (HttpWebRequest)WebRequest.Create(requestUrl);
                SMSrequest.Method = "POST";
                SMSrequest.ContentType = "application/x-www-form-urlencoded";
                request.Mobile = "+91" + "7276380771";
                //string postData = "authkey=50402A4uy2U6iMm588f2d3f&&mobiles=" + request.Mobile1 + "&message=" + body + "&sender=Shield&route=4&country=91";
                string postData = "apikey=YW50YXJneWFuOjNxMllQZ09J&type=TEXT&sender=MTSMGR&entityId=1201161191548157480&templateId=1207165641046779928&mobile=" + "7276380771" + "&message=" + body;
                //string postData = "apikey=YW50YXJneWFuOjNxMllQZ09J&type=TEXT&sender=MTSMGR&entityId=1201161191548157480&templateId=1207165641046779928&mobile=" + request.Mobile1 + "&message=" + body;
                postData = postData.Replace("7276380771", "7276380771");
                postData = postData.Replace("##smsBody##", body);
                postData = postData.Replace("##source##", source);
                byte[] SMSbytes = Encoding.ASCII.GetBytes(postData);

                //byte[] SMSbytes = Encoding.UTF8.GetBytes(postData);
                SMSrequest.ContentLength = SMSbytes.Length;

                Stream requestStream = SMSrequest.GetRequestStream();
                requestStream.Write(SMSbytes, 0, SMSbytes.Length);
                requestStream.Close();

                WebResponse response = SMSrequest.GetResponse();
                Stream responseStream = response.GetResponseStream();

                StreamReader reader = new StreamReader(responseStream);
                var result = reader.ReadToEnd();
                responseStream.Dispose();
                reader.Dispose();
                requestStream.Dispose();

                #endregion*/

                uow.Commit();
                

                return new ServiceResponse();
            });
        }

        [HttpGet]
        public ActionResult Activate(string t, [FromServices] ISqlConnections sqlConnections)
        {
            if (sqlConnections is null)
                throw new ArgumentNullException(nameof(sqlConnections));

            using var connection = sqlConnections.NewByKey("Default");
            using var uow = new UnitOfWork(connection);
            int userId;
            try
            {
                var bytes = HttpContext.RequestServices
                    .GetDataProtector("Activate").Unprotect(Convert.FromBase64String(t));

                using var ms = new MemoryStream(bytes);
                using var br = new BinaryReader(ms);
                var dt = DateTime.FromBinary(br.ReadInt64());
                if (dt < DateTime.UtcNow)
                    return Error(Texts.Validation.InvalidActivateToken.ToString(Localizer));

                userId = br.ReadInt32();
            }
            catch (Exception)
            {
                return Error(Texts.Validation.InvalidActivateToken.ToString(Localizer));
            }

            var user = uow.Connection.TryById<UserRow>(userId);
            if (user == null || user.IsActive != 0)
                return Error(Texts.Validation.InvalidActivateToken.ToString(Localizer));

            uow.Connection.UpdateById(new UserRow
            {
                UserId = user.UserId.Value,
                IsActive = 1
            });

            Cache.InvalidateOnCommit(uow, UserRow.Fields);
            uow.Commit();

            return new RedirectResult("~/Account/Login?activated=" + Uri.EscapeDataString(user.Email));
        }

        private ActionResult Error(string message)
        {
            return View(MVC.Views.Errors.ValidationError, new ValidationError(message));
        }
    }
}
