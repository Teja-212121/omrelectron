using Rio.Web.Enums;
using Serenity.ComponentModel;
using System.ComponentModel;

namespace Rio.Administration.Columns
{
    [ColumnsScript("Administration.Tenant")]
    [BasedOnRow(typeof(TenantRow), CheckNames = true)]
    public class TenantColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight,SortOrder(1,true)]
        public int TenantId { get; set; }
        [EditLink]
        public string TenantName { get; set; }
        public EApprovalStatus EApprovalStatus { get; set; }
    }
}