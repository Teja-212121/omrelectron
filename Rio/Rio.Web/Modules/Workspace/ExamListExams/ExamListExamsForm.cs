using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.ExamListExams")]
    [BasedOnRow(typeof(ExamListExamsRow), CheckNames = true)]
    public class ExamListExamsForm
    {
        public int ExamListId { get; set; }
        public int ExamId { get; set; }
        public int TenantId { get; set; }
        public int Priority { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ModelAnswerPaperStartDate { get; set; }
        public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public int IsActive { get; set; }
    }
}