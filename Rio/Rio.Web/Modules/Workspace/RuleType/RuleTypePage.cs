using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(RuleTypeRow))]
    public class RuleTypeController : Controller
    {
        [Route("Workspace/RuleType")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/RuleType/RuleTypePage",
                RuleTypeRow.Fields.PageTitle());
        }
    }
}