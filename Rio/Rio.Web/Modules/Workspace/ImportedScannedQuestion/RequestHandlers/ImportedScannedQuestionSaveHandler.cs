using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ImportedScannedQuestionRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ImportedScannedQuestionRow;

namespace Rio.Workspace
{
    public interface IImportedScannedQuestionSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ImportedScannedQuestionSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IImportedScannedQuestionSaveHandler
    {
        public ImportedScannedQuestionSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}