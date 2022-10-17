using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Administration.TenantRow>;
using MyRow = Rio.Administration.TenantRow;

namespace Rio.Administration
{
    public interface ITenantListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class TenantListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITenantListHandler
    {
        public TenantListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}