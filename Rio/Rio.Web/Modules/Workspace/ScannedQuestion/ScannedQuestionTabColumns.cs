using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.ScannedQuestionTab")]
    [BasedOnRow(typeof(ScannedQuestionRow), CheckNames = true)]
    public class ScannedQuestionTabColumns
    {
        [SortOrder(1, descending: false)]
        public int QuestionIndex { get; set; }
        public string CorrectedOptions { get; set; }
        
        
    }
}