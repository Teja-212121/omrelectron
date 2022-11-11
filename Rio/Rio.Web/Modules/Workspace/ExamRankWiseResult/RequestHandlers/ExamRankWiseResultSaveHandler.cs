using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ExamRankWiseResultRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ExamRankWiseResultRow;

namespace Rio.Workspace
{
    public interface IExamRankWiseResultSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamRankWiseResultSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamRankWiseResultSaveHandler
    {
        public ExamRankWiseResultSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}