using Rio.Web.Enums;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.Activation")]
    [BasedOnRow(typeof(ActivationRow), CheckNames = true)]
    public class ActivationColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string ExamListName { get; set; }
        public string TeacherFullName { get; set; }
        
        public string TeacherEmail { get; set; }
        public string TeacherMobile { get; set; }
        [QuickFilter]
        public DateTime ActivationDate { get; set; }
        [QuickFilter]
        public DateTime ExpiryDate { get; set; }
        [QuickFilter]
        public KeyStatus EStatus { get; set; }
        public int? SerialKeyId { get; set; }
        public int TenantId { get; set; }
        public string TenantTenantName { get; set; }
    }
}