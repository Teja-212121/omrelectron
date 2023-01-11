using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.SettingsRow;

namespace Rio.Workspace
{
    public interface ISettingsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class SettingsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISettingsDeleteHandler
    {
        public SettingsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}