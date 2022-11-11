using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.ExamSectionResult")]
    [BasedOnRow(typeof(ExamSectionResultRow), CheckNames = true)]
    public class ExamSectionResultColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        public string StudentFirstName { get; set; }
        public long RollNumber { get; set; }
        [EditLink]
        public string SheetNumber { get; set; }
        public Guid SheetGuid { get; set; }
        public string ExamCode { get; set; }
        public string ExamSectionName { get; set; }
        public float TotalMarks { get; set; }
        public float ObtainedMarks { get; set; }
        public float Percentage { get; set; }
        public int TotalQuestions { get; set; }
        public int TotalAttempted { get; set; }
        public int TotalNotAttempted { get; set; }
        public int TotalRightAnswers { get; set; }
        public int TotalWrongAnswers { get; set; }
        
    }
}