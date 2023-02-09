using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.ExamGroupWiseResult")]
    [BasedOnRow(typeof(ExamGroupWiseResultRow), CheckNames = true)]
    public class ExamGroupWiseResultColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public long Id { get; set; }
        public string StudentFirstName { get; set; }
        public string RollNumber { get; set; }
        [EditLink]
        public string SheetNumber { get; set; }
        public Guid SheetGuid { get; set; }
        public string ExamCode { get; set; }
        public int Rank { get; set; }
        public string GroupName { get; set; }
       
    }
}