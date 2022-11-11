using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.ExamQuestionResultRow>;
using MyRow = Rio.Workspace.ExamQuestionResultRow;

namespace Rio.Workspace
{
    public interface IExamQuestionResultListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamQuestionResultListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamQuestionResultListHandler
    {
        public ExamQuestionResultListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}