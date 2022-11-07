using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ExamSectionRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ExamSectionRow;

namespace Rio.Workspace
{
    public interface IExamSectionSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamSectionSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamSectionSaveHandler
    {
        public ExamSectionSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}