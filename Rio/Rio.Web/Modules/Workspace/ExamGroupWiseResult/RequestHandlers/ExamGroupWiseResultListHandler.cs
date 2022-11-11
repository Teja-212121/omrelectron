using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.ExamGroupWiseResultRow>;
using MyRow = Rio.Workspace.ExamGroupWiseResultRow;

namespace Rio.Workspace
{
    public interface IExamGroupWiseResultListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamGroupWiseResultListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamGroupWiseResultListHandler
    {
        public ExamGroupWiseResultListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}