using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.RuleTypeRow;

namespace Rio.Workspace
{
    public interface IRuleTypeDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class RuleTypeDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRuleTypeDeleteHandler
    {
        public RuleTypeDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}