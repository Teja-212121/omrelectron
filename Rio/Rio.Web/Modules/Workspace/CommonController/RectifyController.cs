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
        public IActionResult ScanQuestions(string ScannedSheetId, [FromServices] ISqlConnections sqlConnections,[FromServices] IScannedQuestionListHandler handler)
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
        public int UpdateScanQuestions(string QuestionList, [FromServices] ISqlConnections sqlConnections)
        {

            using (var Connection = sqlConnections.NewByKey("Default"))
            {
                int rtn = 1;

                try
                {
                   
                    
                    string CorrectedOption;
                    var Question = QuestionList.Split("#$#");

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
