using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.ImportedScannedQuestion")]
    [BasedOnRow(typeof(ImportedScannedQuestionRow), CheckNames = true)]
    public class ImportedScannedQuestionColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        [QuickFilter]
        public long Id { get; set; }
        public string ScannedSheetSheetNumber { get; set; }
        public int QuestionIndex { get; set; }
        public long ScannedOptions { get; set; }
        public long CorrectedOptions { get; set; }
       
    }
}