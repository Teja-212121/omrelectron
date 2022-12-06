using Rio.Workspace.enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[ImportedScannedSheets]")]
    [DisplayName("Imported Scanned Sheet"), InstanceName("Imported Scanned Sheet")]
    [ReadPermission(PermissionKeys.ImportedDataManagement.View)]
    [ModifyPermission(PermissionKeys.ImportedDataManagement.Modify)]
    [LookupScript("Workspace.ImportedScannedSheets", Permission = "*", LookupType = typeof(MultiTenantRowLookupScript<>))]
    public sealed class ImportedScannedSheetRow : LoggingRow<ImportedScannedSheetRow.RowFields>, IIdRow, INameRow,IMultiTenantRow,IIsActiveRow
    {
        [DisplayName("Id"), PrimaryKey, NotNull, IdProperty,Insertable(false),Updatable(false), LookupInclude]
        [SortOrder(1, descending: true)]
        public Guid? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Sheet Type"), NotNull, ForeignKey("[SheetTypes]", "Id"), LeftJoin("jSheetType"), TextualField("SheetTypeName")]
        [LookupEditor("Workspace.SheetTypes")]
        public int? SheetTypeId
        {
            get => fields.SheetTypeId[this];
            set => fields.SheetTypeId[this] = value;
        }

        [DisplayName("Scanned At")]
        public DateTime? ScannedAt
        {
            get => fields.ScannedAt[this];
            set => fields.ScannedAt[this] = value;
        }

        [DisplayName("Sheet Number"), Size(50), QuickSearch, NameProperty]
        public string SheetNumber
        {
            get => fields.SheetNumber[this];
            set => fields.SheetNumber[this] = value;
        }


        [DisplayName("Scanned Roll No")]
        public long? ScannedRollNo
        {
            get => fields.ScannedRollNo[this];
            set => fields.ScannedRollNo[this] = value;
        }

        [DisplayName("Scanned Exam No")]
        public long? ScannedExamNo
        {
            get => fields.ScannedExamNo[this];
            set => fields.ScannedExamNo[this] = value;
        }

        [DisplayName("Corrected Roll No")]
        public long? CorrectedRollNo
        {
            get => fields.CorrectedRollNo[this];
            set => fields.CorrectedRollNo[this] = value;
        }

        [DisplayName("Corrected Exam No")]
        public long? CorrectedExamNo
        {
            get => fields.CorrectedExamNo[this];
            set => fields.CorrectedExamNo[this] = value;
        }

        [DisplayName("Exam Set No")]
        public int? ExamSetNo
        {
            get => fields.ExamSetNo[this];
            set => fields.ExamSetNo[this] = value;
        }

        [DisplayName("Scanned Image Source Path"), Size(2000)]
        public string ScannedImageSourcePath
        {
            get => fields.ScannedImageSourcePath[this];
            set => fields.ScannedImageSourcePath[this] = value;
        }

        [DisplayName("Scanned Image"), Size(2000)]
        public string ScannedImage
        {
            get => fields.ScannedImage[this];
            set => fields.ScannedImage[this] = value;
        }

        [DisplayName("Scanned Batch"), NotNull, ForeignKey("[ImportedScannedBatches]", "Id"), LeftJoin("jScannedBatch"), TextualField("ScannedBatchName"), LookupInclude]
        [LookupEditor("Workspace.ImportedScannedBatches")]
        public Guid? ScannedBatchId
        {
            get => fields.ScannedBatchId[this];
            set => fields.ScannedBatchId[this] = value;
        }

        [DisplayName("Scanned Status")]
        public EScannedStatus? ScannedStatus
        {
            get => (EScannedStatus?)fields.ScannedStatus[this];
            set => fields.ScannedStatus[this] = (short?)value;
        }

       [DisplayName("Scanned System Errors"), Size(1000)]
        public string ScannedSystemErrors
        {
            get => fields.ScannedSystemErrors[this];
            set => fields.ScannedSystemErrors[this] = value;
        }

        [DisplayName("Scanned User Errors"), Size(1000)]
        public string ScannedUserErrors
        {
            get => fields.ScannedUserErrors[this];
            set => fields.ScannedUserErrors[this] = value;
        }

        [DisplayName("Scanned Comments"), Size(1000)]
        public string ScannedComments
        {
            get => fields.ScannedComments[this];
            set => fields.ScannedComments[this] = value;
        }

        [DisplayName("Result Processed")]
        public bool? ResultProcessed
        {
            get => fields.ResultProcessed[this];
            set => fields.ResultProcessed[this] = value;
        }

       

        [DisplayName("Is Active"), NotNull,Insertable(false),Updatable(false)]
        public short? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        [DisplayName("Tenant Id"), NotNull, Insertable(false), Updatable(false)]
        public int? TenantId
        {
            get => fields.TenantId[this];
            set => fields.TenantId[this] = value;
        }

        [DisplayName("OCR Data 1 Key")]
        public string OCRData1Key
        {
            get => fields.OCRData1Key[this];
            set => fields.OCRData1Key[this] = value;
        }

        [DisplayName("OCR Data 1 Value")]
        public string OCRData1Value
        {
            get => fields.OCRData1Value[this];
            set => fields.OCRData1Value[this] = value;
        }

        [DisplayName("OCR Data 2 Key")]
        public string OCRData2Key
        {
            get => fields.OCRData2Key[this];
            set => fields.OCRData2Key[this] = value;
        }

        [DisplayName("OCR Data 2 Value")]
        public string OCRData2Value
        {
            get => fields.OCRData2Value[this];
            set => fields.OCRData2Value[this] = value;
        }

        [DisplayName("OCR Data 3 Key")]
        public string OCRData3Key
        {
            get => fields.OCRData3Key[this];
            set => fields.OCRData3Key[this] = value;
        }

        [DisplayName("OCR Data 3 Value")]
        public string OCRData3Value
        {
            get => fields.OCRData3Value[this];
            set => fields.OCRData3Value[this] = value;
        }

        [DisplayName("ICR Data 1 Key")]
        public string ICRData1Key
        {
            get => fields.ICRData1Key[this];
            set => fields.ICRData1Key[this] = value;
        }

        [DisplayName("ICR Data 1 Value")]
        public string ICRData1Value
        {
            get => fields.ICRData1Value[this];
            set => fields.ICRData1Value[this] = value;
        }

        [DisplayName("ICR Data 2 Key")]
        public string ICRData2Key
        {
            get => fields.ICRData2Key[this];
            set => fields.ICRData2Key[this] = value;
        }

        [DisplayName("ICR Data 2 Value")]
        public string ICRData2Value
        {
            get => fields.ICRData2Value[this];
            set => fields.ICRData2Value[this] = value;
        }

        [DisplayName("ICR Data 3 Key")]
        public string ICRData3Key
        {
            get => fields.ICRData3Key[this];
            set => fields.ICRData3Key[this] = value;
        }

        [DisplayName("ICR Data 3 Value")]
        public string ICRData3Value
        {
            get => fields.ICRData3Value[this];
            set => fields.ICRData3Value[this] = value;
        }

        [DisplayName("Sheet Type Name"), Expression("jSheetType.[Name]")]
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

        [DisplayName("Sheet Type Total Questions"), Expression("jSheetType.[TotalQuestions]")]
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

        [DisplayName("Scanned Batch Name"), Expression("jScannedBatch.[Name]")]
        public string ScannedBatchName
        {
            get => fields.ScannedBatchName[this];
            set => fields.ScannedBatchName[this] = value;
        }

        [DisplayName("Scanned Batch Description"), Expression("jScannedBatch.[Description]")]
        public string ScannedBatchDescription
        {
            get => fields.ScannedBatchDescription[this];
            set => fields.ScannedBatchDescription[this] = value;
        }

        [DisplayName("Scanned Batch Insert Date"), Expression("jScannedBatch.[InsertDate]")]
        public DateTime? ScannedBatchInsertDate
        {
            get => fields.ScannedBatchInsertDate[this];
            set => fields.ScannedBatchInsertDate[this] = value;
        }

        [DisplayName("Scanned Batch Insert User Id"), Expression("jScannedBatch.[InsertUserId]")]
        public int? ScannedBatchInsertUserId
        {
            get => fields.ScannedBatchInsertUserId[this];
            set => fields.ScannedBatchInsertUserId[this] = value;
        }

        [DisplayName("Scanned Batch Update Date"), Expression("jScannedBatch.[UpdateDate]")]
        public DateTime? ScannedBatchUpdateDate
        {
            get => fields.ScannedBatchUpdateDate[this];
            set => fields.ScannedBatchUpdateDate[this] = value;
        }

        [DisplayName("Scanned Batch Update User Id"), Expression("jScannedBatch.[UpdateUserId]")]
        public int? ScannedBatchUpdateUserId
        {
            get => fields.ScannedBatchUpdateUserId[this];
            set => fields.ScannedBatchUpdateUserId[this] = value;
        }

        [DisplayName("Scanned Batch Is Active"), Expression("jScannedBatch.[IsActive]")]
        public short? ScannedBatchIsActive
        {
            get => fields.ScannedBatchIsActive[this];
            set => fields.ScannedBatchIsActive[this] = value;
        }

        [DisplayName("Scanned Batch Tenant Id"), Expression("jScannedBatch.[TenantId]")]
        public int? ScannedBatchTenantId
        {
            get => fields.ScannedBatchTenantId[this];
            set => fields.ScannedBatchTenantId[this] = value;
        }
        public Int32Field TenantIdField
        {
            get => Fields.TenantId;
        }
        Int16Field IIsActiveRow.IsActiveField
        {
            get => fields.IsActive;
        }
        public ImportedScannedSheetRow()
            : base()
        {
        }

        public ImportedScannedSheetRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public GuidField Id;
            public Int32Field SheetTypeId;
            public DateTimeField ScannedAt;
            public StringField SheetNumber;
            public Int64Field ScannedRollNo;
            public Int64Field ScannedExamNo;
            public Int64Field CorrectedRollNo;
            public Int64Field CorrectedExamNo;
            public Int32Field ExamSetNo;
            public StringField ScannedImageSourcePath;
            public StringField ScannedImage;
            public GuidField ScannedBatchId;
            public Int16Field ScannedStatus;
            public StringField ScannedSystemErrors;
            public StringField ScannedUserErrors;
            public StringField ScannedComments;
            public BooleanField ResultProcessed;
            public Int16Field IsActive;
            public Int32Field TenantId;

            public StringField OCRData1Key;
            public StringField OCRData1Value;
            public StringField OCRData2Key;
            public StringField OCRData2Value;
            public StringField OCRData3Key;
            public StringField OCRData3Value;
            public StringField ICRData1Key;
            public StringField ICRData1Value;
            public StringField ICRData2Key;
            public StringField ICRData2Value;
            public StringField ICRData3Key;
            public StringField ICRData3Value;

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

            public StringField ScannedBatchName;
            public StringField ScannedBatchDescription;
            public DateTimeField ScannedBatchInsertDate;
            public Int32Field ScannedBatchInsertUserId;
            public DateTimeField ScannedBatchUpdateDate;
            public Int32Field ScannedBatchUpdateUserId;
            public Int16Field ScannedBatchIsActive;
            public Int32Field ScannedBatchTenantId;
        }
    }
}