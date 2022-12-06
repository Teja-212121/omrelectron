using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.ScannedQuestion")]
    [BasedOnRow(typeof(ScannedQuestionRow), CheckNames = true)]
    public class ScannedQuestionForm
    {
        [HalfWidth]
        public Guid ScannedBatchId { get; set; }
        [HalfWidth]
        public Guid ScannedSheetId { get; set; }
        [HalfWidth]
        public int QuestionIndex { get; set; }
        [HalfWidth]
        public long ScannedOptions { get; set; }
        [HalfWidth]
        public long CorrectedOptions { get; set; }

       /* public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public short IsActive { get; set; }
        public int TenantId { get; set; }*/
    }
}