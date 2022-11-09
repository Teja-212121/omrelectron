using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.ImportedScannedSheet")]
    [BasedOnRow(typeof(ImportedScannedSheetRow), CheckNames = true)]
    public class ImportedScannedSheetColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        [QuickFilter]
        public Guid Id { get; set; }
        [QuickFilter]
        public string SheetTypeName { get; set; }
        public DateTime ScannedAt { get; set; }
        [EditLink]
        public string SheetNumber { get; set; }
        public long ScannedRollNo { get; set; }
        public long ScannedExamNo { get; set; }
        public long CorrectedRollNo { get; set; }
        public long CorrectedExamNo { get; set; }
        public int ExamSetNo { get; set; }
        public string ScannedImageSourcePath { get; set; }
        public string ScannedImage { get; set; }
        public string ScannedBatchName { get; set; }
        public short ScannedStatus { get; set; }
        public string ScannedSystemErrors { get; set; }
        public string ScannedUserErrors { get; set; }
        public string ScannedComments { get; set; }
        public bool ResultProcessed { get; set; }

       /* public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public short IsActive { get; set; }
        public int TenantId { get; set; }*/
    }
}