using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.ImportedScannedBatchRow>;
using MyRow = Rio.Workspace.ImportedScannedBatchRow;

namespace Rio.Workspace
{
    public interface IImportedScannedBatchListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ImportedScannedBatchListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IImportedScannedBatchListHandler
    {
        public ImportedScannedBatchListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}