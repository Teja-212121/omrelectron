using Microsoft.AspNetCore.Mvc;
using Rio.Web.Modules.Workspace.CommonController.Models;
using Rio.Workspace;
using Rio.Workspace.Endpoints;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using System;
using System.Collections.Generic;

namespace Rio.Web.Modules.Workspace.ExamResult
{
    [Report("Workspace.ExamResult")]
    [ReportDesign("ExamResultReport")]
    [RequiredPermission(PermissionKeys.General)]
    public class ExamResultReportController : Controller, ICustomizeHtmlToPdf
    {
        public IActionResult Index()
        {
            return View();
        }
        public int StudentId { get; set; }
        public int ScannedQuestionId { get; set; }

        [Route("~/ExamResult/ExamResultReport")]
        public IActionResult GetData(int ExamId,
            [FromServices] ISqlConnections SqlConnections,
            [FromServices] IExamQuestionResultListHandler handler)
        {
            using (var connection = SqlConnections.NewByKey("Default"))
            {
                var model = new ExamResultReportModel();
                try
                {

                    ListRequest request2 = new ListRequest();
                    request2.ColumnSelection = ColumnSelection.Details;
                    request2.EqualityFilter = new Dictionary<string, object>();
                    //request2.Sort =new SortBy[]();
                    request2.EqualityFilter.Add("ExamId", ExamId);
                    ExamQuestionResultController endpoint = new ExamQuestionResultController();
                    var data = endpoint.List(connection, request2, handler);
                    model.Details = new List<ExamQuestionResultRow>();
                    model.Details = data.Entities;

                    var o = ExamResultRow.Fields;
                    model.ExamResult = connection.TryFirst<ExamResultRow>(q=> q.Select(o.ExamCode).Select(o.ExamName).Select(o.TotalMarks).Select(o.TotalQuestions).Select(o.TotalQuestions).Select(o.TotalAttempted).Select(o.TotalNotAttempted).Select(o.TotalRightAnswers).Select(o.TotalWrongAnswers)
                    .Where(o.ExamId == ExamId));

                    var eqr = ExamQuestionResultRow.Fields;
                    model.Details = connection.List<ExamQuestionResultRow>(q => q.Select(eqr.QuestionIndex).Select(eqr.ObtainedMarks).Select(eqr.IsAttempted).Select(eqr.IsCorrect).Where(eqr.ExamId == ExamId));

                    /*model.ExamResult = connection.TryFirst<ExamResultRow>(q => q.SelectTableFields().Select(o.ObtainedMarks).Select(o.TotalQuestions).Select(o.TotalAttempted).Select(o.TotalNotAttempted).Select(o.TotalRightAnswers).Select(o.TotalWrongAnswers).Where(o.ExamId == ExamId));

                     var st = StudentRow.Fields;
                     model.Student = connection.TryById<StudentRow>(StudentId, q => q
                      .SelectTableFields()
                      .Select(st.FullName)
                      .Select(st.RollNo)
                      .Select(st.Id)) ?? new StudentRow();

                     var ex = ExamRow.Fields;
                     model.Exam = connection.TryById<ExamRow>(ExamId, q => q
                      .SelectTableFields()
                      .Select(ex.Code)
                      .Select(ex.Name)
                      .Select(ex.Id)) ?? new ExamRow();

                     var eqr = ExamQuestionResultRow.Fields;
                     model.Details = connection.List<ExamQuestionResultRow>(q => q
                         .SelectTableFields()
                         .Select(eqr.QuestionIndex)
                         .Select(eqr.ObtainedMarks)
                         .Where(eqr.ExamId == ExamId));

                     var sq = ScannedQuestionRow.Fields;
                     model.ScannedQuestion = connection.TryById<ScannedQuestionRow>(ScannedQuestionId, q => q
                         .SelectTableFields()
                         .Select(sq.QuestionIndex)
                         .Select(sq.CorrectedOptions)) ?? new ScannedQuestionRow();

                     var eq = ExamQuestionRow.Fields;
                     model.ExamQuestion = connection.TryFirst<ExamQuestionRow>(q => q.SelectTableFields()
                         .Select(eq.QuestionIndex)
                         .Select(eq.RightOptions))
                     ?? new ExamQuestionRow();*/
                }
                catch (Exception ex)
                {
                    return new ContentResult
                    {
                        Content = ex.Message
                    };
                }

                return View(MVC.Views.ExamResult.ExamResultReport,model as ExamResultReportModel);
            }
        }
        public void Customize(IHtmlToPdfOptions options)
        {
            // you may customize HTML to PDF converter (WKHTML) parameters here, e.g. 
            // options.MarginsAll = "2cm";
        }
    }
}