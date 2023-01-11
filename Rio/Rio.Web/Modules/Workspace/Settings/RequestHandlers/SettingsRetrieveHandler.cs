using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.SettingsRow>;
using MyRow = Rio.Workspace.SettingsRow;

namespace Rio.Workspace
{
    public interface ISettingsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class SettingsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISettingsRetrieveHandler
    {
        public SettingsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}