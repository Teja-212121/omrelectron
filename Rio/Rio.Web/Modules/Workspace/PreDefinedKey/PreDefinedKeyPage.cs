using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(PreDefinedKeyRow))]
    public class PreDefinedKeyController : Controller
    {
        [Route("Workspace/PreDefinedKey")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/PreDefinedKey/PreDefinedKeyPage",
                PreDefinedKeyRow.Fields.PageTitle());
        }
    }
}