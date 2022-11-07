using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.GroupStudentRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.GroupStudentRow;

namespace Rio.Workspace
{
    public interface IGroupStudentSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class GroupStudentSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IGroupStudentSaveHandler
    {
        public GroupStudentSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}