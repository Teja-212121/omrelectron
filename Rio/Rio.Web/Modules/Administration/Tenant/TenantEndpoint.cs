using Microsoft.AspNetCore.Mvc;
using Rio.Web.Enums;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
using MyRow = Rio.Administration.TenantRow;

namespace Rio.Administration.Endpoints
{
    [Route("Services/Administration/Tenant/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class TenantController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] ITenantSaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] ITenantSaveHandler handler)
        {
            return handler.Update(uow, request);
        }
 
        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] ITenantDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] ITenantRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow))]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] ITenantListHandler handler)
        {
            return handler.List(connection, request);
        }

        [AuthorizeList(typeof(MyRow))]
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
            [FromServices] ITenantListHandler handler,
            [FromServices] IExcelExporter exporter)
        {
            var data = List(connection, request, handler).Entities;
            var bytes = exporter.Export(data, typeof(Columns.TenantColumns), request.ExportColumns);
            return ExcelContentResult.Create(bytes, "TenantList_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
        }

        [HttpPost]
        public SaveResponse ApproveTenants(string[] ids, [FromServices] ISqlConnections SqlConnections)
        {
            //var http = Dependency.Resolve<IHttpContextAccessor>().HttpContext;
            using (var Connection = SqlConnections.NewByKey("Default"))
            {
                string ApprovedTenants = null;
                foreach (var id in ids)
                {
                    var et = Connection.TryFirst<MyRow>(MyRow.Fields.TenantId == Convert.ToInt32(id));

                    if (et.EApprovalStatus != EApprovalStatus.Approved)
                    {
                        et.EApprovalStatus = EApprovalStatus.Approved;
                        et.IsActive = 1;
                        Connection.UpdateById<MyRow>(et);
                        var user = Connection.TryFirst<UserRow>(UserRow.Fields.TenantId == Convert.ToInt32(id));
                        if (user != null)
                        {
                            user.IsActive = 1;
                            Connection.UpdateById<UserRow>(user);
                            
                        }

                    }

                    else
                    {
                        if (ApprovedTenants == null)
                            ApprovedTenants = et.TenantId.ToString();
                        else
                            ApprovedTenants = ApprovedTenants + "," + et.TenantId.ToString();

                    }

                    if (!string.IsNullOrEmpty(ApprovedTenants))
                    {
                        throw new ValidationError("Tenant with Id Already Approved:" + ApprovedTenants + ",other tenants approved successfully");
                    }
                }
            }
            return new SaveResponse();
        }
    }
}