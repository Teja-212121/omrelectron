using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.ImportedScannedQuestion")]
    [BasedOnRow(typeof(ImportedScannedQuestionRow), CheckNames = true)]
    public class ImportedScannedQuestionForm
    {
        [HalfWidth]
        public Guid ScannedSheetId { get; set; }
        [HalfWidth]
        public int QuestionIndex { get; set; }
        [HalfWidth]
        public long ScannedOptions { get; set; }
        [HalfWidth]
        public long CorrectedOptions { get; set; }
       
    }
}