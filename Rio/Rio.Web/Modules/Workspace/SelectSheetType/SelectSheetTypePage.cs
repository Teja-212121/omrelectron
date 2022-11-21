using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(SelectSheetTypeRow))]
    public class SelectSheetTypeController : Controller
    {
        [Route("Workspace/SelectSheetType")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/SelectSheetType/SelectSheetTypePage",
                SelectSheetTypeRow.Fields.PageTitle());
        }
    }
}