using Rio.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.ActivationLog")]
    [BasedOnRow(typeof(ActivationLogRow), CheckNames = true)]
    public class ActivationLogForm
    {
        [HalfWidth]
        public string Code { get; set; }
        [HalfWidth]
        public string SerialKey { get; set; }
        [HalfWidth]
        public int TeacherId { get; set; }
        [HalfWidth]
        public int ExamListId { get; set; }
        [HalfWidth]
        public string DeviceId { get; set; }
        [HalfWidth]
        public string DeviceDetails { get; set; }
        [HalfWidth]
        public KeyStatus EStatus { get; set; }
        [TextAreaEditor(Rows =3)]
        public string Note { get; set; }
        
    }
}