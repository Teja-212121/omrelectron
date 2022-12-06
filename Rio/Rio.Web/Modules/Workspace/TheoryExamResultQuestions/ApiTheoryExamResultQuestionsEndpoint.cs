using Microsoft.AspNetCore.Mvc;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using System.Globalization;
using System.Collections.Generic;
using MyRow = Rio.Workspace.TheoryExamResultQuestionsRow;

namespace Rio.Workspace.Endpoints
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("Api/Services/Workspace/TheoryExamResultQuestions/[action]")]
    [ConnectionKey(typeof(MyRow)), IgnoreAntiforgeryToken]
    public class ApiTheoryExamResultQuestionsController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] ITheoryExamResultQuestionsSaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] ITheoryExamResultQuestionsSaveHandler handler)
        {
            return handler.Update(uow, request);
        }

        [HttpPost]
        public SaveResponse BulkInsertQuestions(IUnitOfWork uow, SaveRequest<List<MyRow>> request, [FromServices] ITheoryExamResultQuestionsSaveHandler handler)
        {



            foreach (MyRow StudentExamQuestion in request.Entity)
            {
                SaveRequest<MyRow> saveRequest = new SaveRequest<MyRow>();
                saveRequest.Entity = StudentExamQuestion;
                //saveRequest.EntityId = StudentExamQuestion.PId;
                SaveResponse saveResponse = Create(uow, saveRequest, handler);

            }

            var response = new SaveResponse();
            response.EntityId = 1;
            return response;
        }

        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] ITheoryExamResultQuestionsDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] ITheoryExamResultQuestionsRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow))]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] ITheoryExamResultQuestionsListHandler handler)
        {
            return handler.List(connection, request);
        }

        [AuthorizeList(typeof(MyRow))]
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
            [FromServices] ITheoryExamResultQuestionsListHandler handler,
            [FromServices] IExcelExporter exporter)
        {
            var data = List(connection, request, handler).Entities;
            var bytes = exporter.Export(data, typeof(Columns.TheoryExamResultQuestionsColumns), request.ExportColumns);
            return ExcelContentResult.Create(bytes, "TheoryExamResultQuestionsList_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
        }
    }
}