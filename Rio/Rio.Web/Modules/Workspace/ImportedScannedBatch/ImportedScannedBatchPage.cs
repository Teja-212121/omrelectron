using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(ImportedScannedBatchRow))]
    public class ImportedScannedBatchController : Controller
    {
        [Route("Workspace/ImportedScannedBatch")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/ImportedScannedBatch/ImportedScannedBatchPage",
                ImportedScannedBatchRow.Fields.PageTitle());
        }

        [Route("Workspace/ImportedScannedBatch/ImportedScannedBatchSample")]
        public FileContentResult DownloadImportedScannedBatchSample()
        {
            string filePath = "Uploads/ImportedScannedBatchSample.xls";
            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
            return new FileContentResult(fileBytes, "application/vnd.ms-excel");
        }
    }
}