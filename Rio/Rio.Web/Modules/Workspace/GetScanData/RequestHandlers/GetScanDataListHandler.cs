using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.GetScanDataRow>;
using MyRow = Rio.Workspace.GetScanDataRow;

namespace Rio.Workspace
{
    public interface IGetScanDataListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class GetScanDataListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IGetScanDataListHandler
    {
        public GetScanDataListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}