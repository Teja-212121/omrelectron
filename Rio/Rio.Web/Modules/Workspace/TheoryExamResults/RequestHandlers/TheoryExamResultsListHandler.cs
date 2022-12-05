using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.TheoryExamResultsRow>;
using MyRow = Rio.Workspace.TheoryExamResultsRow;

namespace Rio.Workspace
{
    public interface ITheoryExamResultsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class TheoryExamResultsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITheoryExamResultsListHandler
    {
        public TheoryExamResultsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}