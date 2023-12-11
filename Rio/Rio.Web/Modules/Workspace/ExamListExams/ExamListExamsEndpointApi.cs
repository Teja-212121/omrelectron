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
using System.Linq;
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
                    var examsList = connection.Query<MyRow>(@"SELECT MR.Id, MR.ExamListId, MR.ExamId, MR.TenantId, MR.Priority, MR.StartDate, MR.EndDate, MR.ModelAnswerPaperStartDate,MR.TenantId, ST.SheetTypeDisplayName, ST.Name, ST.Description, ST.SheetData, ST.SheetImage, ST.OverlayImageOpenCV, ST.PdfTemplate, ST.Id AS SheetTypeId, ST.TotalQuestions, ST.EPaperSize, ST.HeightInPixel, ST.WidthInPixel, ST.Synced, ST.IsPrivate, ST.SheetNumber
                     FROM ExamListExams MR
                      INNER JOIN Exams ER ON MR.ExamId = ER.Id
                     INNER JOIN SheetTypes ST ON ER.SheetTypeId = ST.Id where MR.ExamListId =" + examListId);
            
                    List<MyRow> examListExams = examsList.ToList();
                    response.Entities = examListExams;
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