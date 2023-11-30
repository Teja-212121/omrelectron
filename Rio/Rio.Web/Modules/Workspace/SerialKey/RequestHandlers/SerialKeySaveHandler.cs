using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.SerialKeyRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.SerialKeyRow;

namespace Rio.Workspace
{
    public interface ISerialKeySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class SerialKeySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISerialKeySaveHandler
    {
        public SerialKeySaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}