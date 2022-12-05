using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(TheoryExamResultsRow))]
    public class TheoryExamResultsController : Controller
    {
        [Route("Workspace/TheoryExamResults")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/TheoryExamResults/TheoryExamResultsPage",
                TheoryExamResultsRow.Fields.PageTitle());
        }
    }
}