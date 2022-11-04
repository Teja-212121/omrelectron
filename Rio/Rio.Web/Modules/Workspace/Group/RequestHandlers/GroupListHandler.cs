using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.GroupRow>;
using MyRow = Rio.Workspace.GroupRow;

namespace Rio.Workspace
{
    public interface IGroupListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class GroupListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IGroupListHandler
    {
        public GroupListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}