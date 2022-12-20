using Rio.Workspace.enums;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.SheetType")]
    [BasedOnRow(typeof(SheetTypeRow), CheckNames = true)]
    public class SheetTypeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalQuestions { get; set; }
        public EPaperSize EPaperSize { get; set; }
        public int HeightInPixel { get; set; }
        public int WidthInPixel { get; set; }
        public string SheetData { get; set; }
        public string SheetImage { get; set; }
        public string OverlayImage { get; set; }
        public bool Synced { get; set; }
        public bool IsPublic { get; set; }
        public bool IsPrivate { get; set; }
        public string PdfTemplate { get; set; }
        public long SheetNumber { get; set; }
        /*public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public short IsActive { get; set; }*/
    }
}