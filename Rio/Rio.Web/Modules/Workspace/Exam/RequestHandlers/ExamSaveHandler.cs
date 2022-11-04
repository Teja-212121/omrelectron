using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ExamRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ExamRow;

namespace Rio.Workspace
{
    public interface IExamSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamSaveHandler
    {
        public ExamSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}