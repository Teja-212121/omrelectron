using Rio.Web.Enums;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.TheoryExamResults")]
    [BasedOnRow(typeof(TheoryExamResultsRow), CheckNames = true)]
    public class TheoryExamResultsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public long Id { get; set; }
        [QuickFilter,FilterOnly]
        public long TheoryExamId { get; set; }
        public string TheoryExamCode { get; set; }
        [EditLink]
        public string StudentScanId { get; set; }
        public float MarksScored { get; set; }
        public float OutOfMarks { get; set; }
        public EResultSyncStatus ResultStatus { get; set; }
        public string RollNumber { get; set; }
        public string SheetImage { get; set; }
        public string StudentFirstName { get; set; }
        public DateTime AttemptDate { get; set; }
        [QuickFilter]
        [DisplayName("Insert Date")]
        public DateTime InsertDate { get; set; }

    }
}