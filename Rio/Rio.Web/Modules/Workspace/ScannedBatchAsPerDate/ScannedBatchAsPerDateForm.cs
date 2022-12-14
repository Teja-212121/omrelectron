using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.ScannedBatchAsPerDate")]
    [BasedOnRow(typeof(ScannedBatchAsPerDateRow), CheckNames = true)]
    public class ScannedBatchAsPerDateForm
    {
        public string Name { get; set; }
        public Guid ScanBatchid { get; set; }
        public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public short IsActive { get; set; }
        public int TenantId { get; set; }
    }
}