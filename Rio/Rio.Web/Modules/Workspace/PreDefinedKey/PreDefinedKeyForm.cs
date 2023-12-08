using Rio.Web.Enums;
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
        public PreDefinedKeyStatus EStatus { get; set; }
        
    }
}