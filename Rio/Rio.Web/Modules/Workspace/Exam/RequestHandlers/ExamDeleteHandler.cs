using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.ExamRow;

namespace Rio.Workspace
{
    public interface IExamDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IExamDeleteHandler
    {
        public ExamDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}