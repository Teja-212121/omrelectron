using Serenity.Services;
using Serenity.Web;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.SheetTypeTenantRow>;
using MyRow = Rio.Workspace.SheetTypeTenantRow;

namespace Rio.Workspace
{
    public interface ISheetTypeTenantListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class SheetTypeTenantListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISheetTypeTenantListHandler
    {
        public SheetTypeTenantListHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override MyRow ProcessEntity(MyRow row)
        {
            row.SheetTypeOverlayImage = VirtualPathUtility.ToAbsolute("", "~/upload/" + row.SheetTypeOverlayImage);
            return base.ProcessEntity(row);
        }
    }
}