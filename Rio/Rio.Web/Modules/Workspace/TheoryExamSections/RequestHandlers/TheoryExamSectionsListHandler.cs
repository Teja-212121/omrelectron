using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.TheoryExamSectionsRow>;
using MyRow = Rio.Workspace.TheoryExamSectionsRow;

namespace Rio.Workspace
{
    public interface ITheoryExamSectionsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class TheoryExamSectionsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITheoryExamSectionsListHandler
    {
        public TheoryExamSectionsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}