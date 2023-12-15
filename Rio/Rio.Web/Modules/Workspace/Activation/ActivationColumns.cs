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
        public string ExamListName { get; set; }
        public string TeacherFirstName { get; set; }
        [EditLink]
        public string DeviceId { get; set; }
        public string DeviceDetails { get; set; }
        [QuickFilter]
        public DateTime ActivationDate { get; set; }
        [QuickFilter]
        public DateTime ExpiryDate { get; set; }
        [QuickFilter]
        public KeyStatus EStatus { get; set; }
        public int? SerialKeyId { get; set; }

    }
}