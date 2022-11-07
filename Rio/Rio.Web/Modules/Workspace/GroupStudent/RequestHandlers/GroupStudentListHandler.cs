using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.GroupStudentRow>;
using MyRow = Rio.Workspace.GroupStudentRow;

namespace Rio.Workspace
{
    public interface IGroupStudentListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class GroupStudentListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IGroupStudentListHandler
    {
        public GroupStudentListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}