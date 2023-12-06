using Rio.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.GenerateSerialKeyForm")]
   // [BasedOnRow(typeof(SerialKeyRow), CheckNames = true)]
    public class GenerateSerialKeyForm
    {
        
        public int Quantity { get; set; }
        [LookupEditor("Workspace.ExamList")]
        public int ExamListId { get; set; }
        
    }
}