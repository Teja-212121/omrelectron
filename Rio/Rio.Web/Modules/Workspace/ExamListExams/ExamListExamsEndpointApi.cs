using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rio.Web;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using MyRow = Rio.Workspace.ExamListExamsRow;

namespace Rio.Workspace.Endpoints
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("Api/Services/Workspace/ExamListExams/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class ExamListExamsApiController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IExamListExamsSaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IExamListExamsSaveHandler handler)
        {
            return handler.Update(uow, request);
        }

        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] IExamListExamsDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] IExamListExamsRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow)), IgnoreAntiforgeryToken]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] IExamListExamsListHandler handler)
        {
            return handler.List(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow)), IgnoreAntiforgeryToken]
        public ListResponse<MyRow> ListExams(int examListId, IDbConnection connection, ListRequest request,
            [FromServices] IExamListExamsListHandler handler)
        {
            var response = handler.List(connection, request);
            foreach (var row in response.Entities)
            {
                if (row.ExamListId == examListId)
                {
                    var slir = MyRow.Fields;
                    List<MyRow> examsList = connection.List<MyRow>(q => q
                         .Select(slir.Id, slir.ExamListId, slir.ExamId, slir.TenantId, slir.Priority, slir.StartDate, slir.EndDate, slir.ModelAnswerPaperStartDate)
                         .Where(slir.ExamListId == row.ExamListId.Value));

                    response.Entities = examsList;
                }
            }
            return response;
        }

        [AuthorizeList(typeof(MyRow))]
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
            [FromServices] IExamListExamsListHandler handler,
            [FromServices] IExcelExporter exporter)
        {
            var data = List(connection, request, handler).Entities;
            var bytes = exporter.Export(data, typeof(Columns.ExamListExamsColumns), request.ExportColumns);
            return ExcelContentResult.Create(bytes, "ExamListExamsList_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
        }
    }
}