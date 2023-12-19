using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using MyRow = Rio.Workspace.ActivationRow;

namespace Rio.Workspace.Endpoints
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("Api/Services/Workspace/Activation/[action]")]
    [ConnectionKey(typeof(MyRow)), IgnoreAntiforgeryToken]
    public class ActivationApiController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IActivationSaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IActivationSaveHandler handler)
        {
            return handler.Update(uow, request);
        }
 
        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] IActivationDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] IActivationRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow))]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] IActivationListHandler handler)
        {
            return handler.List(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow))]
        public ListResponse<MyRow> ListExamList( IDbConnection connection, ListRequest request,
            [FromServices] IActivationListHandler handler)
        {
            int? teacherid = null;
           
            var response = new ListResponse<MyRow>();
            if (request.EqualityFilter["TeacherId"].ToString() != "")
            {
                teacherid = Convert.ToInt32(request.EqualityFilter["TeacherId"].ToString());
                var teacher = connection.TryFirst<TeachersRow>(TeachersRow.Fields.Id == teacherid.Value);

                if (teacher != null)
                {
                    var examsList = connection.Query<MyRow>(@"select ac.ExamListId as ExamListId, el.Name as ExamListName,el.IsActive as ExamListIsActive,el.Thumbnail as ExamListThumbnail, sr.SerialKey, ac.ActivationDate, ac.ExpiryDate, ac.TenantId, tn.TenantName as TenantTenantName from Activations ac
INNER JOIN ExamLists el on el.Id = ac.ExamListId
INNER JOIN Teachers tr on tr.Id = ac.TeacherId
INNER JOIN SerialKeys sr on sr.Id = ac.SerialKeyId
INNER JOIN Tenants tn on tn.TenantId = ac.TenantId
where tr.UserId =" + teacher.UserId);

                    List<MyRow> examList = examsList.ToList();
                    response.Entities = examList;
                }
            }
            
            return response;
        }

        [AuthorizeList(typeof(MyRow))]
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
            [FromServices] IActivationListHandler handler,
            [FromServices] IExcelExporter exporter)
        {
            var data = List(connection, request, handler).Entities;
            var bytes = exporter.Export(data, typeof(Columns.ActivationColumns), request.ExportColumns);
            return ExcelContentResult.Create(bytes, "ActivationList_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
        }
    }
}