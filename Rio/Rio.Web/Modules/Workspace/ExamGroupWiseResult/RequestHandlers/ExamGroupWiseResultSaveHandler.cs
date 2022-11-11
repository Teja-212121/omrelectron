using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ExamGroupWiseResultRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ExamGroupWiseResultRow;

namespace Rio.Workspace
{
    public interface IExamGroupWiseResultSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamGroupWiseResultSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamGroupWiseResultSaveHandler
    {
        public ExamGroupWiseResultSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}