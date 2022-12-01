using Rio.Web;
using Serenity.Abstractions;
using Serenity.Data;
using Serenity.Services;
using System;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Administration.TenantRow>;
using MyRow = Rio.Administration.TenantRow;

namespace Rio.Administration
{
    public interface ITenantListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class TenantListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITenantListHandler
    {
        private readonly IPermissionService permissions;

        public TenantListHandler(IRequestContext context, IPermissionService permissions)
             : base(context)
        {
            this.permissions = permissions ?? throw new ArgumentNullException(nameof(permissions));
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);
            if (!permissions.HasPermission("Administration:Security"))
            {
                var fld = MyRow.Fields;
                query.Where(fld.TenantId == User.GetTenantId());
            }
        }
    }
}