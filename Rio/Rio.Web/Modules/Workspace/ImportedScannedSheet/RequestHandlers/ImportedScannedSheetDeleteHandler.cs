using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.ImportedScannedSheetRow;

namespace Rio.Workspace
{
    public interface IImportedScannedSheetDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ImportedScannedSheetDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IImportedScannedSheetDeleteHandler
    {
        public ImportedScannedSheetDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}