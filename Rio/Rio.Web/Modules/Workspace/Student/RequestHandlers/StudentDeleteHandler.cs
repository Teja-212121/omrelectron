using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.StudentRow;

namespace Rio.Workspace
{
    public interface IStudentDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class StudentDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IStudentDeleteHandler
    {
        public StudentDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}