using Microsoft.AspNetCore.Mvc;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Data;
using System.Globalization;
using MyRow = Rio.Workspace.TheoryExamsRow;

namespace Rio.Workspace.Endpoints
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("Api/Services/Workspace/TheoryExams/[action]")]
    [ConnectionKey(typeof(MyRow)), IgnoreAntiforgeryToken]
    public class ApiTheoryExamsController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] ITheoryExamsSaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] ITheoryExamsSaveHandler handler)
        {
            return handler.Update(uow, request);
        }
 
        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] ITheoryExamsDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] ITheoryExamsRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> ExamDetails(IDbConnection connection, RetrieveRequest request,
            [FromServices] ITheoryExamsRetrieveHandler handler)
        {
            var obj = handler.Retrieve(connection, request);
            obj.Entity.ExamSections = connection.List<TheoryExamSectionsRow>(TheoryExamSectionsRow.Fields.TheoryExamId == obj.Entity.Id.Value);
            obj.Entity.ExamQuestions = connection.List<TheoryExamQuestionsRow>(TheoryExamQuestionsRow.Fields.TheoryExamId == obj.Entity.Id.Value);
            return obj;
        }

        [HttpPost, AuthorizeList(typeof(MyRow))]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] ITheoryExamsListHandler handler)
        {
            return handler.List(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow))]
        public ListResponse<MyRow> List2(IDbConnection connection, ListRequest request,
           [FromServices] ITheoryExamsListHandler handler)
        {
            var obj= handler.List(connection, request);
            if(obj.TotalCount>0)
            foreach (var exam in obj.Entities)
            {
                    exam.ExamSections = connection.List<TheoryExamSectionsRow>(TheoryExamSectionsRow.Fields.TheoryExamId == exam.Id.Value);
                    exam.ExamQuestions = connection.List<TheoryExamQuestionsRow>(TheoryExamQuestionsRow.Fields.TheoryExamId == exam.Id.Value);

             }
            return obj;
        }

        [AuthorizeList(typeof(MyRow))]
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
            [FromServices] ITheoryExamsListHandler handler,
            [FromServices] IExcelExporter exporter)
        {
            var data = List(connection, request, handler).Entities;
            var bytes = exporter.Export(data, typeof(Columns.TheoryExamsColumns), request.ExportColumns);
            return ExcelContentResult.Create(bytes, "TheoryExamsList_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
        }
    }
}