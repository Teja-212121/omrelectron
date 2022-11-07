using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.ExamQuestionRow;

namespace Rio.Workspace
{
    public interface IExamQuestionDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamQuestionDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IExamQuestionDeleteHandler
    {
        public ExamQuestionDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}