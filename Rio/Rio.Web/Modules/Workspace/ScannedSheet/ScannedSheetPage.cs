using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(ScannedSheetRow))]
    public class ScannedSheetController : Controller
    {
        [Route("Workspace/ScannedSheet")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/ScannedSheet/ScannedSheetPage",
                ScannedSheetRow.Fields.PageTitle());
        }
    }
}