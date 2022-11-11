using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(ExamGroupWiseResultRow))]
    public class ExamGroupWiseResultController : Controller
    {
        [Route("Workspace/ExamGroupWiseResult")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/ExamGroupWiseResult/ExamGroupWiseResultPage",
                ExamGroupWiseResultRow.Fields.PageTitle());
        }
    }
}