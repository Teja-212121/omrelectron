using Rio.Web.Enums;
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
        public float MarksScored { get; set; }
        public float OutOfMarks { get; set; }
        public EResultSyncStatus ResultStatus { get; set; }
        public string RollNumber { get; set; }
        public string SheetImage { get; set; }
        public long StudentId { get; set; }
        public DateTime AttemptDate { get; set; }
       
    }
}