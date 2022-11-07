using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(ExamSectionRow))]
    public class ExamSectionController : Controller
    {
        [Route("Workspace/ExamSection")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/ExamSection/ExamSectionPage",
                ExamSectionRow.Fields.PageTitle());
        }
    }
}