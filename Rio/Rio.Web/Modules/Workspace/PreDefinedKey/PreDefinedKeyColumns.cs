using Rio.Web.Enums;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.PreDefinedKey")]
    [BasedOnRow(typeof(PreDefinedKeyRow), CheckNames = true)]
    public class PreDefinedKeyColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string SerialKey { get; set; }
        public PreDefinedKeyStatus EStatus { get; set; }
       
    }
}