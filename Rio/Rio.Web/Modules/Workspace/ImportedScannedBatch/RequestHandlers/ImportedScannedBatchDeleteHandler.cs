using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.ImportedScannedBatchRow;

namespace Rio.Workspace
{
    public interface IImportedScannedBatchDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ImportedScannedBatchDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IImportedScannedBatchDeleteHandler
    {
        public ImportedScannedBatchDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}