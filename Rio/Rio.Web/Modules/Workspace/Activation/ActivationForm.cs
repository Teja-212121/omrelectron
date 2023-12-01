using Rio.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.Activation")]
    [BasedOnRow(typeof(ActivationRow), CheckNames = true)]
    public class ActivationForm
    {
        [HalfWidth]
        public int ExamListId { get; set; }
        [HalfWidth]
        public long TeacherId { get; set; }
        [HalfWidth]
        public string DeviceId { get; set; }
        [HalfWidth]
        public string DeviceDetails { get; set; }
        [HalfWidth]
        public DateTime ActivationDate { get; set; }
        [HalfWidth]
        public DateTime ExpiryDate { get; set; }
        [HalfWidth]
        public KeyStatus EStatus { get; set; }
      
    }
}