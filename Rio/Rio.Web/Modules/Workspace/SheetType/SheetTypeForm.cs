using Rio.Workspace.enums;
using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.SheetType")]
    [BasedOnRow(typeof(SheetTypeRow), CheckNames = true)]
    public class SheetTypeForm
    {
        [HalfWidth]
        public string Name { get; set; }
        [TextAreaEditor(Rows =5)]
        public string Description { get; set; }
        [HalfWidth]
        public int TotalQuestions { get; set; }
        [HalfWidth]
        public EPaperSize EPaperSize { get; set; }
        [HalfWidth]
        public int HeightInPixel { get; set; }
        [HalfWidth]
        public int WidthInPixel { get; set; }
        [TextAreaEditor(Rows =5)]
        public string SheetData { get; set; }
        [HalfWidth]
        public string SheetImage { get; set; }
        [HalfWidth]
        public string OverlayImage { get; set; }
        [QuarterWidth]
        public bool Synced { get; set; }
/*        [QuarterWidth]
        public bool IsPublic { get; set; }*/
        [QuarterWidth]
        public bool IsPrivate { get; set; }
        [HalfWidth]
        public long SheetNumber { get; set; }
        public string PdfTemplate { get; set; }

        
        /*public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public short IsActive { get; set; }*/
    }
}