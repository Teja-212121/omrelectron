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
        public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public int IsActive { get; set; }
    }
}