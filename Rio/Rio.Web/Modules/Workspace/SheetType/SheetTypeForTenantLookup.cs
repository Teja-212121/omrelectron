
using Rio.Administration;
using Rio.Workspace;
using Serenity.Abstractions;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Web;
using System;
using Rio.Web;

namespace Rio.Workspace.Lookups
{
    [LookupScript("Workspace.SheetTypeForTenant", Expiration = 1, Permission = "?")]
    public sealed class SheetTypeForTenantLookup : RowLookupScript<SheetTypeTenantRow>
    {
        public IUserAccessor UserAccessor { get; }
        public SheetTypeForTenantLookup(ISqlConnections sqlConnections, IUserAccessor userAccessor)
            : base(sqlConnections)
        {
            IdField = SheetTypeTenantRow.Fields.SheetTypeId.PropertyName;
            Permission = "*";            
            UserAccessor = userAccessor ?? throw new ArgumentNullException(nameof(userAccessor));
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);
            var fld = SheetTypeTenantRow.Fields;
            var sheetType = SheetTypeRow.Fields;
            if (UserAccessor.User.Identity.Name.ToLower() != "admin")
            {

                query.Select(fld.TenantId,fld.SheetTypeDisplayName,fld.SheetTypeId)
                    .Where(fld.TenantId == UserAccessor.User.GetTenantId());
            }
            else
            query.Select(fld.TenantId, fld.SheetTypeDisplayName, fld.SheetTypeId);
        }
    }
}