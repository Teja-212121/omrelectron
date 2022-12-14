using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.ScannedBatchAsPerDateRow;

namespace Rio.Workspace
{
    public interface IScannedBatchAsPerDateDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ScannedBatchAsPerDateDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IScannedBatchAsPerDateDeleteHandler
    {
        public ScannedBatchAsPerDateDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}