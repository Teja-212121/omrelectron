using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ActivationRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ActivationRow;

namespace Rio.Workspace
{
    public interface IActivationSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ActivationSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IActivationSaveHandler
    {
        public ActivationSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}