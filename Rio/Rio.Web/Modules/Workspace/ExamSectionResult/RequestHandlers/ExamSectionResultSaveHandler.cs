using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ExamSectionResultRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ExamSectionResultRow;

namespace Rio.Workspace
{
    public interface IExamSectionResultSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamSectionResultSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamSectionResultSaveHandler
    {
        public ExamSectionResultSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}