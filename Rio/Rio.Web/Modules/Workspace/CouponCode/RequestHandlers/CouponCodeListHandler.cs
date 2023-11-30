using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.CouponCodeRow>;
using MyRow = Rio.Workspace.CouponCodeRow;

namespace Rio.Workspace
{
    public interface ICouponCodeListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CouponCodeListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICouponCodeListHandler
    {
        public CouponCodeListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}