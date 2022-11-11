using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(ExamSectionResultRow))]
    public class ExamSectionResultController : Controller
    {
        [Route("Workspace/ExamSectionResult")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/ExamSectionResult/ExamSectionResultPage",
                ExamSectionResultRow.Fields.PageTitle());
        }
    }
}