using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(ScannedQuestionRow))]
    public class ScannedQuestionController : Controller
    {
        [Route("Workspace/ScannedQuestion")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/ScannedQuestion/ScannedQuestionPage",
                ScannedQuestionRow.Fields.PageTitle());
        }
    }
}