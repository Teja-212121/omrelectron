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
        public string SheetTypeName { get; set; }
        public DateTime ScannedAt { get; set; }
        [EditLink,QuickFilter]
        public string SheetNumber { get; set; }
        public long ScannedRollNo { get; set; }
        [QuickFilter]
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
        [QuickFilter]
        [DisplayName("Date")]
        public DateTime InsertDate { get; set; }
        public int TenantId { get; set; }
    }
}