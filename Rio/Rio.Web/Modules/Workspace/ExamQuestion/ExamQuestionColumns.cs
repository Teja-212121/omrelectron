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
        /*[Width(130), LookupEditor(typeof(ExamRow)), QuickFilter(CssClass = "hidden-xs")]*/
        public long ExamId { get; set; }
        public string ExamName { get; set; }
        public int QuestionIndex { get; set; }
        public string RightOptions { get; set; }
        public string Score { get; set; }
        [EditLink]
        public string Tags { get; set; }
        public string RuleTypeName { get; set; }
        /*[Width(120), LookupEditor("Workspace.ExamSection")]
        [QuickFilter(CssClass = "hidden-xs"), QuickFilterOption("cascadeFrom", "ExamId")]*/
        public int ExamSectionId { get; set; }
        public string ExamSectionName { get; set; }
        [QuickFilter]
        [DisplayName("Insert Date")]
        public DateTime InsertDate { get; set; }
        [DisplayName("Tenant")]
        public int TenantId { get; set; }
    }
}