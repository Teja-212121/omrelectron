using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.GroupStudentRow>;
using MyRow = Rio.Workspace.GroupStudentRow;

namespace Rio.Workspace
{
    public interface IGroupStudentRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class GroupStudentRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IGroupStudentRetrieveHandler
    {
        public GroupStudentRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}