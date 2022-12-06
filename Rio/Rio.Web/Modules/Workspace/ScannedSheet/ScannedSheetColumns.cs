using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.ScannedSheet")]
    [BasedOnRow(typeof(ScannedSheetRow), CheckNames = true)]
    public class ScannedSheetColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Guid Id { get; set; }
        [QuickFilter]
        /*[ChangingLookupTextEditor]*/
        public string SheetTypeName { get; set; }
        public DateTime ScannedAt { get; set; }
        [EditLink]
        public string SheetNumber { get; set; }
        [QuickFilter]
        public long ScannedRollNo { get; set; }
        public long ScannedExamNo { get; set; }
        public long CorrectedRollNo { get; set; }
        public long CorrectedExamNo { get; set; }
        public int ExamSetNo { get; set; }
        public string ScannedImageSourcePath { get; set; }
        public string ScannedImage { get; set; }
        public short ScannedStatus { get; set; }
        public string ScannedSystemErrors { get; set; }
        public string ScannedUserErrors { get; set; }
        public string ScannedComments { get; set; }
        public bool ResultProcessed { get; set; }
        [QuickFilter]
        [DisplayName("Date")]
        public DateTime ScannedBatchInsertDate { get; set; }
        [QuickFilter]
        public Guid ScannedBatchId { get; set; }
        public string ScannedBatchName { get; set; }
        /*[QuickFilter]
        public Guid CascadeScannedBatchId { get; set; }*/
        public int TenantId { get; set; }
    }
}