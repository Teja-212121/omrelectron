using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(TheoryExamsRow))]
    public class TheoryExamsController : Controller
    {
        [Route("Workspace/TheoryExams")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/TheoryExams/TheoryExamsPage",
                TheoryExamsRow.Fields.PageTitle());
        }
    }
}