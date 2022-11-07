using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.ScannedBatchRow;

namespace Rio.Workspace
{
    public interface IScannedBatchDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ScannedBatchDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IScannedBatchDeleteHandler
    {
        public ScannedBatchDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}