using Serenity.Abstractions;
using Serenity.Data;
using Serenity.Services;
using Serenity.Web;
using System;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.SheetTypeRow>;
using MyRow = Rio.Workspace.SheetTypeRow;

namespace Rio.Workspace
{
    public interface ISheetTypeListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class SheetTypeListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISheetTypeListHandler
    {
        private readonly IPermissionService permissions;

        public SheetTypeListHandler(IRequestContext context, IPermissionService permissions)
             : base(context)
        {
            this.permissions = permissions ?? throw new ArgumentNullException(nameof(permissions));
        }
        protected override MyRow ProcessEntity(MyRow row)
        {
            Row.OverlayImage = VirtualPathUtility.ToAbsolute("","~/upload/" + Row.OverlayImage);
            return base.ProcessEntity(row);
        }
        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);
            if (!permissions.HasPermission("Administration:Security"))
            {
                var fld = MyRow.Fields;
                query.Where(fld.IsPrivate == 0);
            }
        }
    }
}