using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ScannedBatchAsPerDateRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ScannedBatchAsPerDateRow;

namespace Rio.Workspace
{
    public interface IScannedBatchAsPerDateSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ScannedBatchAsPerDateSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IScannedBatchAsPerDateSaveHandler
    {
        public ScannedBatchAsPerDateSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}