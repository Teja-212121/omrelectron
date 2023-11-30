using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ExamListRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ExamListRow;

namespace Rio.Workspace
{
    public interface IExamListSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamListSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamListSaveHandler
    {
        public ExamListSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}