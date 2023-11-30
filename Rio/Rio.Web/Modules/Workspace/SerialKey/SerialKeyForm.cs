using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.SerialKey")]
    [BasedOnRow(typeof(SerialKeyRow), CheckNames = true)]
    public class SerialKeyForm
    {
        [HalfWidth]
        public string SerialKey { get; set; }
        [HalfWidth]
        public int ExamListId { get; set; }
        [HalfWidth]
        public int ValidityType { get; set; }
        [HalfWidth]
        public int ValidityInDays { get; set; }
        [HalfWidth]
        public DateTime ValidDate { get; set; }
        [TextAreaEditor(Rows =3)]
        public string Note { get; set; }
        [HalfWidth]
        public int EStatus { get; set; }
        
    }
}