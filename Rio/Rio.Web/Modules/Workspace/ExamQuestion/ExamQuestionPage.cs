using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Rio.Workspace.Pages 
{

    [PageAuthorize(typeof(ExamQuestionRow))]
    public class ExamQuestionController : Controller
    {
        [Route("Workspace/ExamQuestion")]
        public ActionResult Index()
        {
            return this.GridPage("@/Workspace/ExamQuestion/ExamQuestionPage",
                ExamQuestionRow.Fields.PageTitle());
        }

        [Route("Workspace/ExamQuestion/ExamQuestionSample")]
        public FileContentResult DownloadExamQuestionSample()
        {
            string filePath = "Uploads/ExamQuestionSample.xls";
            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
            return new FileContentResult(fileBytes, "application/vnd.ms-excel");
        }
    }
}