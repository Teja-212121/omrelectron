using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ExamListExamsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ExamListExamsRow;

namespace Rio.Workspace
{
    public interface IExamListExamsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamListExamsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamListExamsSaveHandler
    {
        public ExamListExamsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}