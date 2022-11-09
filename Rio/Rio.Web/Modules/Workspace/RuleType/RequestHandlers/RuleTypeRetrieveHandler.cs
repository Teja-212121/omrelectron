using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.RuleTypeRow>;
using MyRow = Rio.Workspace.RuleTypeRow;

namespace Rio.Workspace
{
    public interface IRuleTypeRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class RuleTypeRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRuleTypeRetrieveHandler
    {
        public RuleTypeRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}