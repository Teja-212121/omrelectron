using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.ScannedBatchRow>;
using MyRow = Rio.Workspace.ScannedBatchRow;

namespace Rio.Workspace
{
    public interface IScannedBatchListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ScannedBatchListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IScannedBatchListHandler
    {
        public ScannedBatchListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}