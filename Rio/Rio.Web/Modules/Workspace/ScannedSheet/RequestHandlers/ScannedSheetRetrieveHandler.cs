using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.ScannedSheetRow>;
using MyRow = Rio.Workspace.ScannedSheetRow;

namespace Rio.Workspace
{
    public interface IScannedSheetRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ScannedSheetRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IScannedSheetRetrieveHandler
    {
        public ScannedSheetRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}