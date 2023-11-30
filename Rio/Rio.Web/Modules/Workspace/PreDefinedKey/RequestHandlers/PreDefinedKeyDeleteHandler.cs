using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.PreDefinedKeyRow;

namespace Rio.Workspace
{
    public interface IPreDefinedKeyDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class PreDefinedKeyDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPreDefinedKeyDeleteHandler
    {
        public PreDefinedKeyDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}