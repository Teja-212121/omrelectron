using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[Exams]")]
    [DisplayName("Exam"), InstanceName("Exam")]
    [ReadPermission(PermissionKeys.ExamsAndSectionManagement.View)]
    [ModifyPermission(PermissionKeys.ExamsAndSectionManagement.Modify)]
    [LookupScript("Workspace.Exam", Permission = "*", Expiration = 1, LookupType = typeof(MultiTenantRowLookupScript<>))]
    public sealed class ExamRow : LoggingRow<ExamRow.RowFields>, IIdRow, INameRow, IIsActiveRow, IMultiTenantRow
    {
        [DisplayName("Id"), Identity, IdProperty, QuickSearch]
        [SortOrder(1, descending: true)]
        public long? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Code"), Size(100), NotNull, QuickSearch]
        public string Code
        {
            get => fields.Code[this];
            set => fields.Code[this] = value;
        }

        [DisplayName("Name"), Size(500), NotNull, QuickSearch]
        public string Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }

        [DisplayName("Sheet Type"),ForeignKey("[SheetTypes]", "Id"), LeftJoin("jSheetType"), TextualField("SheetTypeName")]
        [LookupEditor("Workspace.SheetTypes")]
        public int? SheetTypeId
        {
            get => fields.SheetTypeId[this];
            set => fields.SheetTypeId[this] = value;
        }

        [DisplayName("ExamDisplayName"), Size(500),  NameProperty, QuickSearch]
       
        public string ExamDisplayName
        {
            get => fields.ExamDisplayName[this];
            set => fields.ExamDisplayName[this] = value;
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

        [DisplayName("Total Marks"), NotNull]
        public int? TotalMarks
        {
            get => fields.TotalMarks[this];
            set => fields.TotalMarks[this] = value;
        }

        [DisplayName("Negative Marks")]
        public float? NegativeMarks
        {
            get => fields.NegativeMarks[this];
            set => fields.NegativeMarks[this] = value;
        }

        [DisplayName("Options Available")]
        public short? OptionsAvailable
        {
            get => fields.OptionsAvailable[this];
            set => fields.OptionsAvailable[this] = value;
        }

        [DisplayName("Result Criteria"), Size(1000)]
        public string ResultCriteria
        {
            get => fields.ResultCriteria[this];
            set => fields.ResultCriteria[this] = value;
        }

        [DisplayName("Question Paper"), Size(2000), FileUploadEditor()]
        public string QuestionPaper
        {
            get => fields.QuestionPaper[this];
            set => fields.QuestionPaper[this] = value;
        }

        [DisplayName("Model Answer"), Size(2000), FileUploadEditor()]
        public string ModelAnswer
        {
            get => fields.ModelAnswer[this];
            set => fields.ModelAnswer[this] = value;
        }

        [DisplayName("Is Active"), NotNull, Insertable(false), Updatable(true)]
        public short? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        [DisplayName("Tenant Id")]
        [LookupEditor("Administration.Tenant")]
        public int? TenantId
        {
            get => fields.TenantId[this];
            set => fields.TenantId[this] = value;
        }

        [DisplayName("Tenant Id"), NotMapped]
        [LookupEditor("Administration.Tenant")]
        public int? SelectedTenant
        {
            get => fields.SelectedTenant[this];
            set => fields.SelectedTenant[this] = value;
        }
        public Int32Field TenantIdField
        {
            get => Fields.TenantId;
        }

        [DisplayName("Sheet Type Display Name"), Size(100), Expression("jSheetType.[SheetTypeDisplayName]")]
        public string SheetTypeDisplayName
        {
            get => fields.SheetTypeDisplayName[this];
            set => fields.SheetTypeDisplayName[this] = value;
        }

        [DisplayName("Sheet Type Name"), Expression("jSheetType.[Name]"), QuickSearch]
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
        Int16Field IIsActiveRow.IsActiveField
        {
            get => fields.IsActive;
        }
       

        public ExamRow()
            : base()
        {
        }

        public ExamRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int64Field Id;
            public StringField Code;
            public StringField Name;
            public StringField ExamDisplayName;
            public StringField Description;
            public Int32Field TotalQuestions;
            public Int32Field TotalMarks;
            public SingleField NegativeMarks;
            public Int16Field OptionsAvailable;
            public StringField ResultCriteria;
            public StringField QuestionPaper;
            public StringField ModelAnswer;
            public Int16Field IsActive;
            public Int32Field TenantId;
            public Int32Field SelectedTenant;
            public Int32Field SheetTypeId;

            public StringField SheetTypeDisplayName;
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
        }
    }
}