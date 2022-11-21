using Microsoft.AspNetCore.Mvc;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
using MyRow = Rio.Workspace.SheetTypeTenantRow;

namespace Rio.Workspace.Endpoints
{
    [Route("Services/Workspace/SheetTypeTenant/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class SheetTypeTenantController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] ISheetTypeTenantSaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] ISheetTypeTenantSaveHandler handler)
        {
            return handler.Update(uow, request);
        }
 
        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] ISheetTypeTenantDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] ISheetTypeTenantRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow))]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] ISheetTypeTenantListHandler handler)
        {
            return handler.List(connection, request);
        }

        [AuthorizeList(typeof(MyRow))]
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
            [FromServices] ISheetTypeTenantListHandler handler,
            [FromServices] IExcelExporter exporter)
        {
            var data = List(connection, request, handler).Entities;
            var bytes = exporter.Export(data, typeof(Columns.SheetTypeTenantColumns), request.ExportColumns);
            return ExcelContentResult.Create(bytes, "SheetTypeTenantList_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
        }
        [AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse DeleteSheetTypeTenant(string[] ids, IUnitOfWork uow, [FromServices] ISheetTypeTenantDeleteHandler handler)
        {
            foreach (var id in ids)
            {
                DeleteRequest deleteRequest = new DeleteRequest();
                deleteRequest.EntityId = id;
                DeleteResponse del = handler.Delete(uow, deleteRequest);
            }
            return new SaveResponse();
        }

        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Assign(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            SaveResponse saveResponse = new SaveResponse();

            if (request.Entity.RowIds != null)
            {

                //var Exam = Connection.TryFirst<ExamsRow>(ExamsRow.Fields.Id ==(Int32) Row.ExamId);
                //if (Exam.ExamGroup != Row.ExamGroup)
                //    throw new ValidationError("Group Selected and Group in Exam Mismatched");

                string[] rowIds = request.Entity.RowIds.Split(',');
                string erromsg = null;
                if (rowIds.Length > 0)
                {
                    if (rowIds.Length > 4)
                        throw new ValidationError("Maximum 4 SheetTypes are allowed!!!");

                    long tenantId = (long)request.Entity.TenantId;
                    int alreadyAssignedCount = uow.Connection.Count<SheetTypeTenantRow>(new Criteria(SheetTypeTenantRow.Fields.TenantId) == tenantId);
                    if ((5 - (alreadyAssignedCount + rowIds.Length)) < 0)
                    {
                        throw new ValidationError("You can have maximum of 5 Sheets Assinged to your account!!!");
                    }
                    foreach (var id in rowIds)
                    {
                        if (uow.Connection.Exists<MyRow>
                                    (MyRow.Fields.TenantId == (Int64)request.Entity.TenantId &&
                                        MyRow.Fields.SheetTypeId == Convert.ToInt32(id)))
                        {
                            erromsg = erromsg + id + ",";
                        }
                        else
                        {
                            var Id = uow.Connection.InsertAndGetID(new MyRow
                            {
                                TenantId = request.Entity.TenantId,
                                SheetTypeId = Convert.ToInt32(id),
                                DisplayOrder = 0,
                                IsDefault = false,
                                IsActive = 1,
                                InsertDate = DateTime.Now,
                                InsertUserId = 1
                            });
                        }
                    }
                    if (erromsg != null)
                    {
                        erromsg = "Sheets with Id " + erromsg + " already Mapped To Selected Tenants. No Sheets Mapped To Selected Tenants";

                        throw new ValidationError(erromsg);
                    }
                }
            }
            return saveResponse;
        }
    }
}