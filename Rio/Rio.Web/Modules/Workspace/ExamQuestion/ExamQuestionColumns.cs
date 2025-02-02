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
        [Width(100)]
        public string ExamCode { get; set; }
        [Width(100)]
        public string ExamName { get; set; }
        public int QuestionIndex { get; set; }
        [Width(180)]
        public string RightOption { get; set; }
        [Width(180)]
        public string Score { get; set; }
        public string RuleTypeName { get; set; }
        [Hidden]
        public int ExamId { get; set; }
        [Width(180), LookupEditor("Workspace.ExamSection")]
        [QuickFilter]
        public int ExamSectionId { get; set; }
/*        [QuickFilter]
        [DisplayName("Insert Date")]
        public DateTime InsertDate { get; set; }*/
        [DisplayName("Tenant")]
        public int TenantName { get; set; }
        public string Tags { get; set; }
    }
}