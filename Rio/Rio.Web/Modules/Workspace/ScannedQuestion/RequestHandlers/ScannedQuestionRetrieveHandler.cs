using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.ScannedQuestionRow>;
using MyRow = Rio.Workspace.ScannedQuestionRow;

namespace Rio.Workspace
{
    public interface IScannedQuestionRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ScannedQuestionRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IScannedQuestionRetrieveHandler
    {
        public ScannedQuestionRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}