using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.ScannedSheetRow;

namespace Rio.Workspace
{
    public interface IScannedSheetDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ScannedSheetDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IScannedSheetDeleteHandler
    {
        public ScannedSheetDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}