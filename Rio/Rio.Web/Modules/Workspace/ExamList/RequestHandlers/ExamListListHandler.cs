using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.ExamListRow>;
using MyRow = Rio.Workspace.ExamListRow;

namespace Rio.Workspace
{
    public interface IExamListListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamListListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamListListHandler
    {
        public ExamListListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}