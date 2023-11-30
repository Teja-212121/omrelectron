using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.PreDefinedKeyRow>;
using MyRow = Rio.Workspace.PreDefinedKeyRow;

namespace Rio.Workspace
{
    public interface IPreDefinedKeyRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class PreDefinedKeyRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPreDefinedKeyRetrieveHandler
    {
        public PreDefinedKeyRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}