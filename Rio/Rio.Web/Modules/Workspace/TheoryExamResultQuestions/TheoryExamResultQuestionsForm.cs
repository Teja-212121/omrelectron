using Rio.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.TheoryExamResultQuestions")]
    [BasedOnRow(typeof(TheoryExamResultQuestionsRow), CheckNames = true)]
    public class TheoryExamResultQuestionsForm
    {
        public long TheoryExamResultId { get; set; }
        public long TheoryExamQuestionId { get; set; }
        public float MarksObtained { get; set; }
        public float OutOfMarks { get; set; }
        public EAttemptStatus AttemptStatus { get; set; }
        public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public short IsActive { get; set; }
        public int TenantId { get; set; }
    }
}