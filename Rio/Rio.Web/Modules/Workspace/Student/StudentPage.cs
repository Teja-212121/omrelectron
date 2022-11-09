using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(StudentRow))]
    public class StudentController : Controller
    {
        [Route("Workspace/Student")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/Student/StudentPage",
                StudentRow.Fields.PageTitle());
        }

        [Route("Workspace/Student/StudentSample")]
        public FileContentResult DownloadStudentSample()
        {
            string filePath = "Uploads/StudentSample.xls";
            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
            return new FileContentResult(fileBytes, "application/vnd.ms-excel");
        }
    }
}