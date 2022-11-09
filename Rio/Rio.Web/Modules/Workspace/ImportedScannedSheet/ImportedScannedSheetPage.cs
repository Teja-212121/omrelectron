using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(ImportedScannedSheetRow))]
    public class ImportedScannedSheetController : Controller
    {
        [Route("Workspace/ImportedScannedSheet")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/ImportedScannedSheet/ImportedScannedSheetPage",
                ImportedScannedSheetRow.Fields.PageTitle());
        }
    }
}