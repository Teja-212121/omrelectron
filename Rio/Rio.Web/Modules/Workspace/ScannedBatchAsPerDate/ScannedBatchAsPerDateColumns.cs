using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.ScannedBatchAsPerDate")]
    [BasedOnRow(typeof(ScannedBatchAsPerDateRow), CheckNames = true)]
    public class ScannedBatchAsPerDateColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Guid Id { get; set; }
        [EditLink]
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