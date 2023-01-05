
using Rio.ResultReportView;
using Rio.Workspace;
using System.Collections.Generic;

namespace Rio.Web.Modules.Workspace.CommonController.Models
{
    public class ExamResultReportModel
    {
        public StudentRow Student { get; set; }
        public ExamRow Exam { get; set; }
        public List<ResultReportRow> Details { get; set; }
        public ScannedQuestionRow ScannedQuestion { get; set; }
        public ExamQuestionRow ExamQuestion { get; set; }
        public ExamResultRow ExamResult { get; set; }
    }
}
