
namespace Rio.Common.Services
{
   
 
    using MimeKit;
    using Serenity;
    using Serenity.Data;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.IO;
    using System.Linq;
    using System.Net.Mail;
    using System.Threading.Tasks;
    using System.Net;
  
    public class MailSettings
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public bool UseSsl { get; set; }
        public string From { get; set; }
    }
    public class MailingService
    {
        private static readonly char[] mailSplitter = { ',', ';' };

        private IEnumerable<string> SplitEmails(string s)
        {
            if (s == null)
                return new string[0];

            return s.Split(mailSplitter, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => !string.IsNullOrWhiteSpace(x));
        }

        private MailMessage BuildMessage(MailRow mail)
        {
            var message = new MailMessage();
            message.Body = mail.Body;
            message.Subject = mail.Subject;
            if (!string.IsNullOrEmpty(mail.MailFrom))
                message.From = new MailAddress(mail.MailFrom);

            message.IsBodyHtml = true;

            foreach (var x in SplitEmails(mail.ReplyTo))
                message.ReplyToList.Add(x);

            foreach (var x in SplitEmails(mail.MailTo))
                message.To.Add(x);

            foreach (var x in SplitEmails(mail.Cc))
                message.CC.Add(x);

            foreach (var x in SplitEmails(mail.Bcc))
                message.Bcc.Add(x);

            return message;
        }

        public void Enqueue(IDbConnection connection, MailMessage message, Guid? uid = null)
        {
            var mail = new MailRow();
            mail.Uid = uid ?? Guid.NewGuid();
            mail.Subject = message.Subject;
            mail.Body = message.Body;
            mail.Priority = message.Priority == MailPriority.Normal ? MailQueuePriority.Medium : (message.Priority == MailPriority.Low ? MailQueuePriority.Low : MailQueuePriority.High);
            mail.Status = MailStatus.InQueue;
            mail.LockExpiration = DateTime.Now.AddDays(-1);
            mail.InsertDate = DateTime.Now;
            mail.InsertUserId =1;
            mail.RetryCount = 0;
            mail.MailFrom = message.From != null ? message.From.ToString() : null;
            if (message.To.Count > 0)
                mail.MailTo = string.Join(";", message.To.Select(x => x.ToString()));
            if (message.CC.Count > 0)
                mail.Cc = string.Join(";", message.CC.Select(x => x.ToString()));
            if (message.Bcc.Count > 0)
                mail.Bcc = string.Join(";", message.Bcc.Select(x => x.ToString()));
            if (message.ReplyToList.Count > 0)
                mail.ReplyTo = string.Join(";", message.ReplyToList.Select(x => x.ToString()));
            connection.Insert(mail);
        }

        public bool SendById(IDbConnection connection, long mailId)
        {
            var mail = connection.ById<MailRow>(mailId);
             //IOptions<MailingServiceSettings> settings;
            var status = MailStatus.Sent;
            var retryCount = (mail.RetryCount ?? 0) + 1;

            string errorMessage = null;
            try
            {

                //var config = Config.Get<MailingServiceSettings>();
                MailSettings config = new MailSettings();
                
                //var message = BuildMessage(mail);
                //Common.EmailHelper.Send(mail.Subject, mail.Body, mail.MailTo);
                var message = new MimeMessage();
                //if (!string.IsNullOrEmpty(config.From))
                //    message.From.Add(MailboxAddress.Parse(config.From));
                foreach (var to in mail.MailTo.Split(','))
                    message.To.Add(new MailboxAddress("Antargyan", to));
                if (!string.IsNullOrEmpty(mail.Cc))
                    foreach (var cc in mail.Cc.Split(','))
                        message.Cc.Add(new MailboxAddress(cc, cc));
                if (!string.IsNullOrEmpty(mail.Bcc))
                    foreach (var bcc in mail.Bcc.Split(','))
                        message.Bcc.Add(new MailboxAddress(bcc, bcc));
                message.Subject = mail.Subject;
                var bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = mail.Body;
                message.Body = bodyBuilder.ToMessageBody();
                //if (string.IsNullOrEmpty(mail.FromName))
                //    mail.FromName = "Inspire Academy";
                //if (!string.IsNullOrEmpty(config.Host))
                //{
                    var client = new MailKit.Net.Smtp.SmtpClient();
                    message.From.Add(new MailboxAddress("", mail.MailFrom));

                    client.Connect("email-smtp.us-west-2.amazonaws.com", 465);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate(new NetworkCredential(mail.AwsUserId, mail.AwsPassword));
                    client.Send(message);
                    Task.Delay(500);
                    client.Disconnect(true);
                //}
                //else
                //{
                //    //var pickupPath = Path.Combine(Dependency.Resolve<IWebHostEnvironment>().ContentRootPath, "App_Data");
                //    //pickupPath = Path.Combine(pickupPath, "Mail");
                //    //Directory.CreateDirectory(pickupPath);
                //    //message.WriteTo(Path.Combine(pickupPath, DateTime.Now.ToString("yyyyMMdd_HHmmss_fff") + ".eml"));
                //}

            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                status = retryCount < 5 ?
                    MailStatus.InQueue : MailStatus.Failed;
            }

            connection.UpdateById(new MailRow
            {
                MailId = mail.MailId,
                Status = status,
                SentDate = DateTime.Now,
                ErrorMessage = errorMessage,
                RetryCount = (short)retryCount
            });

            return errorMessage != null;
        }
    }
}