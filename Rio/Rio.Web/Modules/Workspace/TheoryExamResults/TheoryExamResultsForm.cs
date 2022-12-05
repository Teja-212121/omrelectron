using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.TheoryExamResults")]
    [BasedOnRow(typeof(TheoryExamResultsRow), CheckNames = true)]
    public class TheoryExamResultsForm
    {
        public long TheoryExamId { get; set; }
        public string StudentScanId { get; set; }
        public long TheoryExamQuestionId { get; set; }
        public float MarksObtained { get; set; }
        public short AttemptStatus { get; set; }
        public string RollNumber { get; set; }
        public long StudentId { get; set; }
    }
}