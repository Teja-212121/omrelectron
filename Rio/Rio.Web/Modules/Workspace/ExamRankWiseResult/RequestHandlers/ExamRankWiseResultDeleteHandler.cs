using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.ExamRankWiseResultRow;

namespace Rio.Workspace
{
    public interface IExamRankWiseResultDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamRankWiseResultDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IExamRankWiseResultDeleteHandler
    {
        public ExamRankWiseResultDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}