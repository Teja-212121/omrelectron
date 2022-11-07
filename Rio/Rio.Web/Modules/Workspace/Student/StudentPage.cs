using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(StudentRow))]
    public class StudentController : Controller
    {
        [Route("Workspace/Student")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/Student/StudentPage",
                StudentRow.Fields.PageTitle());
        }
    }
}