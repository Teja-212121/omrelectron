using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(ActivationLogRow))]
    public class ActivationLogController : Controller
    {
        [Route("Workspace/ActivationLog")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/ActivationLog/ActivationLogPage",
                ActivationLogRow.Fields.PageTitle());
        }
    }
}