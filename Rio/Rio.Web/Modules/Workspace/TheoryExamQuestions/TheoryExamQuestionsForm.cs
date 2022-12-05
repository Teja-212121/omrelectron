using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.TheoryExamQuestions")]
    [BasedOnRow(typeof(TheoryExamQuestionsRow), CheckNames = true)]
    public class TheoryExamQuestionsForm
    {
        public long TheoryExamId { get; set; }
        public int QuestionIndex { get; set; }
        public float MaxMarks { get; set; }
        public string DisplayIndex { get; set; }
        public string Tags { get; set; }
        public int TheoryExamSectionId { get; set; }
       
    }
}