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
        public string ScannedOptions { get; set; }
        public string CorrectedOptions { get; set; }
        [QuickFilter]
        [DisplayName("Date")]
        public DateTime InsertDate { get; set; }
        [QuickFilter]
        public Guid ScannedBatchId { get; set; }
        [Width(120), LookupEditor("Workspace.ImportedScannedSheets")]
        [QuickFilter(CssClass = "hidden-xs"), QuickFilterOption("cascadeFrom", "ScannedBatchId")]
        public Guid ScannedSheetId { get; set; }

    }
}