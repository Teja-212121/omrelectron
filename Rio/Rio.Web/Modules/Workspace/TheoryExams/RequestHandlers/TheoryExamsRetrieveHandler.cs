using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.TheoryExamsRow>;
using MyRow = Rio.Workspace.TheoryExamsRow;

namespace Rio.Workspace
{
    public interface ITheoryExamsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class TheoryExamsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITheoryExamsRetrieveHandler
    {
        public TheoryExamsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}