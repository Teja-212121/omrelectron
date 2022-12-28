using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(GetScanDataRow))]
    public class GetScanDataController : Controller
    {
        [Route("Workspace/GetScanData")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/GetScanData/GetScanDataPage",
                GetScanDataRow.Fields.PageTitle());
        }
    }
}