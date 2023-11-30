using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.ActivationLogRow>;
using MyRow = Rio.Workspace.ActivationLogRow;

namespace Rio.Workspace
{
    public interface IActivationLogListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ActivationLogListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IActivationLogListHandler
    {
        public ActivationLogListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}