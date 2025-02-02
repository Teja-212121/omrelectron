using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.ScannedQuestion")]
    [BasedOnRow(typeof(ScannedQuestionRow), CheckNames = true)]
    public class ScannedQuestionColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public long Id { get; set; }
        public string ScannedSheetSheetNumber { get; set; }
        public string ScannedSheetOCRData1Value { get; set; }
        public string ScannedSheetCorrectedRollNo { get; set; }
        public string ScannedSheetCorrectedExamNo { get; set; }
        public int QuestionIndex { get; set; }
        public string ScannedOptions { get; set; }
        public string CorrectedOptions { get; set; }
        [QuickFilter]
        [DisplayName("Date")]
        public DateTime InsertDate { get; set; }
        [QuickFilter]
        public Guid ScannedBatchId { get; set; }
        [Width(120), LookupEditor("Workspace.ScannedSheets")]
        [QuickFilter(CssClass = "hidden-xs"), QuickFilterOption("cascadeFrom", "ScannedBatchId")]
        public Guid ScannedSheetId { get; set; }
        
    }
}