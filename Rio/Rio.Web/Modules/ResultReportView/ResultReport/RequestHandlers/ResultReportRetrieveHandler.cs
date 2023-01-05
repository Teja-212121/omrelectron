using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.ResultReportView.ResultReportRow>;
using MyRow = Rio.ResultReportView.ResultReportRow;

namespace Rio.ResultReportView
{
    public interface IResultReportRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ResultReportRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IResultReportRetrieveHandler
    {
        public ResultReportRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}