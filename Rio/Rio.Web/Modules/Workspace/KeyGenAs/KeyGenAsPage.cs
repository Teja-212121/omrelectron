using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(KeyGenAsRow))]
    public class KeyGenAsController : Controller
    {
        [Route("Workspace/KeyGenAs")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/KeyGenAs/KeyGenAsPage",
                KeyGenAsRow.Fields.PageTitle());
        }
    }
}