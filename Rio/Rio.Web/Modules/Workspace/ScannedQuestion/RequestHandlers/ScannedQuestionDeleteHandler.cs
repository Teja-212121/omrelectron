using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.ScannedQuestionRow;

namespace Rio.Workspace
{
    public interface IScannedQuestionDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ScannedQuestionDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IScannedQuestionDeleteHandler
    {
        public ScannedQuestionDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}