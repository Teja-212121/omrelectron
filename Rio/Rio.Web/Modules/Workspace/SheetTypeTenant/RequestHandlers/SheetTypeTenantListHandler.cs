using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.SheetTypeTenantRow>;
using MyRow = Rio.Workspace.SheetTypeTenantRow;

namespace Rio.Workspace
{
    public interface ISheetTypeTenantListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class SheetTypeTenantListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISheetTypeTenantListHandler
    {
        public SheetTypeTenantListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}