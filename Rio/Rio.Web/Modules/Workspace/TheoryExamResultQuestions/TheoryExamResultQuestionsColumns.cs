using Rio.Web.Enums;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.TheoryExamResultQuestions")]
    [BasedOnRow(typeof(TheoryExamResultQuestionsRow), CheckNames = true)]
    public class TheoryExamResultQuestionsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public long Id { get; set; }
        [QuickFilter]
        public long TheoryExamResultId { get; set; }
        public string TheoryExamResultStudentScanId { get; set; }
        public string TheoryExamQuestionDisplayIndex { get; set; }
        public float MarksObtained { get; set; }
        public float OutOfMarks { get; set; }
        public EAttemptStatus AttemptStatus { get; set; }
        public int TenantId { get; set; }
    }
}