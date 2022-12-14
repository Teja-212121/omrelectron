using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.ImportedScannedQuestionTab")]
    [BasedOnRow(typeof(ImportedScannedQuestionRow), CheckNames = true)]
    public class ImportedScannedQuestionTabColumns
    {
        public int QuestionIndex { get; set; }
        public string CorrectedOptions { get; set; }
        
        
    }
}