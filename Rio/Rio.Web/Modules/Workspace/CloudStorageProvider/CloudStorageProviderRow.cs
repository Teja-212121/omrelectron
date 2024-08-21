using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[dbo].[CloudStorageProviders]")]
    [DisplayName("Cloud Storage Provider"), InstanceName("Cloud Storage Provider")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Workspace.CloudStorageProvider")]
    public sealed class CloudStorageProviderRow : Row<CloudStorageProviderRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Size(500), PrimaryKey, NotNull, IdProperty, QuickSearch]
        public string Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Name"), Size(500), NotNull, NameProperty]
        public string Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }

        [DisplayName("Description"), Size(1000)]
        public string Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        [DisplayName("Number Of Parameter"), NotNull]
        public short? NumberOfParameter
        {
            get => fields.NumberOfParameter[this];
            set => fields.NumberOfParameter[this] = value;
        }

        [DisplayName("Tenant"), ForeignKey("[dbo].[Tenants]", "TenantId"), LeftJoin("jTenant"), TextualField("TenantTenantName")]
        [LookupEditor("Administration.Tenant")]
        public int? TenantId
        {
            get => fields.TenantId[this];
            set => fields.TenantId[this] = value;
        }

        [DisplayName("Parameter1 Title"), Size(1000)]
        public string Parameter1Title
        {
            get => fields.Parameter1Title[this];
            set => fields.Parameter1Title[this] = value;
        }

        [DisplayName("Parameter2 Title"), Size(1000)]
        public string Parameter2Title
        {
            get => fields.Parameter2Title[this];
            set => fields.Parameter2Title[this] = value;
        }

        [DisplayName("Parameter3 Title"), Size(1000)]
        public string Parameter3Title
        {
            get => fields.Parameter3Title[this];
            set => fields.Parameter3Title[this] = value;
        }

        [DisplayName("Parameter4 Title"), Size(1000)]
        public string Parameter4Title
        {
            get => fields.Parameter4Title[this];
            set => fields.Parameter4Title[this] = value;
        }

        [DisplayName("Parameter5 Title"), Size(1000)]
        public string Parameter5Title
        {
            get => fields.Parameter5Title[this];
            set => fields.Parameter5Title[this] = value;
        }

        [DisplayName("Parameter6 Title"), Size(1000)]
        public string Parameter6Title
        {
            get => fields.Parameter6Title[this];
            set => fields.Parameter6Title[this] = value;
        }

        [DisplayName("Parameter7 Title"), Size(1000)]
        public string Parameter7Title
        {
            get => fields.Parameter7Title[this];
            set => fields.Parameter7Title[this] = value;
        }

        [DisplayName("Parameter8 Title"), Size(1000)]
        public string Parameter8Title
        {
            get => fields.Parameter8Title[this];
            set => fields.Parameter8Title[this] = value;
        }

        [DisplayName("Parameter9 Title"), Size(1000)]
        public string Parameter9Title
        {
            get => fields.Parameter9Title[this];
            set => fields.Parameter9Title[this] = value;
        }

        [DisplayName("Parameter10 Title"), Size(1000)]
        public string Parameter10Title
        {
            get => fields.Parameter10Title[this];
            set => fields.Parameter10Title[this] = value;
        }

        [DisplayName("Parameter Provider"), Size(1000)]
        public string ParameterProvider
        {
            get => fields.ParameterProvider[this];
            set => fields.ParameterProvider[this] = value;
        }

        [DisplayName("Tenant Tenant Name"), Expression("jTenant.[TenantName]")]
        public string TenantTenantName
        {
            get => fields.TenantTenantName[this];
            set => fields.TenantTenantName[this] = value;
        }

        [DisplayName("Tenant E Approval Status"), Expression("jTenant.[EApprovalStatus]")]
        public short? TenantEApprovalStatus
        {
            get => fields.TenantEApprovalStatus[this];
            set => fields.TenantEApprovalStatus[this] = value;
        }

        [DisplayName("Tenant Is Active"), Expression("jTenant.[IsActive]")]
        public short? TenantIsActive
        {
            get => fields.TenantIsActive[this];
            set => fields.TenantIsActive[this] = value;
        }

        public CloudStorageProviderRow()
            : base()
        {
        }

        public CloudStorageProviderRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField Id;
            public StringField Name;
            public StringField Description;
            public Int16Field NumberOfParameter;
            public Int32Field TenantId;
            public StringField Parameter1Title;
            public StringField Parameter2Title;
            public StringField Parameter3Title;
            public StringField Parameter4Title;
            public StringField Parameter5Title;
            public StringField Parameter6Title;
            public StringField Parameter7Title;
            public StringField Parameter8Title;
            public StringField Parameter9Title;
            public StringField Parameter10Title;
            public StringField ParameterProvider;

            public StringField TenantTenantName;
            public Int16Field TenantEApprovalStatus;
            public Int16Field TenantIsActive;
        }
    }
}