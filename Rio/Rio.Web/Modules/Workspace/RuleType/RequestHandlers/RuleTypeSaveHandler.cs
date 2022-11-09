using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.RuleTypeRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.RuleTypeRow;

namespace Rio.Workspace
{
    public interface IRuleTypeSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class RuleTypeSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRuleTypeSaveHandler
    {
        public RuleTypeSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}