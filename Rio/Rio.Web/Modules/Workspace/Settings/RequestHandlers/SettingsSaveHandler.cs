using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.SettingsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.SettingsRow;

namespace Rio.Workspace
{
    public interface ISettingsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class SettingsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISettingsSaveHandler
    {
        public SettingsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}