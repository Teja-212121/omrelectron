using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.TheoryExamSections")]
    [BasedOnRow(typeof(TheoryExamSectionsRow), CheckNames = true)]
    public class TheoryExamSectionsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string Name { get; set; }
        public string Description { get; set; }
        public string TheoryExamCode { get; set; }
        public string ParentName { get; set; }
        public float SortOrder { get; set; }
       
    }
}