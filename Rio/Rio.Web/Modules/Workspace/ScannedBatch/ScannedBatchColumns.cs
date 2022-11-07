using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.ScannedBatch")]
    [BasedOnRow(typeof(ScannedBatchRow), CheckNames = true)]
    public class ScannedBatchColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Guid Id { get; set; }
        [EditLink]
        public string Name { get; set; }
        public string Description { get; set; }
        [QuickFilter,DisplayName("Date")]
        public DateTime InsertDate { get; set; }
       /* public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public short IsActive { get; set; }*/
        //public int TenantId { get; set; }
    }
}