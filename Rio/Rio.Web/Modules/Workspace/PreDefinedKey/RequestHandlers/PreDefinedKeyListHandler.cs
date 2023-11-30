using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.PreDefinedKeyRow>;
using MyRow = Rio.Workspace.PreDefinedKeyRow;

namespace Rio.Workspace
{
    public interface IPreDefinedKeyListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class PreDefinedKeyListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPreDefinedKeyListHandler
    {
        public PreDefinedKeyListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}