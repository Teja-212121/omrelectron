using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[dbo].[CloudStorageSettings]")]
    [DisplayName("Cloud Storage Setting"), InstanceName("Cloud Storage Setting")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class CloudStorageSettingRow : Row<CloudStorageSettingRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Cloud Storage Providers"), Size(500), ForeignKey("[dbo].[CloudStorageProviders]", "Id"), LeftJoin("jCloudStorageProviders"), QuickSearch, NameProperty, TextualField("CloudStorageProvidersName")]
        [LookupEditor("Workspace.CloudStorageProvider")]
        public string CloudStorageProvidersId
        {
            get => fields.CloudStorageProvidersId[this];
            set => fields.CloudStorageProvidersId[this] = value;
        }

        [DisplayName("Tenant"), ForeignKey("[dbo].[Tenants]", "TenantId"), LeftJoin("jTenant"), TextualField("TenantTenantName")]
        [LookupEditor("Administration.Tenant")]
        public int? TenantId
        {
            get => fields.TenantId[this];
            set => fields.TenantId[this] = value;
        }

        [DisplayName("Parameter1"), Size(1000)]
        public string Parameter1
        {
            get => fields.Parameter1[this];
            set => fields.Parameter1[this] = value;
        }

        [DisplayName("Parameter2"), Size(1000)]
        public string Parameter2
        {
            get => fields.Parameter2[this];
            set => fields.Parameter2[this] = value;
        }

        [DisplayName("Parameter3"), Size(1000)]
        public string Parameter3
        {
            get => fields.Parameter3[this];
            set => fields.Parameter3[this] = value;
        }

        [DisplayName("Parameter4"), Size(1000)]
        public string Parameter4
        {
            get => fields.Parameter4[this];
            set => fields.Parameter4[this] = value;
        }

        [DisplayName("Parameter5"), Size(1000)]
        public string Parameter5
        {
            get => fields.Parameter5[this];
            set => fields.Parameter5[this] = value;
        }

        [DisplayName("Parameter6"), Size(1000)]
        public string Parameter6
        {
            get => fields.Parameter6[this];
            set => fields.Parameter6[this] = value;
        }

        [DisplayName("Parameter7"), Size(1000)]
        public string Parameter7
        {
            get => fields.Parameter7[this];
            set => fields.Parameter7[this] = value;
        }

        [DisplayName("Parameter8"), Size(1000)]
        public string Parameter8
        {
            get => fields.Parameter8[this];
            set => fields.Parameter8[this] = value;
        }

        [DisplayName("Parameter9"), Size(1000)]
        public string Parameter9
        {
            get => fields.Parameter9[this];
            set => fields.Parameter9[this] = value;
        }

        [DisplayName("Parameter10"), Size(1000)]
        public string Parameter10
        {
            get => fields.Parameter10[this];
            set => fields.Parameter10[this] = value;
        }

        [DisplayName("Parameter Provider"), Size(1000)]
        public string ParameterProvider
        {
            get => fields.ParameterProvider[this];
            set => fields.ParameterProvider[this] = value;
        }

        [DisplayName("Cloud Storage Providers Name"), Expression("jCloudStorageProviders.[Name]")]
        public string CloudStorageProvidersName
        {
            get => fields.CloudStorageProvidersName[this];
            set => fields.CloudStorageProvidersName[this] = value;
        }

        [DisplayName("Cloud Storage Providers Description"), Expression("jCloudStorageProviders.[Description]")]
        public string CloudStorageProvidersDescription
        {
            get => fields.CloudStorageProvidersDescription[this];
            set => fields.CloudStorageProvidersDescription[this] = value;
        }

        [DisplayName("Cloud Storage Providers Number Of Parameter"), Expression("jCloudStorageProviders.[NumberOfParameter]")]
        public short? CloudStorageProvidersNumberOfParameter
        {
            get => fields.CloudStorageProvidersNumberOfParameter[this];
            set => fields.CloudStorageProvidersNumberOfParameter[this] = value;
        }

        [DisplayName("Cloud Storage Providers Tenant Id"), Expression("jCloudStorageProviders.[TenantId]")]
        public int? CloudStorageProvidersTenantId
        {
            get => fields.CloudStorageProvidersTenantId[this];
            set => fields.CloudStorageProvidersTenantId[this] = value;
        }

        [DisplayName("Cloud Storage Providers Parameter1 Title"), Expression("jCloudStorageProviders.[Parameter1Title]")]
        public string CloudStorageProvidersParameter1Title
        {
            get => fields.CloudStorageProvidersParameter1Title[this];
            set => fields.CloudStorageProvidersParameter1Title[this] = value;
        }

        [DisplayName("Cloud Storage Providers Parameter2 Title"), Expression("jCloudStorageProviders.[Parameter2Title]")]
        public string CloudStorageProvidersParameter2Title
        {
            get => fields.CloudStorageProvidersParameter2Title[this];
            set => fields.CloudStorageProvidersParameter2Title[this] = value;
        }

        [DisplayName("Cloud Storage Providers Parameter3 Title"), Expression("jCloudStorageProviders.[Parameter3Title]")]
        public string CloudStorageProvidersParameter3Title
        {
            get => fields.CloudStorageProvidersParameter3Title[this];
            set => fields.CloudStorageProvidersParameter3Title[this] = value;
        }

        [DisplayName("Cloud Storage Providers Parameter4 Title"), Expression("jCloudStorageProviders.[Parameter4Title]")]
        public string CloudStorageProvidersParameter4Title
        {
            get => fields.CloudStorageProvidersParameter4Title[this];
            set => fields.CloudStorageProvidersParameter4Title[this] = value;
        }

        [DisplayName("Cloud Storage Providers Parameter5 Title"), Expression("jCloudStorageProviders.[Parameter5Title]")]
        public string CloudStorageProvidersParameter5Title
        {
            get => fields.CloudStorageProvidersParameter5Title[this];
            set => fields.CloudStorageProvidersParameter5Title[this] = value;
        }

        [DisplayName("Cloud Storage Providers Parameter6 Title"), Expression("jCloudStorageProviders.[Parameter6Title]")]
        public string CloudStorageProvidersParameter6Title
        {
            get => fields.CloudStorageProvidersParameter6Title[this];
            set => fields.CloudStorageProvidersParameter6Title[this] = value;
        }

        [DisplayName("Cloud Storage Providers Parameter7 Title"), Expression("jCloudStorageProviders.[Parameter7Title]")]
        public string CloudStorageProvidersParameter7Title
        {
            get => fields.CloudStorageProvidersParameter7Title[this];
            set => fields.CloudStorageProvidersParameter7Title[this] = value;
        }

        [DisplayName("Cloud Storage Providers Parameter8 Title"), Expression("jCloudStorageProviders.[Parameter8Title]")]
        public string CloudStorageProvidersParameter8Title
        {
            get => fields.CloudStorageProvidersParameter8Title[this];
            set => fields.CloudStorageProvidersParameter8Title[this] = value;
        }

        [DisplayName("Cloud Storage Providers Parameter9 Title"), Expression("jCloudStorageProviders.[Parameter9Title]")]
        public string CloudStorageProvidersParameter9Title
        {
            get => fields.CloudStorageProvidersParameter9Title[this];
            set => fields.CloudStorageProvidersParameter9Title[this] = value;
        }

        [DisplayName("Cloud Storage Providers Parameter10 Title"), Expression("jCloudStorageProviders.[Parameter10Title]")]
        public string CloudStorageProvidersParameter10Title
        {
            get => fields.CloudStorageProvidersParameter10Title[this];
            set => fields.CloudStorageProvidersParameter10Title[this] = value;
        }

        [DisplayName("Cloud Storage Providers Parameter Provider"), Expression("jCloudStorageProviders.[ParameterProvider]")]
        public string CloudStorageProvidersParameterProvider
        {
            get => fields.CloudStorageProvidersParameterProvider[this];
            set => fields.CloudStorageProvidersParameterProvider[this] = value;
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

        public CloudStorageSettingRow()
            : base()
        {
        }

        public CloudStorageSettingRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField CloudStorageProvidersId;
            public Int32Field TenantId;
            public StringField Parameter1;
            public StringField Parameter2;
            public StringField Parameter3;
            public StringField Parameter4;
            public StringField Parameter5;
            public StringField Parameter6;
            public StringField Parameter7;
            public StringField Parameter8;
            public StringField Parameter9;
            public StringField Parameter10;
            public StringField ParameterProvider;

            public StringField CloudStorageProvidersName;
            public StringField CloudStorageProvidersDescription;
            public Int16Field CloudStorageProvidersNumberOfParameter;
            public Int32Field CloudStorageProvidersTenantId;
            public StringField CloudStorageProvidersParameter1Title;
            public StringField CloudStorageProvidersParameter2Title;
            public StringField CloudStorageProvidersParameter3Title;
            public StringField CloudStorageProvidersParameter4Title;
            public StringField CloudStorageProvidersParameter5Title;
            public StringField CloudStorageProvidersParameter6Title;
            public StringField CloudStorageProvidersParameter7Title;
            public StringField CloudStorageProvidersParameter8Title;
            public StringField CloudStorageProvidersParameter9Title;
            public StringField CloudStorageProvidersParameter10Title;
            public StringField CloudStorageProvidersParameterProvider;

            public StringField TenantTenantName;
            public Int16Field TenantEApprovalStatus;
            public Int16Field TenantIsActive;
        }
    }
}