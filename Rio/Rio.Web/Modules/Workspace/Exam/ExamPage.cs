using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(ExamRow))]
    public class ExamController : Controller
    {
        [Route("Workspace/Exam")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/Exam/ExamPage",
                ExamRow.Fields.PageTitle());
        }
    }
}