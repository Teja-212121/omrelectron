using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.ExamQuestionResult")]
    [BasedOnRow(typeof(ExamQuestionResultRow), CheckNames = true)]
    public class ExamQuestionResultColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public long Id { get; set; }
        public string StudentFirstName { get; set; }
        [QuickFilter]
        public string RollNumber { get; set; }
        [EditLink]
        public string SheetNumber { get; set; }
        public Guid SheetGuid { get; set; }
        [QuickFilter]
        public string ExamCode { get; set; }
        public int QuestionIndex { get; set; }
        public bool IsAttempted { get; set; }
        public bool IsCorrect { get; set; }
        public float ObtainedMarks { get; set; }
        [QuickFilter]
        public Guid ScannedBatchId { get; set; }
        [Width(120), LookupEditor("Workspace.ScannedSheets")]
        [QuickFilter(CssClass = "hidden-xs"), QuickFilterOption("cascadeFrom", "ScannedBatchId")]
        public Guid ScannedSheetId { get; set; }
    }
}