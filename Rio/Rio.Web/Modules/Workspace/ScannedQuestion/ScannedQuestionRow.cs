using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[ScannedQuestions]")]
    [DisplayName("Scanned Question"), InstanceName("Scanned Question")]
    [ReadPermission(PermissionKeys.ScannedDataManagement.View)]
    [ModifyPermission(PermissionKeys.ScannedDataManagement.Modify)]
    public sealed class ScannedQuestionRow :LoggingRow<ScannedQuestionRow.RowFields>, IIdRow,IMultiTenantRow,IIsActiveRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        [SortOrder(1, descending: false)]
        public long? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Scanned Batch"), NotNull, ForeignKey("[ScannedBatches]", "Id"), LeftJoin("jScannedBatch"), TextualField("ScannedBatchName")]
        [LookupEditor("Workspace.ScannedBatchs")]
        public Guid? ScannedBatchId
        {
            get => fields.ScannedBatchId[this];
            set => fields.ScannedBatchId[this] = value;
        }

        [DisplayName("Scanned Sheet"), NotNull, ForeignKey("[ScannedSheets]", "Id"), LeftJoin("jScannedSheet"), TextualField("ScannedSheetSheetNumber")]
        [LookupEditor("Workspace.ScannedSheets", CascadeFrom = "ScannedBatchId", CascadeField = "ScannedBatchId")]
        public Guid? ScannedSheetId
        {
            get => fields.ScannedSheetId[this];
            set => fields.ScannedSheetId[this] = value;
        }

        [DisplayName("Question Index"), NotNull]
        public int? QuestionIndex
        {
            get => fields.QuestionIndex[this];
            set => fields.QuestionIndex[this] = value;
        }

        [DisplayName("Scanned Options"), NotNull]
        public string ScannedOptions
        {
            get => fields.ScannedOptions[this];
            set => fields.ScannedOptions[this] = value;
        }

        [DisplayName("Corrected Options"), NotNull]
        public string CorrectedOptions
        {
            get => fields.CorrectedOptions[this];
            set => fields.CorrectedOptions[this] = value;
        }

       
        [DisplayName("Is Active"), NotNull,Insertable(false),Updatable(false)]
        public short? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        [DisplayName("Tenant Id"), NotNull,Insertable(false),Updatable(false)]
        public int? TenantId
        {
            get => fields.TenantId[this];
            set => fields.TenantId[this] = value;
        }

        [DisplayName("Scanned Sheet Sheet Type Id"), Expression("jScannedSheet.[SheetTypeId]")]
        public int? ScannedSheetSheetTypeId
        {
            get => fields.ScannedSheetSheetTypeId[this];
            set => fields.ScannedSheetSheetTypeId[this] = value;
        }

        [DisplayName("Scanned Sheet Scanned At"), Expression("jScannedSheet.[ScannedAt]")]
        public DateTime? ScannedSheetScannedAt
        {
            get => fields.ScannedSheetScannedAt[this];
            set => fields.ScannedSheetScannedAt[this] = value;
        }

        [DisplayName("Scanned Sheet Number"), Expression("jScannedSheet.[SheetNumber]")]
        public string ScannedSheetSheetNumber
        {
            get => fields.ScannedSheetSheetNumber[this];
            set => fields.ScannedSheetSheetNumber[this] = value;
        }

        [DisplayName("Scanned Sheet Scanned Roll No"), Expression("jScannedSheet.[ScannedRollNo]")]
        public string ScannedSheetScannedRollNo
        {
            get => fields.ScannedSheetScannedRollNo[this];
            set => fields.ScannedSheetScannedRollNo[this] = value;
        }

        [DisplayName("Scanned Sheet Scanned Exam No"), Expression("jScannedSheet.[ScannedExamNo]")]
        public string ScannedSheetScannedExamNo
        {
            get => fields.ScannedSheetScannedExamNo[this];
            set => fields.ScannedSheetScannedExamNo[this] = value;
        }

        [DisplayName("Scanned Sheet Corrected Roll No"), Expression("jScannedSheet.[CorrectedRollNo]"),QuickSearch]
        public string ScannedSheetCorrectedRollNo
        {
            get => fields.ScannedSheetCorrectedRollNo[this];
            set => fields.ScannedSheetCorrectedRollNo[this] = value;
        }

        [DisplayName("Scanned Sheet Corrected Exam No"), Expression("jScannedSheet.[CorrectedExamNo]")]
        public string ScannedSheetCorrectedExamNo
        {
            get => fields.ScannedSheetCorrectedExamNo[this];
            set => fields.ScannedSheetCorrectedExamNo[this] = value;
        }

        [DisplayName("Scanned Sheet Exam Set No"), Expression("jScannedSheet.[ExamSetNo]")]
        public string ScannedSheetExamSetNo
        {
            get => fields.ScannedSheetExamSetNo[this];
            set => fields.ScannedSheetExamSetNo[this] = value;
        }

        [DisplayName("Scanned Sheet Scanned Image Source Path"), Expression("jScannedSheet.[ScannedImageSourcePath]")]
        public string ScannedSheetScannedImageSourcePath
        {
            get => fields.ScannedSheetScannedImageSourcePath[this];
            set => fields.ScannedSheetScannedImageSourcePath[this] = value;
        }

        [DisplayName("Scanned Sheet Scanned Image"), Expression("jScannedSheet.[ScannedImage]")]
        public string ScannedSheetScannedImage
        {
            get => fields.ScannedSheetScannedImage[this];
            set => fields.ScannedSheetScannedImage[this] = value;
        }

        [DisplayName("Scanned Sheet ImageBase64"), Expression("jScannedSheet.[ImageBase64]")]
        public string ScannedSheetImageBase64
        {
            get => fields.ScannedSheetImageBase64[this];
            set => fields.ScannedSheetImageBase64[this] = value;
        }

        [DisplayName("Scanned Batch"), Expression("jScannedSheet.[ScannedBatchId]")]
        public Guid? ScannedSheetScannedBatchId
        {
            get => fields.ScannedSheetScannedBatchId[this];
            set => fields.ScannedSheetScannedBatchId[this] = value;
        }

        [DisplayName("Scanned Sheet Scanned Status"), Expression("jScannedSheet.[ScannedStatus]")]
        public short? ScannedSheetScannedStatus
        {
            get => fields.ScannedSheetScannedStatus[this];
            set => fields.ScannedSheetScannedStatus[this] = value;
        }

        [DisplayName("Scanned Sheet Scanned System Errors"), Expression("jScannedSheet.[ScannedSystemErrors]")]
        public string ScannedSheetScannedSystemErrors
        {
            get => fields.ScannedSheetScannedSystemErrors[this];
            set => fields.ScannedSheetScannedSystemErrors[this] = value;
        }

        [DisplayName("Scanned Sheet Scanned User Errors"), Expression("jScannedSheet.[ScannedUserErrors]")]
        public string ScannedSheetScannedUserErrors
        {
            get => fields.ScannedSheetScannedUserErrors[this];
            set => fields.ScannedSheetScannedUserErrors[this] = value;
        }

        [DisplayName("Scanned Sheet Scanned Comments"), Expression("jScannedSheet.[ScannedComments]")]
        public string ScannedSheetScannedComments
        {
            get => fields.ScannedSheetScannedComments[this];
            set => fields.ScannedSheetScannedComments[this] = value;
        }

        [DisplayName("Scanned Sheet Result Processed"), Expression("jScannedSheet.[ResultProcessed]")]
        public bool? ScannedSheetResultProcessed
        {
            get => fields.ScannedSheetResultProcessed[this];
            set => fields.ScannedSheetResultProcessed[this] = value;
        }

        [DisplayName("Scanned Sheet Insert Date"), Expression("jScannedSheet.[InsertDate]")]
        public DateTime? ScannedSheetInsertDate
        {
            get => fields.ScannedSheetInsertDate[this];
            set => fields.ScannedSheetInsertDate[this] = value;
        }

        [DisplayName("Scanned Sheet Insert User Id"), Expression("jScannedSheet.[InsertUserId]")]
        public int? ScannedSheetInsertUserId
        {
            get => fields.ScannedSheetInsertUserId[this];
            set => fields.ScannedSheetInsertUserId[this] = value;
        }

        [DisplayName("Scanned Sheet Update Date"), Expression("jScannedSheet.[UpdateDate]")]
        public DateTime? ScannedSheetUpdateDate
        {
            get => fields.ScannedSheetUpdateDate[this];
            set => fields.ScannedSheetUpdateDate[this] = value;
        }

        [DisplayName("Scanned Sheet Update User Id"), Expression("jScannedSheet.[UpdateUserId]")]
        public int? ScannedSheetUpdateUserId
        {
            get => fields.ScannedSheetUpdateUserId[this];
            set => fields.ScannedSheetUpdateUserId[this] = value;
        }

        [DisplayName("Scanned Sheet Is Active"), Expression("jScannedSheet.[IsActive]")]
        public short? ScannedSheetIsActive
        {
            get => fields.ScannedSheetIsActive[this];
            set => fields.ScannedSheetIsActive[this] = value;
        }

        [DisplayName("OCR Data 1 Key"), Expression("jScannedSheet.[OCRData1Key]")]
        public string ScannedSheetOCRData1Key
        {
            get => fields.ScannedSheetOCRData1Key[this];
            set => fields.ScannedSheetOCRData1Key[this] = value;
        }

        [DisplayName("OCR Data 1 Value"), Expression("jScannedSheet.[OCRData1Value]")]
        public string ScannedSheetOCRData1Value
        {
            get => fields.ScannedSheetOCRData1Value[this];
            set => fields.ScannedSheetOCRData1Value[this] = value;
        }

        [DisplayName("Scanned Sheet Tenant Id"), Expression("jScannedSheet.[TenantId]")]
        public int? ScannedSheetTenantId
        {
            get => fields.ScannedSheetTenantId[this];
            set => fields.ScannedSheetTenantId[this] = value;
        }
        public Int32Field TenantIdField
        {
            get => Fields.TenantId;
        }
        Int16Field IIsActiveRow.IsActiveField
        {
            get => fields.IsActive;
        }
        public ScannedQuestionRow()
            : base()
        {
        }

        public ScannedQuestionRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields :LoggingRowFields
        {
            public Int64Field Id;
            public GuidField ScannedBatchId;
            public GuidField ScannedSheetId;
            public Int32Field QuestionIndex;
            public StringField ScannedOptions;
            public StringField CorrectedOptions;
            public Int16Field IsActive;
            public Int32Field TenantId;

            public Int32Field ScannedSheetSheetTypeId;
            public DateTimeField ScannedSheetScannedAt;
            public StringField ScannedSheetSheetNumber;
            public StringField ScannedSheetScannedRollNo;
            public StringField ScannedSheetScannedExamNo;
            public StringField ScannedSheetCorrectedRollNo;
            public StringField ScannedSheetCorrectedExamNo;
            public StringField ScannedSheetExamSetNo;
            public StringField ScannedSheetScannedImageSourcePath;
            public StringField ScannedSheetScannedImage;
            public StringField ScannedSheetImageBase64;
            public GuidField ScannedSheetScannedBatchId;
            public Int16Field ScannedSheetScannedStatus;
            public StringField ScannedSheetScannedSystemErrors;
            public StringField ScannedSheetScannedUserErrors;
            public StringField ScannedSheetScannedComments;
            public BooleanField ScannedSheetResultProcessed;
            public DateTimeField ScannedSheetInsertDate;
            public Int32Field ScannedSheetInsertUserId;
            public DateTimeField ScannedSheetUpdateDate;
            public Int32Field ScannedSheetUpdateUserId;
            public Int16Field ScannedSheetIsActive;
            public StringField ScannedSheetOCRData1Key;
            public StringField ScannedSheetOCRData1Value;
            public Int32Field ScannedSheetTenantId;
        }
    }
}