using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.ActivationRow>;
using MyRow = Rio.Workspace.ActivationRow;

namespace Rio.Workspace
{
    public interface IActivationRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ActivationRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IActivationRetrieveHandler
    {
        public ActivationRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}