using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.CouponCodeRow>;
using MyRow = Rio.Workspace.CouponCodeRow;

namespace Rio.Workspace
{
    public interface ICouponCodeRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class CouponCodeRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICouponCodeRetrieveHandler
    {
        public CouponCodeRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}