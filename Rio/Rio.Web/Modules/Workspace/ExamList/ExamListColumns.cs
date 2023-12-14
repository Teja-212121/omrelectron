using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.ExamList")]
    [BasedOnRow(typeof(ExamListRow), CheckNames = true)]
    public class ExamListColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string Name { get; set; }
        public string Description { get; set; }      
        public int IsActive { get; set; }
        [QuickFilter, FilterOnly]
        public int TenantId { get; set; }
        public string TenantTenantName { get; set; }
    }
}