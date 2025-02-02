using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.TheoryExamSections")]
    [BasedOnRow(typeof(TheoryExamSectionsRow), CheckNames = true)]
    public class TheoryExamSectionsForm
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long TheoryExamId { get; set; }
        public int ParentId { get; set; }
        public float SortOrder { get; set; }
       
    }
}