using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.ActivationLog")]
    [BasedOnRow(typeof(ActivationLogRow), CheckNames = true)]
    public class ActivationLogForm
    {
        public string Code { get; set; }
        public string SerialKey { get; set; }
        public int TeacherId { get; set; }
        public int ExamListId { get; set; }
        public string DeviceId { get; set; }
        public string DeviceDetails { get; set; }
        public int EStatus { get; set; }
        public string Note { get; set; }
        public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public int IsActive { get; set; }
    }
}