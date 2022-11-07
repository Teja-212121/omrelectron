using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.ExamQuestion")]
    [BasedOnRow(typeof(ExamQuestionRow), CheckNames = true)]
    public class ExamQuestionColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public long Id { get; set; }
        [QuickFilter]
        public string ExamCode { get; set; }
        public int QuestionIndex { get; set; }
        public short RightOptions { get; set; }
        public float Score { get; set; }
        [EditLink]
        public string Tags { get; set; }
        public string RuleTypeName { get; set; }
        [QuickFilter]
        public string ExamSectionName { get; set; }
        [QuickFilter]
        [DisplayName("Date")]
        public DateTime InsertDate { get; set; }
    }
}