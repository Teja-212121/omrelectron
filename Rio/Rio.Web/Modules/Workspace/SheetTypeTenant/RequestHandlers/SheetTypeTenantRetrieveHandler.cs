using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.SheetTypeTenantRow>;
using MyRow = Rio.Workspace.SheetTypeTenantRow;

namespace Rio.Workspace
{
    public interface ISheetTypeTenantRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class SheetTypeTenantRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISheetTypeTenantRetrieveHandler
    {
        public SheetTypeTenantRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}