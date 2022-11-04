using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.GroupRow;

namespace Rio.Workspace
{
    public interface IGroupDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class GroupDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IGroupDeleteHandler
    {
        public GroupDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}