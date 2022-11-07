using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(SheetTypeTenantRow))]
    public class SheetTypeTenantController : Controller
    {
        [Route("Workspace/SheetTypeTenant")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/SheetTypeTenant/SheetTypeTenantPage",
                SheetTypeTenantRow.Fields.PageTitle());
        }
    }
}