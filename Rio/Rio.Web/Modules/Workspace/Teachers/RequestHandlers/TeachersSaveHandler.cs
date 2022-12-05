using Rio.Administration;
using Rio.Common;
using Rio.Membership;
using Rio.Web;
using Serenity.Data;
using Serenity.Services;
using Serenity.Web;
using System;
using System.IO;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.TeachersRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.TeachersRow;

namespace Rio.Workspace
{
    public interface ITeachersSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class TeachersSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITeachersSaveHandler
    {
        protected IServiceProvider ServiceProvider { get; }
        public TeachersSaveHandler(IRequestContext context, IServiceProvider serviceProvider)
             : base(context)
        {
            ServiceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
        }

        protected override void BeforeSave()
        {
            base.BeforeSave();
            if (IsCreate)
            {
                if (Connection.Exists<UserRow>(
                            UserRow.Fields.Username == Row.Email |
                            UserRow.Fields.Email == Row.Email))
                {
                    throw new ValidationError("EmailInUse", Texts.Validation.EmailInUse.ToString(Localizer));
                }

                string salt = null;
                if (!string.IsNullOrEmpty(Row.MiddleName))
                    Row.FullName = Row.FirstName + " " + Row.MiddleName + " " + Row.LastName;
                else
                    Row.FullName = Row.FirstName + " " + Row.LastName;
                string password = Password.Generate(8, 2);
                var hash = UserHelper.GenerateHash(password, ref salt);
                var displayName = Row.FullName;
                var email = Row.Email;
                var username = Row.Email;

                var fld = UserRow.Fields;
                var userId = (int)Connection.InsertAndGetID(new UserRow
                {
                    Username = username,
                    Source = "sign",
                    DisplayName = displayName,
                    Email = email,
                    PasswordHash = hash,
                    PasswordSalt = salt,
                    IsActive = 0,
                    InsertDate = DateTime.Now,
                    InsertUserId = 1,
                    LastDirectoryUpdate = DateTime.Now,
                    TenantId = User.GetTenantId()
                });
                Row.UserId = userId;
                byte[] bytes;
                using (var ms = new MemoryStream())
                using (var bw = new BinaryWriter(ms))
                {
                    bw.Write(DateTime.UtcNow.AddHours(3).ToBinary());
                    bw.Write(userId);
                    bw.Flush();
                    bytes = ms.ToArray();
                }




                var emailModel = new ActivateEmailModel
                {
                    Username = username,
                    DisplayName = displayName,
                    Password = password
                    //ActivateLink = activateLink
                };

                var emailSubject = "Teacher Account Created";
                var emailBody = TemplateHelper.RenderViewToString(ServiceProvider,
                    MVC.Views.Membership.Account.SignUp.TeacherSignupEmail, emailModel);

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
                Connection.Insert<MailRow>(mail);
                #endregion
            }
        }
    }
}