using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.SelectSheetType")]
    [BasedOnRow(typeof(SelectSheetTypeRow), CheckNames = true)]
    public class SelectSheetTypeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalQuestions { get; set; }
        public int EPaperSize { get; set; }
        public int HeightInPixel { get; set; }
        public int WidthInPixel { get; set; }
        public string SheetData { get; set; }
        public string SheetImage { get; set; }
        public string OverlayImage { get; set; }
        public bool Synced { get; set; }
        public bool IsPrivate { get; set; }
        public string PdfTemplate { get; set; }
        public long SheetNumber { get; set; }
    }
}