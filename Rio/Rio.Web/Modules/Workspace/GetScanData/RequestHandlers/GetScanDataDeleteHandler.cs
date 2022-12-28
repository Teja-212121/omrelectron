using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.GetScanDataRow;

namespace Rio.Workspace
{
    public interface IGetScanDataDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class GetScanDataDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IGetScanDataDeleteHandler
    {
        public GetScanDataDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}