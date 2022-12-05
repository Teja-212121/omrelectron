using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.TheoryExamResultsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.TheoryExamResultsRow;

namespace Rio.Workspace
{
    public interface ITheoryExamResultsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class TheoryExamResultsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITheoryExamResultsSaveHandler
    {
        public TheoryExamResultsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}