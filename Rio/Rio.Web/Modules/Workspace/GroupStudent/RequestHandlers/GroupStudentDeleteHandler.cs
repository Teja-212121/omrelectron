using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.GroupStudentRow;

namespace Rio.Workspace
{
    public interface IGroupStudentDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class GroupStudentDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IGroupStudentDeleteHandler
    {
        public GroupStudentDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}