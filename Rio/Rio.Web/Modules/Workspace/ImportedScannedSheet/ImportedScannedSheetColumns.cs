using Rio.Workspace.enums;
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
        public Guid Id { get; set; }
        [QuickFilter]
        [DisplayName("Date")]
        public DateTime ScannedBatchInsertDate { get; set; }
        [QuickFilter]
        public string CorrectedExamNo { get; set; }
        [QuickFilter]
        public string SheetTypeName { get; set; }
        public DateTime ScannedAt { get; set; }
        [EditLink]
        public string SheetNumber { get; set; }
        [QuickFilter]
        public string ScannedRollNo { get; set; }
        public string ScannedExamNo { get; set; }
        public string CorrectedRollNo { get; set; }
        
        public string ExamSetNo { get; set; }
        public string ScannedImageSourcePath { get; set; }
        public string ScannedImage { get; set; }
        public string ScannedBatchName { get; set; }
        [QuickFilter]
        public EScannedStatus ScannedStatus { get; set; }
        public string ScannedSystemErrors { get; set; }
        public string ScannedUserErrors { get; set; }
        public string ScannedComments { get; set; }
        public bool ResultProcessed { get; set; }
        
        [QuickFilter]
        public Guid ScannedBatchId { get; set; }
        public int TenantId { get; set; }
        public string OCRData1Key { get; set; }
        public string OCRData1Value { get; set; }
        public string OCRData2Key { get; set; }
        public string OCRData2Value { get; set; }
        public string OCRData3Key { get; set; }
        public string OCRData3Value { get; set; }
        public string ICRData1Key { get; set; }
        public string ICRData1Value { get; set; }
        public string ICRData2Key { get; set; }
        public string ICRData2Value { get; set; }
        public string ICRData3Key { get; set; }
        public string ICRData3Value { get; set; }
    }
}