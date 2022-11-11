using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(ExamRankWiseResultRow))]
    public class ExamRankWiseResultController : Controller
    {
        [Route("Workspace/ExamRankWiseResult")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/ExamRankWiseResult/ExamRankWiseResultPage",
                ExamRankWiseResultRow.Fields.PageTitle());
        }
    }
}