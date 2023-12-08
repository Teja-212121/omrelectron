using Rio.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("ActivationLog")]
    [DisplayName("Activation Log"), InstanceName("Activation Log")]
    [ReadPermission(PermissionKeys.ActivationManagement.View)]
    [ModifyPermission(PermissionKeys.ActivationManagement.Modify)]
    [LookupScript("Workspace.ActivationLog", Permission = "*", Expiration = 1)]
    public sealed class ActivationLogRow : LoggingRow<ActivationLogRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Code"), QuickSearch, NameProperty]
        public string Code
        {
            get => fields.Code[this];
            set => fields.Code[this] = value;
        }

        [DisplayName("Serial Key"), NotNull]
        public string SerialKey
        {
            get => fields.SerialKey[this];
            set => fields.SerialKey[this] = value;
        }
        [DisplayName("Serial Key"), ForeignKey("SerialKeys", "Id"), LeftJoin("jSerialKey"), TextualField("SerialKey")]
        [LookupEditor("Workspace.SerialKey")]
        public int? SerialKeyId
        {
            get => fields.SerialKeyId[this];
            set => fields.SerialKeyId[this] = value;
        }
        [DisplayName("Activation"), ForeignKey("[dbo].[Activations]", "Id"), LeftJoin("jActivation")]
        public Int32? ActivationId
        {
            get { return Fields.ActivationId[this]; }
            set { Fields.ActivationId[this] = value; }
        }
        [DisplayName("Teacher"), ForeignKey("Teachers", "Id"), LeftJoin("jTeacher"), TextualField("TeacherFirstName")]
        [LookupEditor("Workspace.Teachers")]
        public long? TeacherId
        {
            get => fields.TeacherId[this];
            set => fields.TeacherId[this] = value;
        }

        [DisplayName("Exam List"), ForeignKey("ExamLists", "Id"), LeftJoin("jExamList"), TextualField("ExamListName")]
        [LookupEditor("Workspace.ExamList")]
        public int? ExamListId
        {
            get => fields.ExamListId[this];
            set => fields.ExamListId[this] = value;
        }

        [DisplayName("Device Id")]
        public string DeviceId
        {
            get => fields.DeviceId[this];
            set => fields.DeviceId[this] = value;
        }

        [DisplayName("Device Details")]
        public string DeviceDetails
        {
            get => fields.DeviceDetails[this];
            set => fields.DeviceDetails[this] = value;
        }

        [DisplayName("E Status"), Column("eStatus")]
        public KeyStatus? EStatus
        {
            get => (KeyStatus?)fields.EStatus[this];
            set => fields.EStatus[this] = (short?)value;
        }

        [DisplayName("Note")]
        public string Note
        {
            get => fields.Note[this];
            set => fields.Note[this] = value;
        }

        [DisplayName("Is Active"), DefaultValue(1)]
        public int? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        [DisplayName("Teacher First Name"), Expression("jTeacher.[FirstName]")]
        public string TeacherFirstName
        {
            get => fields.TeacherFirstName[this];
            set => fields.TeacherFirstName[this] = value;
        }

        [DisplayName("Teacher Middle Name"), Expression("jTeacher.[MiddleName]")]
        public string TeacherMiddleName
        {
            get => fields.TeacherMiddleName[this];
            set => fields.TeacherMiddleName[this] = value;
        }

        [DisplayName("Teacher Last Name"), Expression("jTeacher.[LastName]")]
        public string TeacherLastName
        {
            get => fields.TeacherLastName[this];
            set => fields.TeacherLastName[this] = value;
        }

        [DisplayName("Teacher Full Name"), Expression("jTeacher.[FullName]")]
        public string TeacherFullName
        {
            get => fields.TeacherFullName[this];
            set => fields.TeacherFullName[this] = value;
        }

        [DisplayName("Teacher Email"), Expression("jTeacher.[Email]")]
        public string TeacherEmail
        {
            get => fields.TeacherEmail[this];
            set => fields.TeacherEmail[this] = value;
        }

        [DisplayName("Teacher Mobile"), Expression("jTeacher.[Mobile]")]
        public string TeacherMobile
        {
            get => fields.TeacherMobile[this];
            set => fields.TeacherMobile[this] = value;
        }

        [DisplayName("Teacher Dob"), Expression("jTeacher.[DOB]")]
        public DateTime? TeacherDob
        {
            get => fields.TeacherDob[this];
            set => fields.TeacherDob[this] = value;
        }

        [DisplayName("Teacher Allowed Ips"), Expression("jTeacher.[AllowedIps]")]
        public string TeacherAllowedIps
        {
            get => fields.TeacherAllowedIps[this];
            set => fields.TeacherAllowedIps[this] = value;
        }

        [DisplayName("Teacher Address"), Expression("jTeacher.[Address]")]
        public string TeacherAddress
        {
            get => fields.TeacherAddress[this];
            set => fields.TeacherAddress[this] = value;
        }

        [DisplayName("Teacher City"), Expression("jTeacher.[City]")]
        public string TeacherCity
        {
            get => fields.TeacherCity[this];
            set => fields.TeacherCity[this] = value;
        }

        [DisplayName("Teacher User Id"), Expression("jTeacher.[UserId]")]
        public int? TeacherUserId
        {
            get => fields.TeacherUserId[this];
            set => fields.TeacherUserId[this] = value;
        }

        [DisplayName("Teacher Insert Date"), Expression("jTeacher.[InsertDate]")]
        public DateTime? TeacherInsertDate
        {
            get => fields.TeacherInsertDate[this];
            set => fields.TeacherInsertDate[this] = value;
        }

        [DisplayName("Teacher Insert User Id"), Expression("jTeacher.[InsertUserId]")]
        public int? TeacherInsertUserId
        {
            get => fields.TeacherInsertUserId[this];
            set => fields.TeacherInsertUserId[this] = value;
        }

        [DisplayName("Teacher Update Date"), Expression("jTeacher.[UpdateDate]")]
        public DateTime? TeacherUpdateDate
        {
            get => fields.TeacherUpdateDate[this];
            set => fields.TeacherUpdateDate[this] = value;
        }

        [DisplayName("Teacher Update User Id"), Expression("jTeacher.[UpdateUserId]")]
        public int? TeacherUpdateUserId
        {
            get => fields.TeacherUpdateUserId[this];
            set => fields.TeacherUpdateUserId[this] = value;
        }

        [DisplayName("Teacher Is Active"), Expression("jTeacher.[IsActive]")]
        public int? TeacherIsActive
        {
            get => fields.TeacherIsActive[this];
            set => fields.TeacherIsActive[this] = value;
        }

        [DisplayName("Teacher Tenant Id"), Expression("jTeacher.[TenantId]")]
        public int? TeacherTenantId
        {
            get => fields.TeacherTenantId[this];
            set => fields.TeacherTenantId[this] = value;
        }

        [DisplayName("Teacher School Or Institute"), Expression("jTeacher.[SchoolOrInstitute]")]
        public string TeacherSchoolOrInstitute
        {
            get => fields.TeacherSchoolOrInstitute[this];
            set => fields.TeacherSchoolOrInstitute[this] = value;
        }

        [DisplayName("Exam List Name"), Expression("jExamList.[Name]")]
        public string ExamListName
        {
            get => fields.ExamListName[this];
            set => fields.ExamListName[this] = value;
        }

        [DisplayName("Exam List Description"), Expression("jExamList.[Description]")]
        public string ExamListDescription
        {
            get => fields.ExamListDescription[this];
            set => fields.ExamListDescription[this] = value;
        }

        [DisplayName("Exam List Insert Date"), Expression("jExamList.[InsertDate]")]
        public DateTime? ExamListInsertDate
        {
            get => fields.ExamListInsertDate[this];
            set => fields.ExamListInsertDate[this] = value;
        }

        [DisplayName("Exam List Insert User Id"), Expression("jExamList.[InsertUserId]")]
        public int? ExamListInsertUserId
        {
            get => fields.ExamListInsertUserId[this];
            set => fields.ExamListInsertUserId[this] = value;
        }

        [DisplayName("Exam List Update Date"), Expression("jExamList.[UpdateDate]")]
        public DateTime? ExamListUpdateDate
        {
            get => fields.ExamListUpdateDate[this];
            set => fields.ExamListUpdateDate[this] = value;
        }

        [DisplayName("Exam List Update User Id"), Expression("jExamList.[UpdateUserId]")]
        public int? ExamListUpdateUserId
        {
            get => fields.ExamListUpdateUserId[this];
            set => fields.ExamListUpdateUserId[this] = value;
        }

        [DisplayName("Exam List Is Active"), Expression("jExamList.[IsActive]")]
        public int? ExamListIsActive
        {
            get => fields.ExamListIsActive[this];
            set => fields.ExamListIsActive[this] = value;
        }

        [DisplayName("Exam List Tenant Id"), Expression("jExamList.[TenantId]")]
        public int? ExamListTenantId
        {
            get => fields.ExamListTenantId[this];
            set => fields.ExamListTenantId[this] = value;
        }

        public ActivationLogRow()
            : base()
        {
        }

        public ActivationLogRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int32Field Id;
            public StringField Code;
            public StringField SerialKey;
            public Int64Field TeacherId;
            public Int32Field ExamListId;
            public StringField DeviceId;
            public StringField DeviceDetails;
            public Int32Field EStatus;
            public StringField Note;
            public Int32Field SerialKeyId;
            public Int32Field IsActive;

            public StringField TeacherFirstName;
            public StringField TeacherMiddleName;
            public StringField TeacherLastName;
            public StringField TeacherFullName;
            public StringField TeacherEmail;
            public StringField TeacherMobile;
            public DateTimeField TeacherDob;
            public StringField TeacherAllowedIps;
            public StringField TeacherAddress;
            public StringField TeacherCity;
            public Int32Field TeacherUserId;
            public DateTimeField TeacherInsertDate;
            public Int32Field TeacherInsertUserId;
            public DateTimeField TeacherUpdateDate;
            public Int32Field TeacherUpdateUserId;
            public Int32Field TeacherIsActive;
            public Int32Field TeacherTenantId;
            public StringField TeacherSchoolOrInstitute;
           public Int32Field ActivationId;
            public StringField ExamListName;
            public StringField ExamListDescription;
            public DateTimeField ExamListInsertDate;
            public Int32Field ExamListInsertUserId;
            public DateTimeField ExamListUpdateDate;
            public Int32Field ExamListUpdateUserId;
            public Int32Field ExamListIsActive;
            public Int32Field ExamListTenantId;
        }
    }
}