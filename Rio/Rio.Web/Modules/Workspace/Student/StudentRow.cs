using Rio.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[Students]")]
    [DisplayName("Student"), InstanceName("Student")]
    [ReadPermission(PermissionKeys.StudentManagement.View)]
    [ModifyPermission(PermissionKeys.StudentManagement.Modify)]
    [LookupScript("Workspace.Student", Permission = "*", LookupType = typeof(MultiTenantRowLookupScript<>))]
    public sealed class StudentRow : LoggingRow<StudentRow.RowFields>, IIdRow, INameRow, IMultiTenantRow, IIsActiveRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        [SortOrder(1, descending: true)]
        public long? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Roll No"), NotNull]
        public long? RollNo
        {
            get => fields.RollNo[this];
            set => fields.RollNo[this] = value;
        }

        [DisplayName("First Name"), Size(100), QuickSearch]
        public string FirstName
        {
            get => fields.FirstName[this];
            set => fields.FirstName[this] = value;
        }

        [DisplayName("Middle Name"), Size(100)]
        public string MiddleName
        {
            get => fields.MiddleName[this];
            set => fields.MiddleName[this] = value;
        }

        [DisplayName("Last Name"), Size(100)]
        public string LastName
        {
            get => fields.LastName[this];
            set => fields.LastName[this] = value;
        }

        [DisplayName("Full Name"), Size(300), NotNull, NameProperty]
        public string FullName
        {
            get => fields.FullName[this];
            set => fields.FullName[this] = value;
        }

        [DisplayName("Email"), Size(500), NotNull]
        public string Email
        {
            get => fields.Email[this];
            set => fields.Email[this] = value;
        }

        [DisplayName("Mobile"), Size(100), NotNull]
        public string Mobile
        {
            get => fields.Mobile[this];
            set => fields.Mobile[this] = value;
        }

        [DisplayName("Dob"), Column("DOB")]
        public DateTime? Dob
        {
            get => fields.Dob[this];
            set => fields.Dob[this] = value;
        }

        [DisplayName("Gender")]
        public Gender? Gender
        {
            get => (Gender)fields.Gender[this];
            set => fields.Gender[this] = (Int16)value;
        }

        [DisplayName("Note"), Size(2000)]
        public string Note
        {
            get => fields.Note[this];
            set => fields.Note[this] = value;
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

        public Int32Field TenantIdField
        {
            get => Fields.TenantId;
        }

        Int16Field IIsActiveRow.IsActiveField
        {
            get => fields.IsActive;
        }

        public StudentRow()
            : base()
        {
        }

        public StudentRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int64Field Id;
            public Int64Field RollNo;
            public StringField FirstName;
            public StringField MiddleName;
            public StringField LastName;
            public StringField FullName;
            public StringField Email;
            public StringField Mobile;
            public DateTimeField Dob;
            public Int16Field Gender;
            public StringField Note;
            public Int16Field IsActive;
            public Int32Field TenantId;
        }
    }
}