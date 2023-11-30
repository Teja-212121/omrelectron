using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.CouponCodeRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.CouponCodeRow;

namespace Rio.Workspace
{
    public interface ICouponCodeSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class CouponCodeSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICouponCodeSaveHandler
    {
        public CouponCodeSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}