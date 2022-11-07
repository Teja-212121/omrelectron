using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.StudentRow>;
using MyRow = Rio.Workspace.StudentRow;

namespace Rio.Workspace
{
    public interface IStudentRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class StudentRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IStudentRetrieveHandler
    {
        public StudentRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}