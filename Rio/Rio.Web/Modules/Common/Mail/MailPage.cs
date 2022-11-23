using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Common.Pages 
{

    [PageAuthorize(typeof(MailRow))]
    public class MailController : Controller
    {
        [Route("Common/Mail")]
        public ActionResult Index()
        {
            return this.GridPage("@/Common/Mail/MailPage",
                MailRow.Fields.PageTitle());
        }
    }
}