using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.KeyGenAsRow>;
using MyRow = Rio.Workspace.KeyGenAsRow;

namespace Rio.Workspace
{
    public interface IKeyGenAsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class KeyGenAsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IKeyGenAsListHandler
    {
        public KeyGenAsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}