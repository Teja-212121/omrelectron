using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ExamQuestionResultRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ExamQuestionResultRow;

namespace Rio.Workspace
{
    public interface IExamQuestionResultSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamQuestionResultSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamQuestionResultSaveHandler
    {
        public ExamQuestionResultSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}