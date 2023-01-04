using Rio.Workspace.enums;
using Serenity.ComponentModel;
using Serenity.Web;
using System;
using System.ComponentModel;

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
        public string ScannedRollNo { get; set; }
        [HalfWidth]
        public string ScannedExamNo { get; set; }
        [HalfWidth]
        public string CorrectedRollNo { get; set; }
        [HalfWidth]
        public string CorrectedExamNo { get; set; }
        [HalfWidth]
        public bool IsRectified { get; set; }
        [HalfWidth]
        public string ExamSetNo { get; set; }
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
        [ReadOnly(true)]
        public string ImageBase64 { get; set; }
        [HalfWidth]
        public bool ResultProcessed { get; set; }
        [HalfWidth]
        public string OCRData1Key { get; set; }
        [HalfWidth]
        public string OCRData1Value { get; set; }
        [HalfWidth]
        public string OCRData2Key { get; set; }
        [HalfWidth]
        public string OCRData2Value { get; set; }
        [HalfWidth]
        public string OCRData3Key { get; set; }
        [HalfWidth]
        public string OCRData3Value { get; set; }
        [HalfWidth]
        public string ICRData1Key { get; set; }
        [HalfWidth]
        public string ICRData1Value { get; set; }
        [HalfWidth]
        public string ICRData2Key { get; set; }
        [HalfWidth]
        public string ICRData2Value { get; set; }
        [HalfWidth]
        public string ICRData3Key { get; set; }
        [HalfWidth]
        public string ICRData3Value { get; set; }
    }
}