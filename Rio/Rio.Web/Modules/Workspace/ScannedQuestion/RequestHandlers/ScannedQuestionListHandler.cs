using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.ScannedQuestionRow>;
using MyRow = Rio.Workspace.ScannedQuestionRow;

namespace Rio.Workspace
{
    public interface IScannedQuestionListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ScannedQuestionListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IScannedQuestionListHandler
    {
        public ScannedQuestionListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}