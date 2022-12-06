using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(TheoryExamResultQuestionsRow))]
    public class TheoryExamResultQuestionsController : Controller
    {
        [Route("Workspace/TheoryExamResultQuestions")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/TheoryExamResultQuestions/TheoryExamResultQuestionsPage",
                TheoryExamResultQuestionsRow.Fields.PageTitle());
        }
    }
}