using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.ResultReportView.ResultReportRow;

namespace Rio.ResultReportView
{
    public interface IResultReportDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ResultReportDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IResultReportDeleteHandler
    {
        public ResultReportDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}