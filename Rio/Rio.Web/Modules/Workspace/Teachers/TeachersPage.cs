using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(TeachersRow))]
    public class TeachersController : Controller
    {
        [Route("Workspace/Teachers")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/Teachers/TeachersPage",
                TeachersRow.Fields.PageTitle());
        }
    }
}