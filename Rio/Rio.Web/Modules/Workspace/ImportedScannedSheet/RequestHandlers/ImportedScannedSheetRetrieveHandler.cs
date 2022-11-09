using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.ImportedScannedSheetRow>;
using MyRow = Rio.Workspace.ImportedScannedSheetRow;

namespace Rio.Workspace
{
    public interface IImportedScannedSheetRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ImportedScannedSheetRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IImportedScannedSheetRetrieveHandler
    {
        public ImportedScannedSheetRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}