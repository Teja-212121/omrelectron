using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.TheoryExamResultsRow>;
using MyRow = Rio.Workspace.TheoryExamResultsRow;

namespace Rio.Workspace
{
    public interface ITheoryExamResultsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class TheoryExamResultsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITheoryExamResultsRetrieveHandler
    {
        public TheoryExamResultsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}