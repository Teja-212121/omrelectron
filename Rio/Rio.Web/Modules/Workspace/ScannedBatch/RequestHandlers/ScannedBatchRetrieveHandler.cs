using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.ScannedBatchRow>;
using MyRow = Rio.Workspace.ScannedBatchRow;

namespace Rio.Workspace
{
    public interface IScannedBatchRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ScannedBatchRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IScannedBatchRetrieveHandler
    {
        public ScannedBatchRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}