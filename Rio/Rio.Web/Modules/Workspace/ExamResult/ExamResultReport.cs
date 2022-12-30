using Rio.Workspace;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Reporting;
using System.Collections.Generic;

namespace Rio.Web.Modules.Workspace.ExamResult
{
    [Report("Workspace.ExamResult")]
    [ReportDesign("ExamResultReport")]
    [RequiredPermission(PermissionKeys.General)]
    public class ExamResultReport : IReport
    {
        public int ExamId { get; set; }

        protected IUnitOfWork Uow { get; }

        public object GetData()
        {
            var data = new ExamResultReportData();

            var o = ExamResultRow.Fields;

            data.Exam = Uow.Connection.TryById<ExamRow>(ExamId, q => q
                 .SelectTableFields()
                 .Select(o.StudentFullName)
                 .Select(o.ExamId)) ?? new ExamRow();

            var eq = ExamQuestionRow.Fields;
            data.Details = Uow.Connection.List<ExamQuestionResultRow>(q => q
                .SelectTableFields()
                .Select(eq.QuestionIndex)
                .Select(eq.ExamTotalMarks)
                .Where(eq.ExamId == ExamId));

            data.ExamQuestion = Uow.Connection.TryFirst<ExamQuestionRow>(eq.ExamName == data.Exam.Name)
                ?? new ExamQuestionRow();

            return data;
        }
    }
    public class ExamResultReportData
    {
        public ExamRow Exam { get; set; }
        public List<ExamQuestionResultRow> Details { get; set; }
        public ExamQuestionRow ExamQuestion { get; set; }
        public ExamResultRow ExamResult { get; set; }
    }

}