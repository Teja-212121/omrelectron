using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(TheoryExamQuestionsRow))]
    public class TheoryExamQuestionsController : Controller
    {
        [Route("Workspace/TheoryExamQuestions")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/TheoryExamQuestions/TheoryExamQuestionsPage",
                TheoryExamQuestionsRow.Fields.PageTitle());
        }
    }
}