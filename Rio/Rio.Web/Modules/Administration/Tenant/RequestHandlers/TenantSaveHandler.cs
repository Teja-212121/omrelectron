using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Administration.TenantRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Administration.TenantRow;

namespace Rio.Administration
{
    public interface ITenantSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class TenantSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITenantSaveHandler
    {
        public TenantSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}