using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.TheoryExamQuestions")]
    [BasedOnRow(typeof(TheoryExamQuestionsRow), CheckNames = true)]
    public class TheoryExamQuestionsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public long Id { get; set; }
        public string TheoryExamCode { get; set; }
        public int QuestionIndex { get; set; }
        public float MaxMarks { get; set; }
        [EditLink]
        public string DisplayIndex { get; set; }
        public string Tags { get; set; }
        public string TheoryExamSectionName { get; set; }
        public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public short IsActive { get; set; }
        public int TenantId { get; set; }
    }
}