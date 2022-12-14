using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.ScannedBatchAsPerDateRow>;
using MyRow = Rio.Workspace.ScannedBatchAsPerDateRow;

namespace Rio.Workspace
{
    public interface IScannedBatchAsPerDateListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ScannedBatchAsPerDateListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IScannedBatchAsPerDateListHandler
    {
        public ScannedBatchAsPerDateListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}