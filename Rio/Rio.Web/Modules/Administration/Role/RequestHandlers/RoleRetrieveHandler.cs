using Rio.Web;
using Serenity.Data;
using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Administration.RoleRow>;
using MyRow = Rio.Administration.RoleRow;


namespace Rio.Administration
{
    public interface IRoleRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
    public class RoleRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRoleRetrieveHandler
    {
        public RoleRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);

            if (!Permissions.HasPermission(PermissionKeys.Tenants))
                query.Where(MyRow.Fields.TenantId == User.GetTenantId());
        }
    }
}