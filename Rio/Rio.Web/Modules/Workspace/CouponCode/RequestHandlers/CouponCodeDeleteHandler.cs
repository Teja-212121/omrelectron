using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.CouponCodeRow;

namespace Rio.Workspace
{
    public interface ICouponCodeDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class CouponCodeDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICouponCodeDeleteHandler
    {
        public CouponCodeDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}