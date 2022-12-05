using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.TheoryExams")]
    [BasedOnRow(typeof(TheoryExamsRow), CheckNames = true)]
    public class TheoryExamsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public long Id { get; set; }
        [EditLink]
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalMarks { get; set; }
        
    }
}