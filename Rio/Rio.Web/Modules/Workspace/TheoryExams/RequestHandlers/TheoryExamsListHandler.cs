using Serenity.Data;
using Serenity.Services;
using System.Net;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.TheoryExamsRow>;
using MyRow = Rio.Workspace.TheoryExamsRow;

namespace Rio.Workspace
{
    public interface ITheoryExamsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class TheoryExamsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITheoryExamsListHandler
    {
        public TheoryExamsListHandler(IRequestContext context)
             : base(context)
        {
        }
        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);
            
        }
    }
}