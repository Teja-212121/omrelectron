using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(ExamResultRow))]
    public class ExamResultController : Controller
    {
        [Route("Workspace/ExamResult")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/ExamResult/ExamResultPage",
                ExamResultRow.Fields.PageTitle());
        }
    }
}