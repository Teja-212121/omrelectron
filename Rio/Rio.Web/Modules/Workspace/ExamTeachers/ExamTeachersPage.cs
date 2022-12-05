using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(ExamTeachersRow))]
    public class ExamTeachersController : Controller
    {
        [Route("Workspace/ExamTeachers")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/ExamTeachers/ExamTeachersPage",
                ExamTeachersRow.Fields.PageTitle());
        }
    }
}