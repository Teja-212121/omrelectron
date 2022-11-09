using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.ImportedScannedQuestionRow;

namespace Rio.Workspace
{
    public interface IImportedScannedQuestionDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ImportedScannedQuestionDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IImportedScannedQuestionDeleteHandler
    {
        public ImportedScannedQuestionDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}