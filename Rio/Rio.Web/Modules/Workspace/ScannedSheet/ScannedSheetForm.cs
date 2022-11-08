using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.ScannedSheet")]
    [BasedOnRow(typeof(ScannedSheetRow), CheckNames = true)]
    public class ScannedSheetForm
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
        [TextAreaEditor(Rows =3)]
        public string ScannedImageSourcePath { get; set; }
        
        public string ScannedImage { get; set; }
        [HalfWidth]
        public Guid ScannedBatchId { get; set; }
        [HalfWidth]
        public EScannedStatus ScannedStatus { get; set; }
        [TextAreaEditor(Rows = 3)]
        public string ScannedSystemErrors { get; set; }
        [TextAreaEditor(Rows = 3)]
        public string ScannedUserErrors { get; set; }
        [TextAreaEditor(Rows = 3)]
        public string ScannedComments { get; set; }
        [HalfWidth]
        public bool ResultProcessed { get; set; }
       // public int TenantId { get; set; }
    }
}