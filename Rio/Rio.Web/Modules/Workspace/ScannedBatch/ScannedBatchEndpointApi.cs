using Microsoft.AspNetCore.Mvc;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
using MyRow = Rio.Workspace.ScannedBatchRow;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace Rio.Workspace.Endpoints
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("Api/Services/Workspace/ScannedBatch/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow)),IgnoreAntiforgeryToken]
    public class ScannedBatchApiController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IScannedBatchSaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IScannedBatchSaveHandler handler)
        {
            return handler.Update(uow, request);
        }

        [HttpPost]
        public SaveResponse InsertScannedBatchData(IUnitOfWork uow, SaveRequest<MyRow> request, [FromServices] IScannedBatchSaveHandler handler)
        {
            
            var resp = handler.Create(uow, request);

            foreach (ScannedSheetRow ScannedSheet in request.Entity.ScannedSheets)
            {
               uow.Connection.Insert<ScannedSheetRow>(ScannedSheet);
                foreach (ScannedQuestionRow ScannedQuestion in ScannedSheet.ScannedQuestions)
                {
                    uow.Connection.Insert<ScannedQuestionRow>(ScannedQuestion);
                }

            }
           
            return resp;
        }

        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] IScannedBatchDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] IScannedBatchRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow))]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] IScannedBatchListHandler handler)
        {
            return handler.List(connection, request);
        }

        [AuthorizeList(typeof(MyRow))]
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
            [FromServices] IScannedBatchListHandler handler,
            [FromServices] IExcelExporter exporter)
        {
            var data = List(connection, request, handler).Entities;
            var bytes = exporter.Export(data, typeof(Columns.ScannedBatchColumns), request.ExportColumns);
            return ExcelContentResult.Create(bytes, "ScannedBatchList_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
        }


    }
}