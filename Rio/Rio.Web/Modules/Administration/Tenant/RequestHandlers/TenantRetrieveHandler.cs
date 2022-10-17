using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Administration.TenantRow>;
using MyRow = Rio.Administration.TenantRow;

namespace Rio.Administration
{
    public interface ITenantRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class TenantRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITenantRetrieveHandler
    {
        public TenantRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}