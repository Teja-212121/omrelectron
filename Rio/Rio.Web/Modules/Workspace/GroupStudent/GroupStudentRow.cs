using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[dbo].[GroupStudents]")]
    [DisplayName("Group Student"), InstanceName("Group Student")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class GroupStudentRow : LoggingRow<GroupStudentRow.RowFields>, IIdRow, IMultiTenantRow, IIsActiveRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public long? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Group"), NotNull, ForeignKey("[dbo].[Groups]", "Id"), LeftJoin("jGroup"), TextualField("GroupName")]
        [LookupEditor("Workspace.Group")]
        public int? GroupId
        {
            get => fields.GroupId[this];
            set => fields.GroupId[this] = value;
        }

        [DisplayName("Student"), NotNull, ForeignKey("[dbo].[Students]", "Id"), LeftJoin("jStudent"), TextualField("StudentFullName")]
        [LookupEditor("Workspace.Student")]
        public long? StudentId
        {
            get => fields.StudentId[this];
            set => fields.StudentId[this] = value;
        }

        [DisplayName("Is Active"), NotNull, Insertable(false), Updatable(true)]
        public short? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        [DisplayName("Tenant Id"), NotNull]
        [Insertable(false), Updatable(false)]
        public int? TenantId
        {
            get => fields.TenantId[this];
            set => fields.TenantId[this] = value;
        }

        [DisplayName("Group Name"), Expression("jGroup.[Name]")]
        public string GroupName
        {
            get => fields.GroupName[this];
            set => fields.GroupName[this] = value;
        }

        [DisplayName("Group Description"), Expression("jGroup.[Description]")]
        public string GroupDescription
        {
            get => fields.GroupDescription[this];
            set => fields.GroupDescription[this] = value;
        }

        [DisplayName("Group Parent Id"), Expression("jGroup.[ParentId]")]
        public int? GroupParentId
        {
            get => fields.GroupParentId[this];
            set => fields.GroupParentId[this] = value;
        }

        [DisplayName("Group Insert Date"), Expression("jGroup.[InsertDate]")]
        public DateTime? GroupInsertDate
        {
            get => fields.GroupInsertDate[this];
            set => fields.GroupInsertDate[this] = value;
        }

        [DisplayName("Group Insert User Id"), Expression("jGroup.[InsertUserId]")]
        public int? GroupInsertUserId
        {
            get => fields.GroupInsertUserId[this];
            set => fields.GroupInsertUserId[this] = value;
        }

        [DisplayName("Group Update Date"), Expression("jGroup.[UpdateDate]")]
        public DateTime? GroupUpdateDate
        {
            get => fields.GroupUpdateDate[this];
            set => fields.GroupUpdateDate[this] = value;
        }

        [DisplayName("Group Update User Id"), Expression("jGroup.[UpdateUserId]")]
        public int? GroupUpdateUserId
        {
            get => fields.GroupUpdateUserId[this];
            set => fields.GroupUpdateUserId[this] = value;
        }

        [DisplayName("Group Is Active"), Expression("jGroup.[IsActive]")]
        public short? GroupIsActive
        {
            get => fields.GroupIsActive[this];
            set => fields.GroupIsActive[this] = value;
        }

        [DisplayName("Group Tenant Id"), Expression("jGroup.[TenantId]")]
        public int? GroupTenantId
        {
            get => fields.GroupTenantId[this];
            set => fields.GroupTenantId[this] = value;
        }

        [DisplayName("Student Roll No"), Expression("jStudent.[RollNo]")]
        public long? StudentRollNo
        {
            get => fields.StudentRollNo[this];
            set => fields.StudentRollNo[this] = value;
        }

        [DisplayName("Student First Name"), Expression("jStudent.[FirstName]")]
        public string StudentFirstName
        {
            get => fields.StudentFirstName[this];
            set => fields.StudentFirstName[this] = value;
        }

        [DisplayName("Student Middle Name"), Expression("jStudent.[MiddleName]")]
        public string StudentMiddleName
        {
            get => fields.StudentMiddleName[this];
            set => fields.StudentMiddleName[this] = value;
        }

        [DisplayName("Student Last Name"), Expression("jStudent.[LastName]")]
        public string StudentLastName
        {
            get => fields.StudentLastName[this];
            set => fields.StudentLastName[this] = value;
        }

        [DisplayName("Student Full Name"), Expression("jStudent.[FullName]")]
        public string StudentFullName
        {
            get => fields.StudentFullName[this];
            set => fields.StudentFullName[this] = value;
        }

        [DisplayName("Student Email"), Expression("jStudent.[Email]")]
        public string StudentEmail
        {
            get => fields.StudentEmail[this];
            set => fields.StudentEmail[this] = value;
        }

        [DisplayName("Student Mobile"), Expression("jStudent.[Mobile]")]
        public string StudentMobile
        {
            get => fields.StudentMobile[this];
            set => fields.StudentMobile[this] = value;
        }

        [DisplayName("Student Dob"), Expression("jStudent.[DOB]")]
        public DateTime? StudentDob
        {
            get => fields.StudentDob[this];
            set => fields.StudentDob[this] = value;
        }

        [DisplayName("Student Gender"), Expression("jStudent.[Gender]")]
        public short? StudentGender
        {
            get => fields.StudentGender[this];
            set => fields.StudentGender[this] = value;
        }

        [DisplayName("Student Note"), Expression("jStudent.[Note]")]
        public string StudentNote
        {
            get => fields.StudentNote[this];
            set => fields.StudentNote[this] = value;
        }

        [DisplayName("Student Insert Date"), Expression("jStudent.[InsertDate]")]
        public DateTime? StudentInsertDate
        {
            get => fields.StudentInsertDate[this];
            set => fields.StudentInsertDate[this] = value;
        }

        [DisplayName("Student Insert User Id"), Expression("jStudent.[InsertUserId]")]
        public int? StudentInsertUserId
        {
            get => fields.StudentInsertUserId[this];
            set => fields.StudentInsertUserId[this] = value;
        }

        [DisplayName("Student Update Date"), Expression("jStudent.[UpdateDate]")]
        public DateTime? StudentUpdateDate
        {
            get => fields.StudentUpdateDate[this];
            set => fields.StudentUpdateDate[this] = value;
        }

        [DisplayName("Student Update User Id"), Expression("jStudent.[UpdateUserId]")]
        public int? StudentUpdateUserId
        {
            get => fields.StudentUpdateUserId[this];
            set => fields.StudentUpdateUserId[this] = value;
        }

        [DisplayName("Student Is Active"), Expression("jStudent.[IsActive]")]
        public short? StudentIsActive
        {
            get => fields.StudentIsActive[this];
            set => fields.StudentIsActive[this] = value;
        }

        [DisplayName("Student Tenant Id"), Expression("jStudent.[TenantId]")]
        public int? StudentTenantId
        {
            get => fields.StudentTenantId[this];
            set => fields.StudentTenantId[this] = value;
        }

        public Int32Field TenantIdField
        {
            get => Fields.TenantId;
        }

        Int16Field IIsActiveRow.IsActiveField
        {
            get => fields.IsActive;
        }

        public GroupStudentRow()
            : base()
        {
        }

        public GroupStudentRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int64Field Id;
            public Int32Field GroupId;
            public Int64Field StudentId;
            public Int16Field IsActive;
            public Int32Field TenantId;

            public StringField GroupName;
            public StringField GroupDescription;
            public Int32Field GroupParentId;
            public DateTimeField GroupInsertDate;
            public Int32Field GroupInsertUserId;
            public DateTimeField GroupUpdateDate;
            public Int32Field GroupUpdateUserId;
            public Int16Field GroupIsActive;
            public Int32Field GroupTenantId;

            public Int64Field StudentRollNo;
            public StringField StudentFirstName;
            public StringField StudentMiddleName;
            public StringField StudentLastName;
            public StringField StudentFullName;
            public StringField StudentEmail;
            public StringField StudentMobile;
            public DateTimeField StudentDob;
            public Int16Field StudentGender;
            public StringField StudentNote;
            public DateTimeField StudentInsertDate;
            public Int32Field StudentInsertUserId;
            public DateTimeField StudentUpdateDate;
            public Int32Field StudentUpdateUserId;
            public Int16Field StudentIsActive;
            public Int32Field StudentTenantId;
        }
    }
}