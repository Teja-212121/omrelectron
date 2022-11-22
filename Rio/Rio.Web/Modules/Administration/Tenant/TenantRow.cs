using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;
using Rio.Web.Enums;

namespace Rio.Administration
{
    [ConnectionKey("Default"), Module("Administration"), TableName("[Tenants]")]
    [DisplayName("Tenant"), InstanceName("Tenant")]
    [ReadPermission(PermissionKeys.Tenants)]
    [ModifyPermission(PermissionKeys.Tenants)]
    [LookupScript("Administration.Tenant")]
    public sealed class TenantRow : Row<TenantRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Tenant Id"), Identity, IdProperty]
        public int? TenantId
        {
            get => fields.TenantId[this];
            set => fields.TenantId[this] = value;
        }

        [DisplayName("Tenant Name"), Size(100), NotNull, QuickSearch, NameProperty]
        public string TenantName
        {
            get => fields.TenantName[this];
            set => fields.TenantName[this] = value;
        }

        [DisplayName("ApprovalStatus")]
        public EApprovalStatus? EApprovalStatus
        {
            get => (EApprovalStatus?)fields.EApprovalStatus[this];
            set => fields.EApprovalStatus[this] = (short?)value;
        }

        [DisplayName("Is Active"), NotNull]
        public short? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        public TenantRow()
            : base()
        {
        }

        public TenantRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field TenantId;
            public StringField TenantName;
            public Int16Field EApprovalStatus;
            public Int16Field IsActive;
        }
    }
}