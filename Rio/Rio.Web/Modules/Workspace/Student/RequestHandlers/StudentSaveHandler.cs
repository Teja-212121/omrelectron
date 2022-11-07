using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.StudentRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.StudentRow;

namespace Rio.Workspace
{
    public interface IStudentSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class StudentSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IStudentSaveHandler
    {
        public StudentSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}