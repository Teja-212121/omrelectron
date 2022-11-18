using Microsoft.AspNetCore.Mvc;
using Rio.Web;
using Serenity;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
using MyRow = Rio.Workspace.SelectSheetTypeRow;

namespace Rio.Workspace.Endpoints
{
    [Route("Services/Workspace/SelectSheetType/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class SelectSheetTypeController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] ISelectSheetTypeSaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] ISelectSheetTypeSaveHandler handler)
        {
            return handler.Update(uow, request);
        }
 
        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] ISelectSheetTypeDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] ISelectSheetTypeRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow))]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] ISelectSheetTypeListHandler handler)
        {
            return handler.List(connection, request);
        }

        [AuthorizeList(typeof(MyRow))]
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
            [FromServices] ISelectSheetTypeListHandler handler,
            [FromServices] IExcelExporter exporter)
        {
            var data = List(connection, request, handler).Entities;
            var bytes = exporter.Export(data, typeof(Columns.SelectSheetTypeColumns), request.ExportColumns);
            return ExcelContentResult.Create(bytes, "SelectSheetTypeList_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
        }

        /*[HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse UpdateSheetTypeTenants(string[] ids)
        {
            var conn = Connection.NewByKey("Default");
            if (ids.Length > 4)
                throw new ValidationError("Maximum 4 SheetTypes are allowed!!!");
            int tenantId = User.GetTenantId();
            int alreadyAssignedCount = conn.Count<SheetTypeTenantRow>(new Criteria(SheetTypeTenantRow.Fields.TenantId) == tenantId);
            if ((5 - (alreadyAssignedCount + ids.Length)) < 0)
            {
                throw new ValidationError("You can have maximum of 5 Sheets Assinged to your account!!!");
            }
            foreach (string sheetId in ids)
            {

                if (!conn.Exists<SheetTypeTenantRow>(new Criteria(SheetTypeTenantRow.Fields.SheetTypeId) == sheetId && new Criteria(SheetTypeTenantRow.Fields.TenantId) == tenantId))
                {
                    SheetTypeTenantRow mySheetType = new SheetTypeTenantRow()
                    {
                        SheetTypeId = Convert.ToInt32(sheetId),
                        TenantId = tenantId,
                        InsertDate = DateTime.Now,
                        InsertUserId = Convert.ToInt32(User.GetIdentifier()),
                        IsActive = 1
                    };
                    conn.Insert<SheetTypeTenantRow>(mySheetType);
                }
            }
          
            return new SaveResponse();

        }*/
    }
}