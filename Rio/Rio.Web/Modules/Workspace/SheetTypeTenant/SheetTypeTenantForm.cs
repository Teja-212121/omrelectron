using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.SheetTypeTenant")]
    [BasedOnRow(typeof(SheetTypeTenantRow), CheckNames = true)]
    public class SheetTypeTenantForm
    {
        [HalfWidth]
        public int SheetTypeId { get; set; }
        [HalfWidth]
        public bool IsDefault { get; set; }
        public string SheetDesignPdf { get; set; }
       
        //[HalfWidth]
        //public int TenantId { get; set; }
        // public float DisplayOrder { get; set; }
        /*public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public short IsActive { get; set; }*/
    }
}