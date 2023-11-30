using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.ExamListExams")]
    [BasedOnRow(typeof(ExamListExamsRow), CheckNames = true)]
    public class ExamListExamsForm
    {
        [HalfWidth]
        public int ExamListId { get; set; }
        [HalfWidth]
        public int ExamId { get; set; }
        [HalfWidth]
        public int TenantId { get; set; }
        [HalfWidth]
        public int Priority { get; set; }
        [HalfWidth]
        public DateTime StartDate { get; set; }
        [HalfWidth]
        public DateTime EndDate { get; set; }
        [HalfWidth]
        public DateTime ModelAnswerPaperStartDate { get; set; }
      
    }
}