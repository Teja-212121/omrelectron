using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.ScannedSheetRow>;
using MyRow = Rio.Workspace.ScannedSheetRow;

namespace Rio.Workspace
{
    public interface IScannedSheetListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ScannedSheetListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IScannedSheetListHandler
    {
        public ScannedSheetListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}