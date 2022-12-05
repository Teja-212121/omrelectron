using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.TheoryExamResultsRow;

namespace Rio.Workspace
{
    public interface ITheoryExamResultsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class TheoryExamResultsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITheoryExamResultsDeleteHandler
    {
        public TheoryExamResultsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}