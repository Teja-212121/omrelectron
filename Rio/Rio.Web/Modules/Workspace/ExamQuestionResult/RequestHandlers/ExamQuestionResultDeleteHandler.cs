using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.ExamQuestionResultRow;

namespace Rio.Workspace
{
    public interface IExamQuestionResultDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamQuestionResultDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IExamQuestionResultDeleteHandler
    {
        public ExamQuestionResultDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}