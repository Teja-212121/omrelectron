using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(CouponCodeRow))]
    public class CouponCodeController : Controller
    {
        [Route("Workspace/CouponCode")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/CouponCode/CouponCodePage",
                CouponCodeRow.Fields.PageTitle());
        }
    }
}