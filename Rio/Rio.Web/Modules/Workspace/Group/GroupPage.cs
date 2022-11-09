using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(GroupRow))]
    public class GroupController : Controller
    {
        [Route("Workspace/Group")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/Group/GroupPage",
                GroupRow.Fields.PageTitle());
        }
    }
}