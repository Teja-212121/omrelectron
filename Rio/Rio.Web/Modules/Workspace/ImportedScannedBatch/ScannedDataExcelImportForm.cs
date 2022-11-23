using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Rio.ScannedDataExcelImportForm")]
    public class ScannedDataExcelImportForm
    {
        /*[ChangingLookupTextEditorForExam]
        public int ExamId { get; set; }*/
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}