using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.Group")]
    [BasedOnRow(typeof(GroupRow), CheckNames = true)]
    public class GroupColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink, QuickFilter]
        public string Name { get; set; }
        public string Description { get; set; }
        public string ParentName { get; set; }
        [QuickFilter]
        [DisplayName("Insert Date")]
        public DateTime InsertDate { get; set; }
        [QuickFilter]
        [DisplayName("Tenant")]
        public int TenantId { get; set; }
    }
}