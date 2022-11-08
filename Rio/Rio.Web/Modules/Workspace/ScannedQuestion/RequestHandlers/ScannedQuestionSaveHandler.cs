using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ScannedQuestionRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ScannedQuestionRow;

namespace Rio.Workspace
{
    public interface IScannedQuestionSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ScannedQuestionSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IScannedQuestionSaveHandler
    {
        public ScannedQuestionSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}