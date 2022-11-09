using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.ExamResultRow;

namespace Rio.Workspace
{
    public interface IExamResultDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamResultDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IExamResultDeleteHandler
    {
        public ExamResultDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}