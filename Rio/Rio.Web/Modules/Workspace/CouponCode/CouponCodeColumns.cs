using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.CouponCode")]
    [BasedOnRow(typeof(CouponCodeRow), CheckNames = true)]
    public class CouponCodeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string Code { get; set; }
        public string ExamListName { get; set; }
        public int ValidityType { get; set; }
        public int CountType { get; set; }
        public int Count { get; set; }
        public int ValidityInDays { get; set; }
        public DateTime ValidDate { get; set; }
        public int ConsumedCount { get; set; }
        public DateTime CouponValidityDate { get; set; }
        public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public int IsActive { get; set; }
    }
}