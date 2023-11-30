using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.ExamListExamsRow;

namespace Rio.Workspace
{
    public interface IExamListExamsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamListExamsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IExamListExamsDeleteHandler
    {
        public ExamListExamsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}