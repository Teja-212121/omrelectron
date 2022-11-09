using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.RuleTypeRow>;
using MyRow = Rio.Workspace.RuleTypeRow;

namespace Rio.Workspace
{
    public interface IRuleTypeListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class RuleTypeListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRuleTypeListHandler
    {
        public RuleTypeListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}