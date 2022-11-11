using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.ExamQuestionResult")]
    [BasedOnRow(typeof(ExamQuestionResultRow), CheckNames = true)]
    public class ExamQuestionResultForm
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
        public int QuestionIndex { get; set; }
        [HalfWidth]
        public bool IsAttempted { get; set; }
        [HalfWidth]
        public bool IsCorrect { get; set; }
        [HalfWidth]
        public float ObtainedMarks { get; set; }
       
    }
}