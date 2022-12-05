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
        public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public short IsActive { get; set; }
        public int TenantId { get; set; }
    }
}