using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.SerialKeyRow>;
using MyRow = Rio.Workspace.SerialKeyRow;

namespace Rio.Workspace
{
    public interface ISerialKeyListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class SerialKeyListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISerialKeyListHandler
    {
        public SerialKeyListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}