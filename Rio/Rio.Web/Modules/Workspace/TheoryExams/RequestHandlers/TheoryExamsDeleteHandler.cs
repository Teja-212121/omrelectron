using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.TheoryExamsRow;

namespace Rio.Workspace
{
    public interface ITheoryExamsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class TheoryExamsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITheoryExamsDeleteHandler
    {
        public TheoryExamsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}