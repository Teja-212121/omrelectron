using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.SerialKeyRow;

namespace Rio.Workspace
{
    public interface ISerialKeyDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class SerialKeyDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISerialKeyDeleteHandler
    {
        public SerialKeyDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}