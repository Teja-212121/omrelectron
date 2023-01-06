using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.ExamResult")]
    [BasedOnRow(typeof(ExamResultRow), CheckNames = true)]
    public class ExamResultColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        public string StudentFullName { get; set; }
        [QuickFilter]
        public long RollNumber { get; set; }
        [EditLink]
        public string SheetNumber { get; set; }
        public Guid SheetGuid { get; set; }
        [QuickFilter]
        public string ExamCode { get; set; }
        public float TotalMarks { get; set; }
        public float ObtainedMarks { get; set; }
        public float Percentage { get; set; }
        public int TotalQuestions { get; set; }
        public int TotalAttempted { get; set; }
        public int TotalNotAttempted { get; set; }
        public int TotalRightAnswers { get; set; }
        public int TotalWrongAnswers { get; set; }
        public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public short IsActive { get; set; }
        [QuickFilter]
        public Guid ScannedBatchId { get; set; }
        [Width(120), LookupEditor("Workspace.ScannedSheets")]
        [QuickFilter(CssClass = "hidden-xs"), QuickFilterOption("cascadeFrom", "ScannedBatchId")]
        public Guid ScannedSheetId { get; set; }
    }
}