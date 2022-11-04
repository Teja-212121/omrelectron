using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.Group")]
    [BasedOnRow(typeof(GroupRow), CheckNames = true)]
    public class GroupForm
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ParentId { get; set; }
        public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public short IsActive { get; set; }
        public int TenantId { get; set; }
    }
}