using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.TeachersRow>;
using MyRow = Rio.Workspace.TeachersRow;

namespace Rio.Workspace
{
    public interface ITeachersListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class TeachersListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITeachersListHandler
    {
        public TeachersListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}