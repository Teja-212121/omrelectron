using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(CloudStorageProviderRow))]
    public class CloudStorageProviderController : Controller
    {
        [Route("Workspace/CloudStorageProvider")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/CloudStorageProvider/CloudStorageProviderPage",
                CloudStorageProviderRow.Fields.PageTitle());
        }
    }
}