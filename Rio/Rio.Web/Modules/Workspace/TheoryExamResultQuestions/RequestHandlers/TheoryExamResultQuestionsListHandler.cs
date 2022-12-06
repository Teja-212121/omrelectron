using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.TheoryExamResultQuestionsRow>;
using MyRow = Rio.Workspace.TheoryExamResultQuestionsRow;

namespace Rio.Workspace
{
    public interface ITheoryExamResultQuestionsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class TheoryExamResultQuestionsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITheoryExamResultQuestionsListHandler
    {
        public TheoryExamResultQuestionsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}