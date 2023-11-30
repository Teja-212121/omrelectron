using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.SerialKeyRow>;
using MyRow = Rio.Workspace.SerialKeyRow;

namespace Rio.Workspace
{
    public interface ISerialKeyRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class SerialKeyRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISerialKeyRetrieveHandler
    {
        public SerialKeyRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}