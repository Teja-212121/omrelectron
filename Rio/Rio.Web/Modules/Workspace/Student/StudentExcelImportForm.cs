using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Rio.StudentExcelImportForm")]
    public class StudentExcelImportForm
    {
        /*[ChangingLookupTextEditorForExam]
        public int ExamId { get; set; }*/
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}