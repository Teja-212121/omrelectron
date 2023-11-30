using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(SerialKeyRow))]
    public class SerialKeyController : Controller
    {
        [Route("Workspace/SerialKey")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/SerialKey/SerialKeyPage",
                SerialKeyRow.Fields.PageTitle());
        }
    }
}