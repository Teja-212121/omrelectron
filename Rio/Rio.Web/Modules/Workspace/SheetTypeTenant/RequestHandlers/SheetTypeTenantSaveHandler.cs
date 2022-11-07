using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.SheetTypeTenantRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.SheetTypeTenantRow;

namespace Rio.Workspace
{
    public interface ISheetTypeTenantSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class SheetTypeTenantSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISheetTypeTenantSaveHandler
    {
        public SheetTypeTenantSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}