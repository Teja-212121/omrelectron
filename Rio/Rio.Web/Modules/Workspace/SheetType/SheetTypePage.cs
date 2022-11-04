using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(SheetTypeRow))]
    public class SheetTypeController : Controller
    {
        [Route("Workspace/SheetType")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/SheetType/SheetTypePage",
                SheetTypeRow.Fields.PageTitle());
        }
    }
}