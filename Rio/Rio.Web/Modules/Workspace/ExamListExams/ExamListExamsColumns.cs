using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.ExamListExams")]
    [BasedOnRow(typeof(ExamListExamsRow), CheckNames = true)]
    public class ExamListExamsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        public string ExamListName { get; set; }
        public string ExamCode { get; set; }
        public string TenantTenantName { get; set; }
        public int Priority { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ModelAnswerPaperStartDate { get; set; }
       
    }
}