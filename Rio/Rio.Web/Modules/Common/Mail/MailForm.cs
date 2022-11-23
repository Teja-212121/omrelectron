using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Common.Forms
{
    [FormScript("Common.Mail")]
    [BasedOnRow(typeof(MailRow), CheckNames = true)]
    public class MailForm
    {
        public Guid Uid { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string MailFrom { get; set; }
        public string MailTo { get; set; }
        public string ReplyTo { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public int Priority { get; set; }
        public int Status { get; set; }
        public int RetryCount { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime LockExpiration { get; set; }
        public DateTime SentDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime InsertDate { get; set; }
        public byte[] SerializedMessage { get; set; }
        public string AwsUserId { get; set; }
        public string AwsPassword { get; set; }
    }
}