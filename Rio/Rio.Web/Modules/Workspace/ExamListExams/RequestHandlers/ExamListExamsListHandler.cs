using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.ExamListExamsRow>;
using MyRow = Rio.Workspace.ExamListExamsRow;

namespace Rio.Workspace
{
    public interface IExamListExamsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamListExamsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamListExamsListHandler
    {
        public ExamListExamsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}