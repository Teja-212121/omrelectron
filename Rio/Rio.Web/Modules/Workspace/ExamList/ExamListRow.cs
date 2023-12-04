using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("ExamLists")]
    [DisplayName("Exam List"), InstanceName("Exam List")]
    [ReadPermission(PermissionKeys.ExamListManagement.View)]
    [ModifyPermission(PermissionKeys.ExamListManagement.Modify)]
    [LookupScript("Workspace.ExamList", Permission = "*")]
    public sealed class ExamListRow : LoggingRow<ExamListRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Name"), NotNull, QuickSearch, NameProperty]
        public string Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }

        [DisplayName("Description")]
        public string Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }      

        [DisplayName("Is Active"), DefaultValue(1)]
        public int? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        [DisplayName("Tenant"), NotNull, ForeignKey("Tenants", "TenantId"), LeftJoin("jTenant"), TextualField("TenantTenantName")]
        [LookupEditor("Administration.Tenant")]
        public int? TenantId
        {
            get => fields.TenantId[this];
            set => fields.TenantId[this] = value;
        }

        [DisplayName("Tenant Tenant Name"), Expression("jTenant.[TenantName]")]
        public string TenantTenantName
        {
            get => fields.TenantTenantName[this];
            set => fields.TenantTenantName[this] = value;
        }

        [DisplayName("Tenant E Approval Status"), Expression("jTenant.[EApprovalStatus]")]
        public int? TenantEApprovalStatus
        {
            get => fields.TenantEApprovalStatus[this];
            set => fields.TenantEApprovalStatus[this] = value;
        }

        [DisplayName("Tenant Is Active"), Expression("jTenant.[IsActive]")]
        public int? TenantIsActive
        {
            get => fields.TenantIsActive[this];
            set => fields.TenantIsActive[this] = value;
        }

        public ExamListRow()
            : base()
        {
        }

        public ExamListRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int32Field Id;
            public StringField Name;
            public StringField Description;
          
            public Int32Field IsActive;
            public Int32Field TenantId;

            public StringField TenantTenantName;
            public Int32Field TenantEApprovalStatus;
            public Int32Field TenantIsActive;
        }
    }
}