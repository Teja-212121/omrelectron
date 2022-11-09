using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.ExamResult")]
    [BasedOnRow(typeof(ExamResultRow), CheckNames = true)]
    public class ExamResultForm
    {
        [HalfWidth]
        public long StudentId { get; set; }
        [HalfWidth]
        public long RollNumber { get; set; }
        [HalfWidth]
        public string SheetNumber { get; set; }
        [HalfWidth]
        public Guid SheetGuid { get; set; }
        [HalfWidth]
        public long ExamId { get; set; }
        [HalfWidth]
        public float TotalMarks { get; set; }
        [HalfWidth]
        public float ObtainedMarks { get; set; }
        [HalfWidth]
        public float Percentage { get; set; }
        [HalfWidth]
        public int TotalQuestions { get; set; }
        [HalfWidth]
        public int TotalAttempted { get; set; }
        [HalfWidth]
        public int TotalNotAttempted { get; set; }
        [HalfWidth]
        public int TotalRightAnswers { get; set; }
        [HalfWidth]
        public int TotalWrongAnswers { get; set; }
        
    }
}