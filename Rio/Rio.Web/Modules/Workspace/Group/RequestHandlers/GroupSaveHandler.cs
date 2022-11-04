using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.GroupRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.GroupRow;

namespace Rio.Workspace
{
    public interface IGroupSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class GroupSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IGroupSaveHandler
    {
        public GroupSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}