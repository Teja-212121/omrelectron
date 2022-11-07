using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ExamQuestionRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ExamQuestionRow;

namespace Rio.Workspace
{
    public interface IExamQuestionSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamQuestionSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamQuestionSaveHandler
    {
        public ExamQuestionSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}