using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(CloudStorageSettingRow))]
    public class CloudStorageSettingController : Controller
    {
        [Route("Workspace/CloudStorageSetting")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/CloudStorageSetting/CloudStorageSettingPage",
                CloudStorageSettingRow.Fields.PageTitle());
        }
    }
}