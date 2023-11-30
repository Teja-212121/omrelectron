using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.ExamList")]
    [BasedOnRow(typeof(ExamListRow), CheckNames = true)]
    public class ExamListForm
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public int IsActive { get; set; }
        public int TenantId { get; set; }
    }
}