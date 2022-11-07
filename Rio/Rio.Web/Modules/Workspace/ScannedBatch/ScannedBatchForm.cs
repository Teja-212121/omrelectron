using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.ScannedBatch")]
    [BasedOnRow(typeof(ScannedBatchRow), CheckNames = true)]
    public class ScannedBatchForm
    {
        [HalfWidth]
        public Guid Id { get; set; }
        [HalfWidth]
        public string Name { get; set; }
        [TextAreaEditor(Rows =5)]
        public string Description { get; set; }
/*        public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public short IsActive { get; set; }*/
       // public int TenantId { get; set; }
    }
}