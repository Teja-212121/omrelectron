using Rio.Workspace.enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[SheetTypes]")]
    [DisplayName("Sheet Type"), InstanceName("Sheet Type")]
    [ReadPermission(PermissionKeys.SheetType.View)]
    [ModifyPermission(PermissionKeys.SheetType.Modify)]
    [LookupScript("Workspace.SheetTypes", Permission = "*", Expiration = 1)]
    public sealed class SheetTypeRow : LoggingRow<SheetTypeRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty, QuickSearch]
        [SortOrder(1, descending: true)]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Name"), Size(100), NotNull, QuickSearch]
        public string Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }

        [DisplayName("Sheet Type Display Name"), Size(100), QuickSearch, NameProperty]
        public string SheetTypeDisplayName
        {
            get => fields.SheetTypeDisplayName[this];
            set => fields.SheetTypeDisplayName[this] = value;
        }

        [DisplayName("Description"), Size(1000)]
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
        public EPaperSize? EPaperSize
        {
            get => (EPaperSize?)fields.EPaperSize[this];
            set => fields.EPaperSize[this] = (short?)value;
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

        [DisplayName("Sheet Data"), NotNull]
        public string SheetData
        {
            get => fields.SheetData[this];
            set => fields.SheetData[this] = value;
        }

        [DisplayName("Sheet Image"), Size(1000), ImageUploadEditor(FilenameFormat = "SheetType/SheetImage/~")]
        public string SheetImage
        {
            get => fields.SheetImage[this];
            set => fields.SheetImage[this] = value;
        }

        [DisplayName("Overlay Image"), Size(1000), ImageUploadEditor(FilenameFormat = "SheetType/OverlayImageImage/~")]
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

        [DisplayName("Is Pbulic")]
        public bool? IsPublic
        {
            get => fields.IsPrivate[this];
            set => fields.IsPrivate[this] = value;
        }

        [DisplayName("Is Private")]
        public bool? IsPrivate
        {
            get => fields.IsPrivate[this];
            set => fields.IsPrivate[this] = value;
        }

        [DisplayName("Pdf Template"), Size(1000), FileUploadEditor(FilenameFormat = "SheetType/PdfTemplate/~")]
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

        public SheetTypeRow()
            : base()
        {
        }

        public SheetTypeRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int32Field Id;
            public StringField Name;
            public StringField SheetTypeDisplayName;
            public StringField Description;
            public Int32Field TotalQuestions;
            public Int32Field EPaperSize;
            public Int32Field HeightInPixel;
            public Int32Field WidthInPixel;
            public StringField SheetData;
            public StringField SheetImage;
            public StringField OverlayImage;
            public BooleanField Synced;
            public BooleanField IsPublic;
            public BooleanField IsPrivate;
            public StringField PdfTemplate;
            public Int64Field SheetNumber;
            public Int16Field IsActive;
        }
    }
}