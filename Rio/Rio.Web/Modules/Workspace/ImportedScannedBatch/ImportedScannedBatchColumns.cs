using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.ImportedScannedBatch")]
    [BasedOnRow(typeof(ImportedScannedBatchRow), CheckNames = true)]
    public class ImportedScannedBatchColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        [QuickFilter]
        public Guid Id { get; set; }
        [EditLink,QuickFilter]
        public string Name { get; set; }
        public string Description { get; set; }

       /* public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public short IsActive { get; set; }
        public int TenantId { get; set; }*/
    }
}