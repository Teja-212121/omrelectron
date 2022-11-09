using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.ImportedScannedSheet")]
    [BasedOnRow(typeof(ImportedScannedSheetRow), CheckNames = true)]
    public class ImportedScannedSheetForm
    {
        [HalfWidth]
        public int SheetTypeId { get; set; }
        [HalfWidth]
        public DateTime ScannedAt { get; set; }
        [HalfWidth]
        public string SheetNumber { get; set; }

        [HalfWidth]
        public long ScannedRollNo { get; set; }
        [HalfWidth]
        public long ScannedExamNo { get; set; }
        [HalfWidth]
        public long CorrectedRollNo { get; set; }
        [HalfWidth]
        public long CorrectedExamNo { get; set; }
        [HalfWidth]
        public int ExamSetNo { get; set; }
        [TextAreaEditor(Rows = 3)]
        public string ScannedImageSourcePath { get; set; }
        [HalfWidth]
        public string ScannedImage { get; set; }
        [HalfWidth]
        public Guid ScannedBatchId { get; set; }
        [HalfWidth]
        public short ScannedStatus { get; set; }
        [TextAreaEditor(Rows = 3)]
        public string ScannedSystemErrors { get; set; }
        [TextAreaEditor(Rows = 3)]
        public string ScannedUserErrors { get; set; }
        [TextAreaEditor(Rows = 3)]
        public string ScannedComments { get; set; }
        [HalfWidth]
        public bool ResultProcessed { get; set; }
       /* public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public short IsActive { get; set; }
        public int TenantId { get; set; }*/
    }
}