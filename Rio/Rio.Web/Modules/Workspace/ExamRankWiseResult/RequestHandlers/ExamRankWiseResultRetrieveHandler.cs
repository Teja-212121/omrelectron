using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.ExamRankWiseResultRow>;
using MyRow = Rio.Workspace.ExamRankWiseResultRow;

namespace Rio.Workspace
{
    public interface IExamRankWiseResultRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamRankWiseResultRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamRankWiseResultRetrieveHandler
    {
        public ExamRankWiseResultRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}