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
        public IActionResult GetData(int ExamResultId,
            [FromServices] ISqlConnections SqlConnections,
            [FromServices] IResultReportListHandler handler,
            [FromServices] IExamResultRetrieveHandler exhandler,
            [FromServices] IScannedQuestionRetrieveHandler scanquestionhandler)
        {
            using (var connection = SqlConnections.NewByKey("Default"))
            {
                var model = new ExamResultReportModel();
                try
                {
                    RetrieveRequest retrieveRequest = new RetrieveRequest();
                    retrieveRequest.ColumnSelection = RetrieveColumnSelection.Details;
                    retrieveRequest.EntityId = ExamResultId;
                    model.ExamResult = exhandler.Retrieve(connection, retrieveRequest).Entity;
                   
                    model.ScannedQuestion = scanquestionhandler.Retrieve(connection, retrieveRequest).Entity;
                    if (model.ExamResult != null)
                    {
                        if (!string.IsNullOrEmpty(model.ExamResult.ScannedSheetImageBase64))
                        {
                            if (!model.ExamResult.ScannedSheetImageBase64.StartsWith("data:image/jpeg;base64,"))
                                model.ExamResult.ScannedSheetImageBase64 = "data:image/jpeg;base64," + model.ExamResult.ScannedSheetImageBase64;

                        }
                        
                        ListRequest request2 = new ListRequest();
                        request2.ColumnSelection = ColumnSelection.Details;
                        request2.EqualityFilter = new Dictionary<string, object>();
                        //request2.Sort =new SortBy[]();
                        request2.EqualityFilter.Add("ScannedSheetId", model.ExamResult.ScannedSheetId);
                        ResultReportController endpoint = new ResultReportController();
                        var data = endpoint.List(connection, request2, handler);
                        model.Details = new List<ResultReportRow>();
                        model.Details = data.Entities;
                    }
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