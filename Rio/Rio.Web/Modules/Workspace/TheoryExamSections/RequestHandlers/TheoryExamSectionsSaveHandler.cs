using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.TheoryExamSectionsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.TheoryExamSectionsRow;

namespace Rio.Workspace
{
    public interface ITheoryExamSectionsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class TheoryExamSectionsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITheoryExamSectionsSaveHandler
    {
        public TheoryExamSectionsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}