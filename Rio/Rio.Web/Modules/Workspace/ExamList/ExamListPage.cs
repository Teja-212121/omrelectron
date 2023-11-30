using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(ExamListRow))]
    public class ExamListController : Controller
    {
        [Route("Workspace/ExamList")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/ExamList/ExamListPage",
                ExamListRow.Fields.PageTitle());
        }
    }
}