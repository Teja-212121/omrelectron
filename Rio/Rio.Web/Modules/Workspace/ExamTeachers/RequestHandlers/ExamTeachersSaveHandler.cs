using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ExamTeachersRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ExamTeachersRow;

namespace Rio.Workspace
{
    public interface IExamTeachersSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamTeachersSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamTeachersSaveHandler
    {
        public ExamTeachersSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}