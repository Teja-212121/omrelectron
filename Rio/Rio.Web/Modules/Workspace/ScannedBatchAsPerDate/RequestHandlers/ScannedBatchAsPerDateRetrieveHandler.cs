using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.ScannedBatchAsPerDateRow>;
using MyRow = Rio.Workspace.ScannedBatchAsPerDateRow;

namespace Rio.Workspace
{
    public interface IScannedBatchAsPerDateRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ScannedBatchAsPerDateRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IScannedBatchAsPerDateRetrieveHandler
    {
        public ScannedBatchAsPerDateRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}