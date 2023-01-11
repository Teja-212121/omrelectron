using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.SettingsRow>;
using MyRow = Rio.Workspace.SettingsRow;

namespace Rio.Workspace
{
    public interface ISettingsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class SettingsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISettingsListHandler
    {
        public SettingsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}