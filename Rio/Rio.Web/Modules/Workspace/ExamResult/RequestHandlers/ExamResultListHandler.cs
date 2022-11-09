using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.ExamResultRow>;
using MyRow = Rio.Workspace.ExamResultRow;

namespace Rio.Workspace
{
    public interface IExamResultListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamResultListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamResultListHandler
    {
        public ExamResultListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}