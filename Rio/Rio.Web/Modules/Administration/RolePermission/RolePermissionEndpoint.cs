using Microsoft.AspNetCore.Mvc;
using Serenity.Abstractions;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using MyRepository = Rio.Administration.Repositories.RolePermissionRepository;
using MyRow = Rio.Administration.RolePermissionRow;

namespace Rio.Administration.Endpoints
{
    [Route("Services/Administration/RolePermission/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class RolePermissionController : ServiceEndpoint
    {
        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, RolePermissionUpdateRequest request,
            [FromServices] ISqlConnections sqlConnections,
             [FromServices] ITypeSource typeSource)
        {
            return new MyRepository(Context, Cache, sqlConnections, typeSource).Update(uow, request);
        }

        public RolePermissionListResponse List(IDbConnection connection, RolePermissionListRequest request,
             [FromServices] ISqlConnections sqlConnections,
             [FromServices] ITypeSource typeSource)
        {
            return new MyRepository(Context, Cache, sqlConnections, typeSource).List(connection, request);
        }
    }
}
