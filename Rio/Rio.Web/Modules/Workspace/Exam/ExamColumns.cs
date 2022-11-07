using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.Exam")]
    [BasedOnRow(typeof(ExamRow), CheckNames = true)]
    public class ExamColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public long Id { get; set; }
        [EditLink]
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalMarks { get; set; }
        public float NegativeMarks { get; set; }
        public short OptionsAvailable { get; set; }
        public string ResultCriteria { get; set; }
        
        public int TenantId { get; set; }
    }
}