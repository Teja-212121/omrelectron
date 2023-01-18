using Microsoft.AspNetCore.Mvc;
using Rio.Common;
using Rio.ResultReportView;
using Rio.ResultReportView.Endpoints;
using Rio.Web.Modules.Workspace.CommonController.Models;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using MyRow = Rio.Workspace.ExamResultRow;

namespace Rio.Workspace.Endpoints
{
    [Route("Services/Workspace/ExamResult/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class ExamResultController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IExamResultSaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IExamResultSaveHandler handler)
        {
            return handler.Update(uow, request);
        }

        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] IExamResultDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] IExamResultRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow))]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] IExamResultListHandler handler)
        {
            return handler.List(connection, request);
        }

        [AuthorizeList(typeof(MyRow))]
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
            [FromServices] IExamResultListHandler handler,
            [FromServices] IExcelExporter exporter)
        {
            var data = List(connection, request, handler).Entities;
            var bytes = exporter.Export(data, typeof(Columns.ExamResultColumns), request.ExportColumns);
            return ExcelContentResult.Create(bytes, "ExamResultList_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
        }

        [AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse SendEmails(string[] ids, [FromServices] ISqlConnections SqlConnections, [FromServices] IResultReportListHandler handler,
            [FromServices] IExamResultRetrieveHandler exhandler, [FromServices] IScannedQuestionRetrieveHandler scanquestionhandler)
        {
            //var httpContext = Dependency.Resolve<IHttpContextAccessor>().HttpContext;

            using (var connection = SqlConnections.NewByKey("Default"))
            {
                foreach (var id in ids)
                {
                    var model = new ExamResultReportModel();

                    RetrieveRequest retrieveRequest = new RetrieveRequest();
                    retrieveRequest.ColumnSelection = RetrieveColumnSelection.Details;
                    retrieveRequest.EntityId = id;
                    model.ExamResult = exhandler.Retrieve(connection, retrieveRequest).Entity;
                    if (model.ExamResult != null)
                        if (model.ExamResult.StudentId != null)
                        {
                            var Username = "";
                            var Password = "";
                            var FromEmail = "";
                            var Fromname = "";
                            string host = "";
                            int port = 0;
                            bool usessl = false;
                            bool UseXOAUTH2 = true;
                            var settings = connection.TryFirst<SettingsRow>(SettingsRow.Fields.TenantId == model.ExamResult.TenantId.Value);
                            if (settings == null)
                            {
                                throw new ValidationError("Email Settings not available");
                                throw new Exception("Email Settings not available");
                            }
                            else
                            {

                                if (!string.IsNullOrEmpty(settings.Host) && !string.IsNullOrEmpty(settings.UserName) && !string.IsNullOrEmpty(settings.Password)
                                     && settings.Port != null)
                                {

                                    Username = settings.UserName;
                                    Password = settings.Password;
                                    FromEmail = settings.From;
                                    Fromname = model.ExamResult.TenantName;
                                    host = settings.Host;
                                    port = settings.Port.Value;
                                    if (settings.Port != null)
                                        usessl = settings.UseSsl.Value;
                                    if (settings.UseXOAUTH2 != null)
                                        usessl = settings.UseXOAUTH2.Value;
                                }
                                else
                                    throw new ValidationError("Email Settings not available");
                            }
                            model.ScannedQuestion = scanquestionhandler.Retrieve(connection, retrieveRequest).Entity;
                            if (model.ExamResult != null)
                            {


                                ListRequest request2 = new ListRequest();
                                request2.ColumnSelection = ColumnSelection.Details;
                                request2.EqualityFilter = new Dictionary<string, object>();
                                //request2.Sort =new SortBy[]();
                                request2.EqualityFilter.Add("ScannedSheetId", model.ExamResult.ScannedSheetId);
                                ResultReportController endpoint = new ResultReportController();
                                var data = endpoint.List(connection, request2, handler);
                                model.Details = new List<ResultReportRow>();
                                model.Details = data.Entities;
                                var emailSubject = "Exam result Details";
                                var emailBody = TemplateHelper.RenderViewToString(HttpContext.RequestServices,
                                    MVC.Views.ExamResult.ExamResultEmail, model);



                                #region Email
                                var mail = new MailRow();
                                mail.Uid = Guid.NewGuid();
                                mail.Subject = emailSubject;
                                mail.Body = emailBody;
                                mail.Priority = MailQueuePriority.High;
                                mail.Status = MailStatus.InQueue;
                                mail.LockExpiration = DateTime.Now.AddDays(-1);
                                mail.InsertDate = DateTime.Now;
                                mail.InsertUserId = 1;
                                mail.RetryCount = 0;

                                mail.MailFrom = FromEmail;
                                mail.AwsUserId = Username;
                                mail.AwsPassword = Password;
                                mail.Host = host;
                                mail.Port = port;
                                mail.FromName = Fromname;
                                mail.MailTo = model.ExamResult.StudentEmail;
                                mail.UseXOAUTH2 = UseXOAUTH2;
                                //if (message.CC.Count > 0)
                                //    mail.Cc = string.Join(";", message.CC.Select(x => x.ToString()));
                                //if (message.Bcc.Count > 0)
                                //    mail.Bcc = string.Join(";", message.Bcc.Select(x => x.ToString()));
                                //if (message.ReplyToList.Count > 0)
                                //    mail.ReplyTo = string.Join(";", message.ReplyToList.Select(x => x.ToString()));
                                connection.Insert<MailRow>(mail);

                                #endregion
                            }
                        }



                }
            }

            return new SaveResponse();
        }

        /*[AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse GeneratePivotReport(string[] ids,
            [FromServices] ISqlConnections SqlConnections,
            [FromServices] IResultReportListHandler handler,
            [FromServices] IExamResultRetrieveHandler exhandler,
            [FromServices] IScannedQuestionRetrieveHandler scanquestionhandler)
        {
            using (var connection = SqlConnections.NewByKey("Default"))
            {
                foreach (var id in ids)
                {
                    var model = new ExamResultReportModel();

                    RetrieveRequest retrieveRequest = new RetrieveRequest();
                    retrieveRequest.ColumnSelection = RetrieveColumnSelection.Details;
                    retrieveRequest.EntityId = id;
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
            }
            return new SaveResponse();
        }*/
    }
}