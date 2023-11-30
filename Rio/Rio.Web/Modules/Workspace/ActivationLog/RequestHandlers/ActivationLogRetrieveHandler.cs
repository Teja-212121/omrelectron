using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.ActivationLogRow>;
using MyRow = Rio.Workspace.ActivationLogRow;

namespace Rio.Workspace
{
    public interface IActivationLogRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ActivationLogRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IActivationLogRetrieveHandler
    {
        public ActivationLogRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}