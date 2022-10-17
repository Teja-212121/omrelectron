using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Administration.Pages 
{

    [PageAuthorize(typeof(TenantRow))]
    public class TenantController : Controller
    {
        [Route("Administration/Tenant")]
        public ActionResult Index()
        {
            return this.GridPage("@/Administration/Tenant/TenantPage",
                TenantRow.Fields.PageTitle());
        }
    }
}