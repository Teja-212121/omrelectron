using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.TheoryExamSectionsRow;

namespace Rio.Workspace
{
    public interface ITheoryExamSectionsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class TheoryExamSectionsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITheoryExamSectionsDeleteHandler
    {
        public TheoryExamSectionsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}