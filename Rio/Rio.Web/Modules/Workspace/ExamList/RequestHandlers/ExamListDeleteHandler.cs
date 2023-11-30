using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.ExamListRow;

namespace Rio.Workspace
{
    public interface IExamListDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamListDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IExamListDeleteHandler
    {
        public ExamListDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}