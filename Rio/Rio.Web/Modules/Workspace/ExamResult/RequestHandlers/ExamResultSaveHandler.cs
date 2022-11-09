using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ExamResultRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ExamResultRow;

namespace Rio.Workspace
{
    public interface IExamResultSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamResultSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamResultSaveHandler
    {
        public ExamResultSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}