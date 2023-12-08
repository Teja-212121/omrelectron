using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.PredfinedSerialKeyExcelImportForm")]
    public class PredfinedSerialKeyExcelImportForm
    {
      
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}