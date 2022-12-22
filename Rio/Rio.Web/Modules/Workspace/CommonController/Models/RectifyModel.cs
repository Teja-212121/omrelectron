
using Rio.Workspace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Rio.Web.Modules.Workspace.CommonController.Models
{
    public class RectifyModel
    {
      
        public class ScannedQuestionDatamodel
        {
          public List<ScannedQuestionRow> ScanQuestionList { get; set; }
        }
       
    }

    public class ScanBatchModel
    {
        public string ScannedSheetId { get; set; }

    }
}
