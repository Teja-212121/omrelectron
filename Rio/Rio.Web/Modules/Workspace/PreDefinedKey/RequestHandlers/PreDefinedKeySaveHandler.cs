using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.PreDefinedKeyRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.PreDefinedKeyRow;

namespace Rio.Workspace
{
    public interface IPreDefinedKeySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class PreDefinedKeySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPreDefinedKeySaveHandler
    {
        public PreDefinedKeySaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}