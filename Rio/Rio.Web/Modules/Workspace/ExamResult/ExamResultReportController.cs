using Microsoft.AspNetCore.Mvc;
using Rio.ResultReportView;
using Rio.ResultReportView.Endpoints;
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
        public IActionResult GetData(int ExamResultId, Guid ScannedSheetId, int ExamId,
            [FromServices] ISqlConnections SqlConnections,
            [FromServices] IResultReportListHandler handler,
            [FromServices] IExamResultRetrieveHandler exhandler)
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
                    request2.EqualityFilter.Add("ScannedSheetId", ScannedSheetId);
                    ResultReportController endpoint = new ResultReportController();
                    var data = endpoint.List(connection, request2, handler);
                    model.Details = new List<ResultReportRow>();
                    model.Details = data.Entities;

                    RetrieveRequest retrieveRequest = new RetrieveRequest();
                    retrieveRequest.ColumnSelection = RetrieveColumnSelection.Details;
                    retrieveRequest.EntityId = ExamResultId;
                    model.ExamResult = exhandler.Retrieve(connection, retrieveRequest).Entity;

                    var o = ExamResultRow.Fields;
                    model.ExamResult = connection.TryFirst<ExamResultRow>(new Criteria(o.Id) == ExamResultId);

                    var eqr = ResultReportRow.Fields;
                    model.Details = connection.List<ResultReportRow>(new Criteria(eqr.ScannedSheetId) == ScannedSheetId);
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