using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.ExamRankWiseResult")]
    [BasedOnRow(typeof(ExamRankWiseResultRow), CheckNames = true)]
    public class ExamRankWiseResultColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public long Id { get; set; }
        public string StudentFirstName { get; set; }
        public long RollNumber { get; set; }
        [EditLink]
        public string SheetNumber { get; set; }
        public Guid SheetGuid { get; set; }
        public string ExamCode { get; set; }
        public int Rank { get; set; }
        
    }
}