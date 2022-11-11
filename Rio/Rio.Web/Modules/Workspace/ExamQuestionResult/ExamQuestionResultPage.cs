using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(ExamQuestionResultRow))]
    public class ExamQuestionResultController : Controller
    {
        [Route("Workspace/ExamQuestionResult")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/ExamQuestionResult/ExamQuestionResultPage",
                ExamQuestionResultRow.Fields.PageTitle());
        }
    }
}