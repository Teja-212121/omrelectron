using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.TheoryExamQuestionsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.TheoryExamQuestionsRow;

namespace Rio.Workspace
{
    public interface ITheoryExamQuestionsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class TheoryExamQuestionsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITheoryExamQuestionsSaveHandler
    {
        public TheoryExamQuestionsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}