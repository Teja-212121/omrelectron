using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.ExamSection")]
    [BasedOnRow(typeof(ExamSectionRow), CheckNames = true)]
    public class ExamSectionColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink, QuickFilter]
        public string Name { get; set; }
        public string Description { get; set; }
        public string ExamCode { get; set; }
        public string ParentName { get; set; }
        [QuickFilter]
        public string ExamName { get; set; }
        [QuickFilter]
        public DateTime ExamInsertDate { get; set; }
        public int TenantId { get; set; }
    }
}