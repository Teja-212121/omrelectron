using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.ActivationRow>;
using MyRow = Rio.Workspace.ActivationRow;

namespace Rio.Workspace
{
    public interface IActivationListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ActivationListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IActivationListHandler
    {
        public ActivationListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}