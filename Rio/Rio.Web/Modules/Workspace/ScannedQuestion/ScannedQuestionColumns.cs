using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.ScannedQuestion")]
    [BasedOnRow(typeof(ScannedQuestionRow), CheckNames = true)]
    public class ScannedQuestionColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        [QuickFilter]
        public long Id { get; set; }
        [QuickFilter]
        public Guid ScannedSheetId { get; set; }
        public string ScannedSheetSheetNumber { get; set; }
        public int QuestionIndex { get; set; }
        public long ScannedOptions { get; set; }
        public long CorrectedOptions { get; set; }


       /* public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public short IsActive { get; set; }
        public int TenantId { get; set; }*/
    }
}