using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Common.MailRow>;
using MyRow = Rio.Common.MailRow;

namespace Rio.Common
{
    public interface IMailRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MailRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMailRetrieveHandler
    {
        public MailRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}