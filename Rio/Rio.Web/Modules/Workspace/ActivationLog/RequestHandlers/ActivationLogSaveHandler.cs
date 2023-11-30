using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ActivationLogRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ActivationLogRow;

namespace Rio.Workspace
{
    public interface IActivationLogSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ActivationLogSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IActivationLogSaveHandler
    {
        public ActivationLogSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}