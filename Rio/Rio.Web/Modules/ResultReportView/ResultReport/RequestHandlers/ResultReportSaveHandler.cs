using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.ResultReportView.ResultReportRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.ResultReportView.ResultReportRow;

namespace Rio.ResultReportView
{
    public interface IResultReportSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ResultReportSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IResultReportSaveHandler
    {
        public ResultReportSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}