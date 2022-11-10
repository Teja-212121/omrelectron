using Serenity.ComponentModel;
using Serenity.Web;
using System;
using System.ComponentModel;
//using Serenity.Demo.BasicSamples;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.ExamQuestionImportForm")]
    public class ExamQuestionImportForm
    {
        /*[DisplayName("Exam")]
        [LookupEditor("Workspace.Exam")]
        //[ChangingLookupTextEditorForExam]
        public int ExamId { get; set; }*/

        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}