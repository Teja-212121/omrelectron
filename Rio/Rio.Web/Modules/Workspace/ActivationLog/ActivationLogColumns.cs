using Rio.Web.Enums;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.ActivationLog")]
    [BasedOnRow(typeof(ActivationLogRow), CheckNames = true)]
    public class ActivationLogColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string Code { get; set; }
        public string SerialKey { get; set; }
        public string TeacherFirstName { get; set; }
        public string ExamListName { get; set; }
        public string DeviceId { get; set; }
        public string DeviceDetails { get; set; }
        public KeyStatus EStatus { get; set; }
        public string Note { get; set; }
        public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public int IsActive { get; set; }
    }
}