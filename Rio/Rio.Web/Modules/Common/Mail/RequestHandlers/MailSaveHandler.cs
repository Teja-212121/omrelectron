using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Common.MailRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Common.MailRow;

namespace Rio.Common
{
    public interface IMailSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class MailSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMailSaveHandler
    {
        public MailSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}