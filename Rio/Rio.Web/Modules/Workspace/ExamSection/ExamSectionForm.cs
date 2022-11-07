using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.ExamSection")]
    [BasedOnRow(typeof(ExamSectionRow), CheckNames = true)]
    public class ExamSectionForm
    {
        [HalfWidth]
        public string Name { get; set; }
        [TextAreaEditor(Rows = 5)]
        [HalfWidth]
        public string Description { get; set; }
        [HalfWidth]
        public long ExamId { get; set; }
        [HalfWidth]
        public int ParentId { get; set; }
        
    }
}