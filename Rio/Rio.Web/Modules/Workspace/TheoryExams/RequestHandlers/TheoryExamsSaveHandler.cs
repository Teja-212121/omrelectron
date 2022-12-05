using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.TheoryExamsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.TheoryExamsRow;

namespace Rio.Workspace
{
    public interface ITheoryExamsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class TheoryExamsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITheoryExamsSaveHandler
    {
        public TheoryExamsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}