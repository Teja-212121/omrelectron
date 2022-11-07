using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.StudentRow>;
using MyRow = Rio.Workspace.StudentRow;

namespace Rio.Workspace
{
    public interface IStudentListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class StudentListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IStudentListHandler
    {
        public StudentListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}