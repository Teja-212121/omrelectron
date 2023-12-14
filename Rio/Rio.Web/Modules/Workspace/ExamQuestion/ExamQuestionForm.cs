using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.ExamQuestion")]
    [BasedOnRow(typeof(ExamQuestionRow), CheckNames = true)]
    public class ExamQuestionForm
    {
        [HalfWidth]
        public long ExamId { get; set; }
        [HalfWidth]
        public int QuestionIndex { get; set; }
        [HalfWidth]
        public string DisplayIndex { get; set; }
        [HalfWidth]
        public string RightOption { get; set; }
        [HalfWidth]
        public string Score { get; set; }
        [HalfWidth]
        public string Tags { get; set; }
        [HalfWidth]
        public int RuleTypeId { get; set; }
        [HalfWidth]
        public int ExamSectionId { get; set; }
        
        
    }
}