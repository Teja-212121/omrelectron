using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.KeyGenAsRow>;
using MyRow = Rio.Workspace.KeyGenAsRow;

namespace Rio.Workspace
{
    public interface IKeyGenAsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class KeyGenAsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IKeyGenAsRetrieveHandler
    {
        public KeyGenAsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}