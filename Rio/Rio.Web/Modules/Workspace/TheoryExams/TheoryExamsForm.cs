using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.TheoryExams")]
    [BasedOnRow(typeof(TheoryExamsRow), CheckNames = true)]
    public class TheoryExamsForm
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalMarks { get; set; }
       
    }
}