using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.Activation")]
    [BasedOnRow(typeof(ActivationRow), CheckNames = true)]
    public class ActivationForm
    {
        public int ExamListId { get; set; }
        public int TeacherId { get; set; }
        public string DeviceId { get; set; }
        public string DeviceDetails { get; set; }
        public DateTime ActivationDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int EStatus { get; set; }
        public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public int IsActive { get; set; }
    }
}