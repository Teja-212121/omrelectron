using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.ImportedScannedBatchRow>;
using MyRow = Rio.Workspace.ImportedScannedBatchRow;

namespace Rio.Workspace
{
    public interface IImportedScannedBatchRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ImportedScannedBatchRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IImportedScannedBatchRetrieveHandler
    {
        public ImportedScannedBatchRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}