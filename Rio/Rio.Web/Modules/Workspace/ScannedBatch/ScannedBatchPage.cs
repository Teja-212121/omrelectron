using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(ScannedBatchRow))]
    public class ScannedBatchController : Controller
    {
        [Route("Workspace/ScannedBatch")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/ScannedBatch/ScannedBatchPage",
                ScannedBatchRow.Fields.PageTitle());
        }
    }
}