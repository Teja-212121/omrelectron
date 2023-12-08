using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.KeyGenAsRow;

namespace Rio.Workspace
{
    public interface IKeyGenAsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class KeyGenAsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IKeyGenAsDeleteHandler
    {
        public KeyGenAsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}