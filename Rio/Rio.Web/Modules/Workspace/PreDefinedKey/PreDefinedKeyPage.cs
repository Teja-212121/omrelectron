using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(PreDefinedKeyRow))]
    public class PreDefinedKeyController : Controller
    {
        [Route("Workspace/PreDefinedKey")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/PreDefinedKey/PreDefinedKeyPage",
                PreDefinedKeyRow.Fields.PageTitle());
        }

        [Route("Workspace/PreDefinedKey/PreDefinedKeySample")]
        public FileContentResult DownloadPreDefinedKeySample()
        {
            string filePath = "Uploads/PreDefinedKeySample.xls";
            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
            return new FileContentResult(fileBytes, "application/vnd.ms-excel");
        }
    }
}