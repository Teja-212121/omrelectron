using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[SheetTypes]")]
    [DisplayName("Select Sheet Type"), InstanceName("Select Sheet Type")]
    [ReadPermission(PermissionKeys.SheetType.View)]
    [ModifyPermission(PermissionKeys.SheetType.Modify)]
    public sealed class SelectSheetTypeRow : LoggingRow<SelectSheetTypeRow.RowFields>, IIdRow, INameRow ,IIsActiveRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Name"), Size(100), NotNull, QuickSearch, NameProperty]
        public string Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }

        [DisplayName("Description"), Size(1000), TextAreaEditor]
        public string Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        [DisplayName("Total Questions"), NotNull]
        public int? TotalQuestions
        {
            get => fields.TotalQuestions[this];
            set => fields.TotalQuestions[this] = value;
        }

        [DisplayName("E Paper Size"), NotNull]
        public int? EPaperSize
        {
            get => fields.EPaperSize[this];
            set => fields.EPaperSize[this] = value;
        }

        [DisplayName("Height In Pixel")]
        public int? HeightInPixel
        {
            get => fields.HeightInPixel[this];
            set => fields.HeightInPixel[this] = value;
        }

        [DisplayName("Width In Pixel")]
        public int? WidthInPixel
        {
            get => fields.WidthInPixel[this];
            set => fields.WidthInPixel[this] = value;
        }

        [DisplayName("Sheet Data"), NotNull, TextAreaEditor]
        public string SheetData
        {
            get => fields.SheetData[this];
            set => fields.SheetData[this] = value;
        }

        [DisplayName("Sheet Image"), NotNull, Size(1000), ImageUploadEditor]
        public string SheetImage
        {
            get => fields.SheetImage[this];
            set => fields.SheetImage[this] = value;
        }

        [DisplayName("Overlay Image"), NotNull, Size(1000), ImageUploadEditor]
        public string OverlayImage
        {
            get => fields.OverlayImage[this];
            set => fields.OverlayImage[this] = value;
        }

        [DisplayName("Synced")]
        public bool? Synced
        {
            get => fields.Synced[this];
            set => fields.Synced[this] = value;
        }

        [DisplayName("Is Private")]
        public bool? IsPrivate
        {
            get => fields.IsPrivate[this];
            set => fields.IsPrivate[this] = value;
        }

        [DisplayName("Pdf Template"), NotNull, Size(1000), FileUploadEditor]
        public string PdfTemplate
        {
            get => fields.PdfTemplate[this];
            set => fields.PdfTemplate[this] = value;
        }

        [DisplayName("Sheet Number"), NotNull]
        public long? SheetNumber
        {
            get => fields.SheetNumber[this];
            set => fields.SheetNumber[this] = value;
        }

        [DisplayName("Is Active"), NotNull, Insertable(false), Updatable(true)]
        public short? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        Int16Field IIsActiveRow.IsActiveField
        {
            get => fields.IsActive;
        }

        public SelectSheetTypeRow()
            : base()
        {
        }

        public SelectSheetTypeRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int32Field Id;
            public StringField Name;
            public StringField Description;
            public Int32Field TotalQuestions;
            public Int32Field EPaperSize;
            public Int32Field HeightInPixel;
            public Int32Field WidthInPixel;
            public StringField SheetData;
            public StringField SheetImage;
            public StringField OverlayImage;
            public BooleanField Synced;
            public BooleanField IsPrivate;
            public StringField PdfTemplate;
            public Int64Field SheetNumber;
            public Int16Field IsActive;
        }
    }
}