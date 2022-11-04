using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.GroupRow>;
using MyRow = Rio.Workspace.GroupRow;

namespace Rio.Workspace
{
    public interface IGroupRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class GroupRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IGroupRetrieveHandler
    {
        public GroupRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}