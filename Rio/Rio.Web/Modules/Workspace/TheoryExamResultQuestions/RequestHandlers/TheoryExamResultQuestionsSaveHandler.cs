using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.TheoryExamResultQuestionsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.TheoryExamResultQuestionsRow;

namespace Rio.Workspace
{
    public interface ITheoryExamResultQuestionsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class TheoryExamResultQuestionsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITheoryExamResultQuestionsSaveHandler
    {
        public TheoryExamResultQuestionsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}