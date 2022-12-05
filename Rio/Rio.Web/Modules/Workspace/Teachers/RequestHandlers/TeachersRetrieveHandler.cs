using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.TeachersRow>;
using MyRow = Rio.Workspace.TeachersRow;

namespace Rio.Workspace
{
    public interface ITeachersRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class TeachersRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITeachersRetrieveHandler
    {
        public TeachersRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}