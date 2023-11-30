using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.CouponCode")]
    [BasedOnRow(typeof(CouponCodeRow), CheckNames = true)]
    public class CouponCodeForm
    {
        [HalfWidth]
        public string Code { get; set; }
        [HalfWidth]
        public int ExamListId { get; set; }
        [HalfWidth]
        public int ValidityType { get; set; }
        [HalfWidth]
        public int CountType { get; set; }
        [HalfWidth]
        public int Count { get; set; }
        [HalfWidth]
        public int ValidityInDays { get; set; }
        [HalfWidth]
        public DateTime ValidDate { get; set; }
        [HalfWidth]
        public int ConsumedCount { get; set; }
        [HalfWidth]
        public DateTime CouponValidityDate { get; set; }
       
    }
}