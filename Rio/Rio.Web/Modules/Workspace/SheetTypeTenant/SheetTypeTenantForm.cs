using Rio.Workspace.enums;
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
        [TextAreaEditor(Rows = 3)]
        public string SheetTypeDescription { get; set; }
        [HalfWidth]
        public int SheetTypeTotalQuestions { get; set; }
        [HalfWidth]
        public EPaperSize SheetTypeEPaperSize { get; set; }
        [HalfWidth]
        public int SheetTypeHeightInPixel { get; set; }
        [HalfWidth]
        public int SheetTypeWidthInPixel { get; set; }
        [TextAreaEditor(Rows = 5)]
        public string SheetTypeSheetData { get; set; }
        [HalfWidth]
        public string SheetTypeSheetImage { get; set; }
        [HalfWidth]
        public string SheetTypeOverlayImage { get; set; }
        [QuarterWidth]
        public bool SheetTypeSynced { get; set; }
        [QuarterWidth]
        public bool SheetTypeIsPrivate { get; set; }
        [HalfWidth]
        public string SheetTypePdfTemplate { get; set; }
        [HalfWidth]
        public long SheetTypeSheetNumber { get; set; }
       
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