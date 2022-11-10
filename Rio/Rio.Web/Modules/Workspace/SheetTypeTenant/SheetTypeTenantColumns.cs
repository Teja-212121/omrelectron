using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.SheetTypeTenant")]
    [BasedOnRow(typeof(SheetTypeTenantRow), CheckNames = true)]
    public class SheetTypeTenantColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        public string SheetTypeName { get; set; }
        public string TenantTenantName { get; set; }
        public int SheetTypeTotalQuestions { get; set; }
        public int SheetTypeEPaperSize { get; set; }
        public int SheetTypeHeightInPixel { get; set; }
        public int SheetTypeWidthInPixel { get; set; }
        public String SheetTypeSheetData { get; set; }
        public String SheetTypeSheetImage { get; set; }
        public String SheetTypeOverlayImage { get; set; }
        public int SheetTypeIsPrivate { get; set; }
        [EditLink]
        public string SheetDesignPdf { get; set; }
        [DisplayName("Date")]
        [QuickFilter]
        public DateTime InsertDate { get; set; }
        [QuickFilter]
        public int TenantId { get; set; }

        // public float DisplayOrder { get; set; }
        //  public bool IsDefault { get; set; }

        /* public DateTime InsertDate { get; set; }
         public int InsertUserId { get; set; }
         public DateTime UpdateDate { get; set; }
         public int UpdateUserId { get; set; }
         public short IsActive { get; set; }*/
    }
}