using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.TheoryExamResults")]
    [BasedOnRow(typeof(TheoryExamResultsRow), CheckNames = true)]
    public class TheoryExamResultsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public long Id { get; set; }
        public string TheoryExamCode { get; set; }
        [EditLink]
        public string StudentScanId { get; set; }
        public string TheoryExamQuestionDisplayIndex { get; set; }
        public float MarksObtained { get; set; }
        public short AttemptStatus { get; set; }
        public string RollNumber { get; set; }
        public string StudentFirstName { get; set; }
      
    }
}