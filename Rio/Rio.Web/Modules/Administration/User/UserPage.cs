using Microsoft.AspNetCore.Mvc;
using Serenity.Web;
using StackExchange.Exceptional;
using System.Threading.Tasks;

namespace Rio.Administration.Pages
{
    [PageAuthorize(typeof(UserRow))]
    public class UserController : Controller
    {
        [Route("Administration/User")]
        public ActionResult Index()
        {
            return this.GridPage("@/Administration/User/UserPage",
                UserRow.Fields.PageTitle());
        }

        [Route("Administration/ExceptionLog/{*pathInfo}"), IgnoreAntiforgeryToken]
        public async Task ExceptionLog()
        {
            await ExceptionalMiddleware.HandleRequestAsync(HttpContext).ConfigureAwait(false);
        }
    }
}