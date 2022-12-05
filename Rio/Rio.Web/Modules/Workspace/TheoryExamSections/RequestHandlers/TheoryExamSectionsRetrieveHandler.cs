using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.TheoryExamSectionsRow>;
using MyRow = Rio.Workspace.TheoryExamSectionsRow;

namespace Rio.Workspace
{
    public interface ITheoryExamSectionsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class TheoryExamSectionsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITheoryExamSectionsRetrieveHandler
    {
        public TheoryExamSectionsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}