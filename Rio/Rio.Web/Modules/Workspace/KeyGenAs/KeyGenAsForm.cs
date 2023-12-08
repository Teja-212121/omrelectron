using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.KeyGenAs")]
    [BasedOnRow(typeof(KeyGenAsRow), CheckNames = true)]
    public class KeyGenAsForm
    {
        public int Quantity { get; set; }
        public int ExamListId { get; set; }
        public int ValidityType { get; set; }
        public int ValidityInDays { get; set; }
        public DateTime ValidDate { get; set; }
        public string Note { get; set; }
        //public int EStatus { get; set; }
       
    }
}