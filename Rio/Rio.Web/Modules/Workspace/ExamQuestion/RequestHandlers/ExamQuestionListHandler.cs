using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.ExamQuestionRow>;
using MyRow = Rio.Workspace.ExamQuestionRow;

namespace Rio.Workspace
{
    public interface IExamQuestionListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamQuestionListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamQuestionListHandler
    {
        public ExamQuestionListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}