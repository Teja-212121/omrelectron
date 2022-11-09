using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.ImportedScannedQuestionRow>;
using MyRow = Rio.Workspace.ImportedScannedQuestionRow;

namespace Rio.Workspace
{
    public interface IImportedScannedQuestionRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ImportedScannedQuestionRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IImportedScannedQuestionRetrieveHandler
    {
        public ImportedScannedQuestionRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}