using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.GetScanDataRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.GetScanDataRow;

namespace Rio.Workspace
{
    public interface IGetScanDataSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class GetScanDataSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IGetScanDataSaveHandler
    {
        public GetScanDataSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}