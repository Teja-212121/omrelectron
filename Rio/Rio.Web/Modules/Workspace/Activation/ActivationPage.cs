using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(ActivationRow))]
    public class ActivationController : Controller
    {
        [Route("Workspace/Activation")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/Activation/ActivationPage",
                ActivationRow.Fields.PageTitle());
        }
    }
}