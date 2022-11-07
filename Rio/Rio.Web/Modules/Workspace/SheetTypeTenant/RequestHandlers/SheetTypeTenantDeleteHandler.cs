using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.SheetTypeTenantRow;

namespace Rio.Workspace
{
    public interface ISheetTypeTenantDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class SheetTypeTenantDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISheetTypeTenantDeleteHandler
    {
        public SheetTypeTenantDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}