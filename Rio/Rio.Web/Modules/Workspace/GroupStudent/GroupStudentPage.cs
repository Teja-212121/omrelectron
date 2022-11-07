using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(GroupStudentRow))]
    public class GroupStudentController : Controller
    {
        [Route("Workspace/GroupStudent")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/GroupStudent/GroupStudentPage",
                GroupStudentRow.Fields.PageTitle());
        }
    }
}