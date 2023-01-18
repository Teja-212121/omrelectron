using Microsoft.AspNetCore.Mvc;
using Rio.Web.Modules.Workspace.CommonController.Models;
using Rio.Workspace;
using Rio.Workspace.Endpoints;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Rio.Web.Modules.Orders.CommonController
{
    public class SectionReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("~/SectionReport/Pivotreport")]
        public IActionResult getPivotSectionReport(string ScannedSheetId, [FromServices] ISqlConnections sqlConnections,[FromServices] IExamSectionResultListHandler handler,[FromServices] IExamResultRetrieveHandler retrievehandler)
        {
            
            using (var Connection = sqlConnections.NewByKey("Default"))
            {
                SectionReportModel report = new SectionReportModel();
                

                try
                {

                    string scannedsheetIdUpperCase = ScannedSheetId.ToUpper();
                    ListRequest request2 = new ListRequest();
                    request2.ColumnSelection = ColumnSelection.Details;
                    request2.EqualityFilter = new Dictionary<string, object>();
                    //request2.Sort =new SortBy[]();
                    request2.EqualityFilter.Add("SheetGuid", ScannedSheetId.ToUpper());
                    ExamSectionResultController endpoint = new ExamSectionResultController();
                    var data = endpoint.List(Connection, request2, handler);
                    report.ExamSectionResultList = new List<ExamSectionResultRow>();
                    report.ExamSectionResultList = data.Entities;
                    //if (data.Entities.Count > 0)
                    //{
                    //    var sectionIds= data.Entities.Select(o => o.ExamSectionId).Distinct();
                    //    report.ExamSectionCount = new List<int>();
                    //    report.ExamSectionCount = sectionIds;
                    //}





                    var examresult = Connection.TryFirst<ExamResultRow>(ExamResultRow.Fields.ScannedSheetId == scannedsheetIdUpperCase);
                    if (examresult != null)
                    {
                        RetrieveRequest retrieveRequest = new RetrieveRequest();
                        retrieveRequest.ColumnSelection = RetrieveColumnSelection.Details;
                        retrieveRequest.EntityId = examresult.Id.Value;
                        report.ExamResult = new ExamResultRow();
                        report.ExamResult = retrievehandler.Retrieve(Connection, retrieveRequest).Entity;
                    }
                    
                    
                    

                }
                finally
                {
                    if (Connection.State == ConnectionState.Open)
                        Connection.Close();
                }

                return View(MVC.Views.ExamResult.ExamsectionResultPivotReport, report);
               
            }

        }


      

    }
}
