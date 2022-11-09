using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.ImportedScannedSheetRow>;
using MyRow = Rio.Workspace.ImportedScannedSheetRow;

namespace Rio.Workspace
{
    public interface IImportedScannedSheetListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ImportedScannedSheetListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IImportedScannedSheetListHandler
    {
        public ImportedScannedSheetListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}