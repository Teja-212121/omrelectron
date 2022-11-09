using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(ImportedScannedQuestionRow))]
    public class ImportedScannedQuestionController : Controller
    {
        [Route("Workspace/ImportedScannedQuestion")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/ImportedScannedQuestion/ImportedScannedQuestionPage",
                ImportedScannedQuestionRow.Fields.PageTitle());
        }
    }
}