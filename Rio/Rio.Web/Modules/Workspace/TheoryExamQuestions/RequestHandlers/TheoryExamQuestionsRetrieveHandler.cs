using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.TheoryExamQuestionsRow>;
using MyRow = Rio.Workspace.TheoryExamQuestionsRow;

namespace Rio.Workspace
{
    public interface ITheoryExamQuestionsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class TheoryExamQuestionsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITheoryExamQuestionsRetrieveHandler
    {
        public TheoryExamQuestionsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}