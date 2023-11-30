using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.ActivationRow;

namespace Rio.Workspace
{
    public interface IActivationDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ActivationDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IActivationDeleteHandler
    {
        public ActivationDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}