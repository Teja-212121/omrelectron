
using Rio.Workspace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Rio.Web.Modules.Workspace.CommonController.Models
{
    public class SectionReportModel
    {    
            public List<ExamSectionResultRow> ExamSectionResultList { get; set; }
            public ExamResultRow ExamResult { get; set; }
            public List<int> ExamSectionCount { get; set;}       
    }

   
}
