using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.SheetTypeRow>;
using MyRow = Rio.Workspace.SheetTypeRow;

namespace Rio.Workspace
{
    public interface ISheetTypeRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class SheetTypeRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISheetTypeRetrieveHandler
    {
        public SheetTypeRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}