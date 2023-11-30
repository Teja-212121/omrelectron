using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(ExamListExamsRow))]
    public class ExamListExamsController : Controller
    {
        [Route("Workspace/ExamListExams")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/ExamListExams/ExamListExamsPage",
                ExamListExamsRow.Fields.PageTitle());
        }
    }
}