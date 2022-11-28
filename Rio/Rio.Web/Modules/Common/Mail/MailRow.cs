using Rio.Administration;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace Rio.Common
{
    [ConnectionKey("Default"), Module("Common"), TableName("[dbo].[Mail]")]
    [DisplayName("Mail"), InstanceName("Mail")]
    [ReadPermission(PermissionKeys.Security)]
    [ModifyPermission(PermissionKeys.Security)]
    public sealed class MailRow : Row<MailRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Mail Id"), Identity, IdProperty]
        public long? MailId
        {
            get => fields.MailId[this];
            set => fields.MailId[this] = value;
        }

        [DisplayName("Uid"), Column("UID"), NotNull]
        public Guid? Uid
        {
            get => fields.Uid[this];
            set => fields.Uid[this] = value;
        }

        [DisplayName("Subject"), Size(400), NotNull, QuickSearch, NameProperty]
        public string Subject
        {
            get => fields.Subject[this];
            set => fields.Subject[this] = value;
        }

        [DisplayName("Body")]
        public string Body
        {
            get => fields.Body[this];
            set => fields.Body[this] = value;
        }

        [DisplayName("Mail From"), Size(100)]
        public string MailFrom
        {
            get => fields.MailFrom[this];
            set => fields.MailFrom[this] = value;
        }

        [DisplayName("Mail To"), Size(2000)]
        public string MailTo
        {
            get => fields.MailTo[this];
            set => fields.MailTo[this] = value;
        }

        [DisplayName("Reply To"), Size(100)]
        public string ReplyTo
        {
            get => fields.ReplyTo[this];
            set => fields.ReplyTo[this] = value;
        }

        [DisplayName("Cc"), Column("CC"), Size(2000)]
        public string Cc
        {
            get => fields.Cc[this];
            set => fields.Cc[this] = value;
        }

        [DisplayName("Bcc"), Column("BCC"), Size(2000)]
        public string Bcc
        {
            get => fields.Bcc[this];
            set => fields.Bcc[this] = value;
        }

        [DisplayName("Priority"), NotNull, ReadOnly(true)]
        public MailQueuePriority? Priority
        {
            get { return (MailQueuePriority?)Fields.Priority[this]; }
            set { Fields.Priority[this] = (Int16?)value; }
        }

        [DisplayName("Status"), NotNull]
        public MailStatus? Status
        {
            get { return (MailStatus?)Fields.Status[this]; }
            set { Fields.Status[this] = (Int16?)value; }
        }

        [DisplayName("Retry Count"), NotNull]
        public int? RetryCount
        {
            get => fields.RetryCount[this];
            set => fields.RetryCount[this] = value;
        }

        [DisplayName("Error Message")]
        public string ErrorMessage
        {
            get => fields.ErrorMessage[this];
            set => fields.ErrorMessage[this] = value;
        }

        [DisplayName("Lock Expiration"), NotNull]
        public DateTime? LockExpiration
        {
            get => fields.LockExpiration[this];
            set => fields.LockExpiration[this] = value;
        }

        [DisplayName("Sent Date")]
        public DateTime? SentDate
        {
            get => fields.SentDate[this];
            set => fields.SentDate[this] = value;
        }

        [DisplayName("Insert User Id")]
        public int? InsertUserId
        {
            get => fields.InsertUserId[this];
            set => fields.InsertUserId[this] = value;
        }

        [DisplayName("Insert Date"), NotNull]
        public DateTime? InsertDate
        {
            get => fields.InsertDate[this];
            set => fields.InsertDate[this] = value;
        }

        [DisplayName("Serialized Message")]
        public byte[] SerializedMessage
        {
            get => fields.SerializedMessage[this];
            set => fields.SerializedMessage[this] = value;
        }

        [DisplayName("Aws User Id"), Size(500)]
        public string AwsUserId
        {
            get => fields.AwsUserId[this];
            set => fields.AwsUserId[this] = value;
        }

        [DisplayName("Aws Password"), Size(500)]
        public string AwsPassword
        {
            get => fields.AwsPassword[this];
            set => fields.AwsPassword[this] = value;
        }

        public MailRow()
            : base()
        {
        }

        public MailRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field MailId;
            public GuidField Uid;
            public StringField Subject;
            public StringField Body;
            public StringField MailFrom;
            public StringField MailTo;
            public StringField ReplyTo;
            public StringField Cc;
            public StringField Bcc;
            public Int32Field Priority;
            public Int32Field Status;
            public Int32Field RetryCount;
            public StringField ErrorMessage;
            public DateTimeField LockExpiration;
            public DateTimeField SentDate;
            public Int32Field InsertUserId;
            public DateTimeField InsertDate;
            public ByteArrayField SerializedMessage;
            public StringField AwsUserId;
            public StringField AwsPassword;
        }
    }
}