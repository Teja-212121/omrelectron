using Microsoft.AspNetCore.Mvc;
using Rio.Web.Modules.Workspace.CommonController.Models;
using Rio.Workspace;
using Rio.Workspace.Endpoints;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Collections.Generic;
using System.Data;

namespace Rio.Web.Modules.Orders.CommonController
{
    public class RectifyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("~/Rectify/ScanQuestions")]
        public IActionResult ScanQuestions(string ScannedSheetId, [FromServices] ISqlConnections sqlConnections,[FromServices] IScannedQuestionListHandler handler,[FromServices] IScannedSheetRetrieveHandler retrievehandler)
        {
            
            using (var Connection = sqlConnections.NewByKey("Default"))
            {
                RectifyModel rectify = new RectifyModel();
                RectifyModel.ScannedQuestionDatamodel ScannedQuestion=new RectifyModel.ScannedQuestionDatamodel() ;

                try
                {


                    ListRequest request2 = new ListRequest();
                    request2.ColumnSelection = ColumnSelection.Details;
                    request2.EqualityFilter = new Dictionary<string, object>();
                    //request2.Sort =new SortBy[]();
                    request2.EqualityFilter.Add("ScannedSheetId", ScannedSheetId);
                    ScannedQuestionController endpoint = new ScannedQuestionController();
                    var data = endpoint.List(Connection, request2, handler);
                    ScannedQuestion.ScanQuestionList = new List<ScannedQuestionRow>();
                    ScannedQuestion.ScanQuestionList = data.Entities;
                    if (data.Entities != null)
                    {
                        if (!string.IsNullOrEmpty(data.Entities[0].ScannedSheetImageBase64))
                        {
                            if (!data.Entities[0].ScannedSheetImageBase64.StartsWith("data:image/jpeg;base64,"))
                                data.Entities[0].ScannedSheetImageBase64 = "data:image/jpeg;base64," + data.Entities[0].ScannedSheetImageBase64;
                        }
                        
                    }

                    RetrieveRequest retrieveRequest = new RetrieveRequest();
                    retrieveRequest.ColumnSelection = RetrieveColumnSelection.Details;
                    retrieveRequest.EntityId = ScannedSheetId;
                    ScannedQuestion.scannedSheetRow = retrievehandler.Retrieve(Connection, retrieveRequest).Entity;

                    var e = ScannedSheetRow.Fields;
                    var nextScansheet = Connection.TryFirst<ScannedSheetRow>(q => q
                     .Select(e.Id).Take(1)
                    .Where(e.Id >ScannedSheetId));

                    if (nextScansheet != null)
                        ScannedQuestion.NextScannedSheetId = nextScansheet.Id.ToString();
                    var PrevScansheet = Connection.TryFirst<ScannedSheetRow>(q => q
                    .Select(e.Id).Take(1)
                   .Where(e.Id < ScannedSheetId));
                    if (PrevScansheet != null)
                        ScannedQuestion.PrevScannedSheetId = PrevScansheet.Id.ToString();
                    //var nextScansheet=Connection.TryFirst<ScannedSheetRow>()


                }
                finally
                {
                    if (Connection.State == ConnectionState.Open)
                        Connection.Close();
                }

                return View(ScannedQuestion);
               
            }

        }


        [Route("~/Rectify/UpdateScanQuestions")]
        public int UpdateScanQuestions(string QuestionList, string CorrectedExamno, string CorrectedRollno,string ScannedSheetId, [FromServices] ISqlConnections sqlConnections)
        {

            using (var Connection = sqlConnections.NewByKey("Default"))
            {
                int rtn = 1;

                try
                {
                   
                    
                    string CorrectedOption;
                    var Question = QuestionList.Split("#$#");
                    var scannedsheet = Connection.TryFirst<ScannedSheetRow>(ScannedSheetRow.Fields.Id == ScannedSheetId.ToUpper());
                    if (scannedsheet != null)
                    {
                        var srow = new ScannedSheetRow();
                        srow.Id=scannedsheet.Id;
                        srow.CorrectedRollNo = CorrectedRollno;
                        srow.CorrectedExamNo = CorrectedExamno;
                        Connection.UpdateById<ScannedSheetRow>(srow);
                    }

                    for (int u = 0; u < Question.Length; u++)
                    {
                        if (Question[u] != "")
                        {

                            var subjectItem = Question[u].Split("#;#");

                            CorrectedOption = subjectItem[0];
                            int Id = Convert.ToInt32(subjectItem[1]);
                            ScannedQuestionRow row =new ScannedQuestionRow();
                            row.Id = Id;
                            row.CorrectedOptions = CorrectedOption;
                            Connection.UpdateById<ScannedQuestionRow>(row);
                        }
                    }
                

            }
                catch (Exception e)
                {

                    rtn = 0;
                }
                finally
                {
                    if (Connection.State == ConnectionState.Open)
                        Connection.Close();
                }

                return rtn;

            }

        }

    }
}
