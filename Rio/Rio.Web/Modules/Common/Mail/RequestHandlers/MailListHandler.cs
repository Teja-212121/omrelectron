using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Common.MailRow>;
using MyRow = Rio.Common.MailRow;

namespace Rio.Common
{
    public interface IMailListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class MailListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMailListHandler
    {
        public MailListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}