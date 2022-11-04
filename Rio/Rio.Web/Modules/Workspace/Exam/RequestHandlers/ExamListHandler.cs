using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.ExamRow>;
using MyRow = Rio.Workspace.ExamRow;

namespace Rio.Workspace
{
    public interface IExamListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamListHandler
    {
        public ExamListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}