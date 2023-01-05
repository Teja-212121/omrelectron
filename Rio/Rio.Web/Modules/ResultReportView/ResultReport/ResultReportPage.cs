using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.ResultReportView.Pages 
{

    [PageAuthorize(typeof(ResultReportRow))]
    public class ResultReportController : Controller
    {
        [Route("ResultReportView/ResultReport")]
        public ActionResult Index()
        {
            return this.GridPage("@/ResultReportView/ResultReport/ResultReportPage",
                ResultReportRow.Fields.PageTitle());
        }
    }
}