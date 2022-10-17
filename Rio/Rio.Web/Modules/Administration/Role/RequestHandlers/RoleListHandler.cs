using Rio.Web;
using Serenity.Data;
using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Administration.RoleRow>;
using MyRow = Rio.Administration.RoleRow;


namespace Rio.Administration
{
    public interface IRoleListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class RoleListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoleListHandler
    {
        public RoleListHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void ApplyFilters(SqlQuery query)
        {
            base.ApplyFilters(query);

            if (!Permissions.HasPermission(PermissionKeys.Tenants))
                query.Where(MyRow.Fields.TenantId == User.GetTenantId());
        }
    }
}