using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.ExamResult")]
    [BasedOnRow(typeof(ExamResultRow), CheckNames = true)]
    public class ExamResultColumns
    {
        [QuickFilter,EditLink,Width(100)]
        public string OCRData1Value { get; set; }
        [QuickFilter, EditLink, Width(90)]
        public string RollNumber { get; set; }
        [QuickFilter, EditLink, Width(80)]
        public string ExamCode { get; set; }
        [Width(130)]
        public string StudentFullName { get; set; }
        public float TotalMarks { get; set; }
        public float ObtainedMarks { get; set; }
        public int TotalQuestions { get; set; }
        public int TotalAttempted { get; set; }
        public int TotalNotAttempted { get; set; }
        public int TotalRightAnswers { get; set; }
        public int TotalWrongAnswers { get; set; }
        public float Percentage { get; set; }
        public Guid SheetGuid { get; set; }
        [DisplayName("Insert Date")]
        public DateTime InsertDate { get; set; }
        public short IsActive { get; set; }
        [QuickFilter]
        public Guid ScannedBatchId { get; set; }
        [Width(120), LookupEditor("Workspace.ScannedSheets")]
        [QuickFilter(CssClass = "hidden-xs"), QuickFilterOption("cascadeFrom", "ScannedBatchId")]
        public Guid ScannedSheetId { get; set; }
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        public string SheetNumber { get; set; }
    }
}