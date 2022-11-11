using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.ExamRankWiseResultRow>;
using MyRow = Rio.Workspace.ExamRankWiseResultRow;

namespace Rio.Workspace
{
    public interface IExamRankWiseResultListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamRankWiseResultListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamRankWiseResultListHandler
    {
        public ExamRankWiseResultListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}