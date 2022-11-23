using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Common.MailRow;

namespace Rio.Common
{
    public interface IMailDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class MailDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMailDeleteHandler
    {
        public MailDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}