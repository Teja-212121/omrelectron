using Microsoft.AspNetCore.Mvc;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
using MyRow = Rio.Workspace.ExamQuestionRow;

namespace Rio.Workspace.Endpoints
{
    [Route("Services/Workspace/ExamQuestion/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class ExamQuestionController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IExamQuestionSaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IExamQuestionSaveHandler handler)
        {
            return handler.Update(uow, request);
        }
 
        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] IExamQuestionDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] IExamQuestionRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow))]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] IExamQuestionListHandler handler)
        {
            return handler.List(connection, request);
        }

        [AuthorizeList(typeof(MyRow))]
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
            [FromServices] IExamQuestionListHandler handler,
            [FromServices] IExcelExporter exporter)
        {
            var data = List(connection, request, handler).Entities;
            var bytes = exporter.Export(data, typeof(Columns.ExamQuestionColumns), request.ExportColumns);
            return ExcelContentResult.Create(bytes, "ExamQuestionList_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
        }

        [AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse DeleteExamQuestion(string[] ids, IUnitOfWork uow, [FromServices] IExamQuestionDeleteHandler handler)
        {
            foreach (var id in ids)
            {
                DeleteRequest deleteRequest = new DeleteRequest();
                deleteRequest.EntityId = id;
                DeleteResponse del = handler.Delete(uow, deleteRequest);
            }
            return new SaveResponse();
        }
    }
}