using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(TheoryExamSectionsRow))]
    public class TheoryExamSectionsController : Controller
    {
        [Route("Workspace/TheoryExamSections")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/TheoryExamSections/TheoryExamSectionsPage",
                TheoryExamSectionsRow.Fields.PageTitle());
        }
    }
}