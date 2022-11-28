using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("Api/Services/Workspace/SheetTypeTenant/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class SheetTypeTenantApiController : ServiceEndpoint
    {
        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] ISheetTypeTenantRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow)), IgnoreAntiforgeryToken]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] ISheetTypeTenantListHandler handler)
        {
            return handler.List(connection, request);
        }
    }
}