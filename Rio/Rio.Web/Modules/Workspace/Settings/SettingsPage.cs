using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(SettingsRow))]
    public class SettingsController : Controller
    {
        [Route("Workspace/Settings")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/Settings/SettingsPage",
                SettingsRow.Fields.PageTitle());
        }
    }
}