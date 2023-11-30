using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.SerialKey")]
    [BasedOnRow(typeof(SerialKeyRow), CheckNames = true)]
    public class SerialKeyForm
    {
        public string SerialKey { get; set; }
        public int ExamListId { get; set; }
        public int ValidityType { get; set; }
        public int ValidityInDays { get; set; }
        public DateTime ValidDate { get; set; }
        public string Note { get; set; }
        public int EStatus { get; set; }
        public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public int IsActive { get; set; }
    }
}