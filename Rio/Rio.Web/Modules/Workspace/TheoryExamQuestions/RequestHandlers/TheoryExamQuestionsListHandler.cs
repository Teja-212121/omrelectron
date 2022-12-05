using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.TheoryExamQuestionsRow>;
using MyRow = Rio.Workspace.TheoryExamQuestionsRow;

namespace Rio.Workspace
{
    public interface ITheoryExamQuestionsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class TheoryExamQuestionsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITheoryExamQuestionsListHandler
    {
        public TheoryExamQuestionsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}