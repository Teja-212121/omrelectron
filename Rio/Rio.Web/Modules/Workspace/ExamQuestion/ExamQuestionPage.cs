using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(ExamQuestionRow))]
    public class ExamQuestionController : Controller
    {
        [Route("Workspace/ExamQuestion")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/ExamQuestion/ExamQuestionPage",
                ExamQuestionRow.Fields.PageTitle());
        }
    }
}