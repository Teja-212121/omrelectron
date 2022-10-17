using Microsoft.AspNetCore.Mvc;
using Serenity.Abstractions;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Linq;
using MyRepository = Rio.Administration.Repositories.UserPermissionRepository;
using MyRow = Rio.Administration.UserPermissionRow;

namespace Rio.Administration.Endpoints
{
    [Route("Services/Administration/UserPermission/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class UserPermissionController : ServiceEndpoint
    {
        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, UserPermissionUpdateRequest request,
             [FromServices] ISqlConnections sqlConnections,
             [FromServices] ITypeSource typeSource)
        {
            return new MyRepository(Context, Cache, sqlConnections, typeSource).Update(uow, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, UserPermissionListRequest request,
             [FromServices] ISqlConnections sqlConnections,
             [FromServices] ITypeSource typeSource)
        {
            return new MyRepository(Context, Cache, sqlConnections, typeSource).List(connection, request);
        }

        public ListResponse<string> ListRolePermissions(IDbConnection connection, UserPermissionListRequest request,
             [FromServices] ISqlConnections sqlConnections,
             [FromServices] ITypeSource typeSource)
        {
            return new MyRepository(Context, Cache, sqlConnections, typeSource).ListRolePermissions(connection, request);
        }

        public ListResponse<string> ListPermissionKeys(
            [FromServices] ISqlConnections sqlConnections,
            [FromServices] ITypeSource typeSource)
        {
            return new ListResponse<string>
            {
                Entities = MyRepository.ListPermissionKeys(Cache, sqlConnections, typeSource,
                    includeRoles: false).ToList()
            };
        }
    }
}