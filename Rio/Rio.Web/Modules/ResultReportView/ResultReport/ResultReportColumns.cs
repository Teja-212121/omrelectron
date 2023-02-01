using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.ResultReportView.Columns
{
    [ColumnsScript("ResultReportView.ResultReport")]
    [BasedOnRow(typeof(ResultReportRow), CheckNames = true)]
    public class ResultReportColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        public Guid ScannedSheetId { get; set; }
        public long RollNumber { get; set; }
        public int ExamId { get; set; }
        [EditLink]
        public string ExamCode { get; set; }
        public int QuestionIndex { get; set; }
        public int IsAttempted { get; set; }
        public int IsCorrect { get; set; }
        public int RightOptions { get; set; }
        public int CorrectedOptions { get; set; }
        public decimal Score { get; set; }
        public decimal ObtainedMarks { get; set; }
    }
}