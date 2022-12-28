using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.GetScanDataRow>;
using MyRow = Rio.Workspace.GetScanDataRow;

namespace Rio.Workspace
{
    public interface IGetScanDataRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class GetScanDataRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IGetScanDataRetrieveHandler
    {
        public GetScanDataRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}