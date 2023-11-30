using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.PreDefinedKey")]
    [BasedOnRow(typeof(PreDefinedKeyRow), CheckNames = true)]
    public class PreDefinedKeyForm
    {
        
        public string SerialKey { get; set; }
        public int EStatus { get; set; }
        
    }
}