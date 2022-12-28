using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.GetScanData")]
    [BasedOnRow(typeof(GetScanDataRow), CheckNames = true)]
    public class GetScanDataColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public decimal NegativeMarks { get; set; }
        public int QuestionIndex { get; set; }
        public int TenantId { get; set; }
        public Guid ScanSheetId { get; set; }
        public Guid ScanBatchId { get; set; }
        public decimal Score { get; set; }
        public int CorrectedRollNo { get; set; }
        [EditLink]
        public string SheetNumber { get; set; }
        public int RightOptions { get; set; }
        public int CorrectedOptions { get; set; }
        public int RuleTypeId { get; set; }
    }
}