using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.ResultReportView.ResultReportRow>;
using MyRow = Rio.ResultReportView.ResultReportRow;

namespace Rio.ResultReportView
{
    public interface IResultReportListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ResultReportListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IResultReportListHandler
    {
        public ResultReportListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}