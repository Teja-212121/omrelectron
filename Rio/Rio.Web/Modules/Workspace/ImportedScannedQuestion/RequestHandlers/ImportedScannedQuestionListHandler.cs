using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.ImportedScannedQuestionRow>;
using MyRow = Rio.Workspace.ImportedScannedQuestionRow;

namespace Rio.Workspace
{
    public interface IImportedScannedQuestionListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ImportedScannedQuestionListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IImportedScannedQuestionListHandler
    {
        public ImportedScannedQuestionListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}