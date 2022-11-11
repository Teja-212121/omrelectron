using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.ExamGroupWiseResult")]
    [BasedOnRow(typeof(ExamGroupWiseResultRow), CheckNames = true)]
    public class ExamGroupWiseResultForm
    {
        [HalfWidth]
        public long StudentId { get; set; }
        [HalfWidth]
        public long RollNumber { get; set; }
        [HalfWidth]
        public string SheetNumber { get; set; }
        [HalfWidth]
        public Guid SheetGuid { get; set; }
        [HalfWidth]
        public long ExamId { get; set; }
        [HalfWidth]
        public int Rank { get; set; }
        [HalfWidth]
        public int GroupId { get; set; }
        
    }
}