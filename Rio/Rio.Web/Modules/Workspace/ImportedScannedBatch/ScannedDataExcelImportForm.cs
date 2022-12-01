using Serenity.ComponentModel;
using Serenity.Web;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Forms
{
    [FormScript("Rio.ScannedDataExcelImportForm")]
    public class ScannedDataExcelImportForm
    {
        [DisplayName("Exam")]
        [LookupEditor("Workspace.Exam"), Required]
        public int ExamId { get; set; }
        [DisplayName("Tenant")]
        [LookupEditor("Administration.Tenant"), Required]
        public int TenantId { get; set; }
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}