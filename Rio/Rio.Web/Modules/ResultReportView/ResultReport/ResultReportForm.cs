using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.ResultReportView.Forms
{
    [FormScript("ResultReportView.ResultReport")]
    [BasedOnRow(typeof(ResultReportRow), CheckNames = true)]
    public class ResultReportForm
    {
        public Guid ScannedSheetId { get; set; }
        public string RollNumber { get; set; }
        public int ExamId { get; set; }
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