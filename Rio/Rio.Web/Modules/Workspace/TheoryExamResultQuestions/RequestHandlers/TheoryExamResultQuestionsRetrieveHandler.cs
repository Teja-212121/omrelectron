using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.TheoryExamResultQuestionsRow>;
using MyRow = Rio.Workspace.TheoryExamResultQuestionsRow;

namespace Rio.Workspace
{
    public interface ITheoryExamResultQuestionsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class TheoryExamResultQuestionsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITheoryExamResultQuestionsRetrieveHandler
    {
        public TheoryExamResultQuestionsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}