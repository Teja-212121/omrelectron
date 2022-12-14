using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(ScannedBatchAsPerDateRow))]
    public class ScannedBatchAsPerDateController : Controller
    {
        [Route("Workspace/ScannedBatchAsPerDate")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/ScannedBatchAsPerDate/ScannedBatchAsPerDatePage",
                ScannedBatchAsPerDateRow.Fields.PageTitle());
        }
    }
}