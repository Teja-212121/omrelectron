using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[dbo].[Teachers]")]
    [DisplayName("Teachers"), InstanceName("Teachers")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class TeachersRow : LoggingRow<TeachersRow.RowFields>, IIdRow, INameRow, IMultiTenantRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public long? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("First Name"), Size(100), QuickSearch, NameProperty]
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

        [DisplayName("Full Name"), Size(300)]
        public string FullName
        {
            get => fields.FullName[this];
            set => fields.FullName[this] = value;
        }

        [DisplayName("Email"), Size(500), NotNull,EmailEditor]
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

        [DisplayName("Allowed Ips"), Size(2000)]
        public string AllowedIps
        {
            get => fields.AllowedIps[this];
            set => fields.AllowedIps[this] = value;
        }

        [DisplayName("Address"), Size(2000)]
        public string Address
        {
            get => fields.Address[this];
            set => fields.Address[this] = value;
        }

        [DisplayName("City"), Size(500)]
        public string City
        {
            get => fields.City[this];
            set => fields.City[this] = value;
        }

        [DisplayName("User Id")]
        public int? UserId
        {
            get => fields.UserId[this];
            set => fields.UserId[this] = value;
        }

       

        [DisplayName("Is Active"), NotNull,DefaultValue(1)]
        public short? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }
        public Int32Field TenantIdField
        {
            get => Fields.TenantId;
        }
        [DisplayName("Tenant Id"), NotNull, Insertable(false), Updatable(true)]
        public int? TenantId
        {
            get => fields.TenantId[this];
            set => fields.TenantId[this] = value;
        }

        public TeachersRow()
            : base()
        {
        }

        public TeachersRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int64Field Id;
            public StringField FirstName;
            public StringField MiddleName;
            public StringField LastName;
            public StringField FullName;
            public StringField Email;
            public StringField Mobile;
            public DateTimeField Dob;
            public StringField AllowedIps;
            public StringField Address;
            public StringField City;
            public Int32Field UserId;
            public Int16Field IsActive;
            public Int32Field TenantId;
        }
    }
}