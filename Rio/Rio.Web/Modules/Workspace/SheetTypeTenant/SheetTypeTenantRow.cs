using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[dbo].[SheetTypesTenants]")]
    [DisplayName("My Sheet Types"), InstanceName("My Sheet Types")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class SheetTypeTenantRow : LoggingRow<SheetTypeTenantRow.RowFields>, IIdRow, INameRow, IMultiTenantRow,IIsActiveRow
    {
        [DisplayName("Id"), Identity, IdProperty,QuickSearch]
        [SortOrder(1,descending:true)]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Sheet Type"), NotNull, ForeignKey("[dbo].[SheetTypes]", "Id"), LeftJoin("jSheetType"), TextualField("SheetTypeName")]
        [LookupEditor("Workspace.SheetTypes")]
        public int? SheetTypeId
        {
            get => fields.SheetTypeId[this];
            set => fields.SheetTypeId[this] = value;
        }

        [DisplayName("Tenant"), NotNull, ForeignKey("[dbo].[Tenants]", "TenantId"), LeftJoin("jTenant"), TextualField("TenantTenantName")]
        [Insertable(false), Updatable(false)]
        public int? TenantId
        {
            get => fields.TenantId[this];
            set => fields.TenantId[this] = value;
        }

        [DisplayName("Is Default"), NotNull]
        public bool? IsDefault
        {
            get => fields.IsDefault[this];
            set => fields.IsDefault[this] = value;
        }

        [DisplayName("Display Order")]
        public float? DisplayOrder
        {
            get => fields.DisplayOrder[this];
            set => fields.DisplayOrder[this] = value;
        }


        [DisplayName("Sheet Design Pdf"), Size(2000), QuickSearch, NameProperty, FileUploadEditor(FilenameFormat = "SheetType/PdfTemplate/~")]
        public string SheetDesignPdf
        {
            get => fields.SheetDesignPdf[this];
            set => fields.SheetDesignPdf[this] = value;
        }

        [DisplayName("Is Active"), NotNull,Insertable(false),Updatable(true
            )]
        public short? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        [DisplayName("Sheet Type Name"), Expression("jSheetType.[Name]"),QuickSearch]
        public string SheetTypeName
        {
            get => fields.SheetTypeName[this];
            set => fields.SheetTypeName[this] = value;
        }

        [DisplayName("Sheet Type Description"), Expression("jSheetType.[Description]")]
        public string SheetTypeDescription
        {
            get => fields.SheetTypeDescription[this];
            set => fields.SheetTypeDescription[this] = value;
        }

        [DisplayName(" Total Questions"), Expression("jSheetType.[TotalQuestions]")]
        public int? SheetTypeTotalQuestions
        {
            get => fields.SheetTypeTotalQuestions[this];
            set => fields.SheetTypeTotalQuestions[this] = value;
        }

        [DisplayName("Sheet Type E Paper Size"), Expression("jSheetType.[EPaperSize]")]
        public int? SheetTypeEPaperSize
        {
            get => fields.SheetTypeEPaperSize[this];
            set => fields.SheetTypeEPaperSize[this] = value;
        }

        [DisplayName("Sheet Type Height In Pixel"), Expression("jSheetType.[HeightInPixel]")]
        public int? SheetTypeHeightInPixel
        {
            get => fields.SheetTypeHeightInPixel[this];
            set => fields.SheetTypeHeightInPixel[this] = value;
        }

        [DisplayName("Sheet Type Width In Pixel"), Expression("jSheetType.[WidthInPixel]")]
        public int? SheetTypeWidthInPixel
        {
            get => fields.SheetTypeWidthInPixel[this];
            set => fields.SheetTypeWidthInPixel[this] = value;
        }

        [DisplayName("Sheet Type Sheet Data"), Expression("jSheetType.[SheetData]")]
        public string SheetTypeSheetData
        {
            get => fields.SheetTypeSheetData[this];
            set => fields.SheetTypeSheetData[this] = value;
        }

        [DisplayName("Sheet Type Sheet Image"), Expression("jSheetType.[SheetImage]")]
        public string SheetTypeSheetImage
        {
            get => fields.SheetTypeSheetImage[this];
            set => fields.SheetTypeSheetImage[this] = value;
        }

        [DisplayName("Sheet Type Overlay Image"), Expression("jSheetType.[OverlayImage]")]
        public string SheetTypeOverlayImage
        {
            get => fields.SheetTypeOverlayImage[this];
            set => fields.SheetTypeOverlayImage[this] = value;
        }

        [DisplayName("Sheet Type Synced"), Expression("jSheetType.[Synced]")]
        public bool? SheetTypeSynced
        {
            get => fields.SheetTypeSynced[this];
            set => fields.SheetTypeSynced[this] = value;
        }

        [DisplayName("Sheet Type Is Private"), Expression("jSheetType.[IsPrivate]")]
        public bool? SheetTypeIsPrivate
        {
            get => fields.SheetTypeIsPrivate[this];
            set => fields.SheetTypeIsPrivate[this] = value;
        }

        [DisplayName("Sheet Type Pdf Template"), Expression("jSheetType.[PdfTemplate]")]
        public string SheetTypePdfTemplate
        {
            get => fields.SheetTypePdfTemplate[this];
            set => fields.SheetTypePdfTemplate[this] = value;
        }

        [DisplayName("Sheet Type Sheet Number"), Expression("jSheetType.[SheetNumber]")]
        public long? SheetTypeSheetNumber
        {
            get => fields.SheetTypeSheetNumber[this];
            set => fields.SheetTypeSheetNumber[this] = value;
        }

        [DisplayName("Sheet Type Insert Date"), Expression("jSheetType.[InsertDate]")]
        public DateTime? SheetTypeInsertDate
        {
            get => fields.SheetTypeInsertDate[this];
            set => fields.SheetTypeInsertDate[this] = value;
        }

        [DisplayName("Sheet Type Insert User Id"), Expression("jSheetType.[InsertUserId]")]
        public int? SheetTypeInsertUserId
        {
            get => fields.SheetTypeInsertUserId[this];
            set => fields.SheetTypeInsertUserId[this] = value;
        }

        [DisplayName("Sheet Type Update Date"), Expression("jSheetType.[UpdateDate]")]
        public DateTime? SheetTypeUpdateDate
        {
            get => fields.SheetTypeUpdateDate[this];
            set => fields.SheetTypeUpdateDate[this] = value;
        }

        [DisplayName("Sheet Type Update User Id"), Expression("jSheetType.[UpdateUserId]")]
        public int? SheetTypeUpdateUserId
        {
            get => fields.SheetTypeUpdateUserId[this];
            set => fields.SheetTypeUpdateUserId[this] = value;
        }

        [DisplayName("Sheet Type Is Active"), Expression("jSheetType.[IsActive]")]
        public short? SheetTypeIsActive
        {
            get => fields.SheetTypeIsActive[this];
            set => fields.SheetTypeIsActive[this] = value;
        }

        [DisplayName("Tenant  Name"), Expression("jTenant.[TenantName]")]
        public string TenantTenantName
        {
            get => fields.TenantTenantName[this];
            set => fields.TenantTenantName[this] = value;
        }
        public Int32Field TenantIdField
        {
            get => Fields.TenantId;
        }
        Int16Field IIsActiveRow.IsActiveField
        {
            get => fields.IsActive;
        }
        public SheetTypeTenantRow()
            : base()
        {
        }

        public SheetTypeTenantRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int32Field Id;
            public Int32Field SheetTypeId;
            public Int32Field TenantId;
            public BooleanField IsDefault;
            public SingleField DisplayOrder;
            public StringField SheetDesignPdf;
            public Int16Field IsActive;

            public StringField SheetTypeName;
            public StringField SheetTypeDescription;
            public Int32Field SheetTypeTotalQuestions;
            public Int32Field SheetTypeEPaperSize;
            public Int32Field SheetTypeHeightInPixel;
            public Int32Field SheetTypeWidthInPixel;
            public StringField SheetTypeSheetData;
            public StringField SheetTypeSheetImage;
            public StringField SheetTypeOverlayImage;
            public BooleanField SheetTypeSynced;
            public BooleanField SheetTypeIsPrivate;
            public StringField SheetTypePdfTemplate;
            public Int64Field SheetTypeSheetNumber;
            public DateTimeField SheetTypeInsertDate;
            public Int32Field SheetTypeInsertUserId;
            public DateTimeField SheetTypeUpdateDate;
            public Int32Field SheetTypeUpdateUserId;
            public Int16Field SheetTypeIsActive;

            public StringField TenantTenantName;
        }
    }
}