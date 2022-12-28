using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("GetScanData")]
    [DisplayName("Get Scan Data"), InstanceName("Get Scan Data")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class GetScanDataRow : Row<GetScanDataRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Student Id")]
        public int? StudentId
        {
            get => fields.StudentId[this];
            set => fields.StudentId[this] = value;
        }

        [DisplayName("Exam Id")]
        public int? ExamId
        {
            get => fields.ExamId[this];
            set => fields.ExamId[this] = value;
        }

        [DisplayName("Negative Marks")]
        public float? NegativeMarks
        {
            get => fields.NegativeMarks[this];
            set => fields.NegativeMarks[this] = value;
        }

        [DisplayName("Question Index")]
        public int? QuestionIndex
        {
            get => fields.QuestionIndex[this];
            set => fields.QuestionIndex[this] = value;
        }

        [DisplayName("Tenant Id")]
        public int? TenantId
        {
            get => fields.TenantId[this];
            set => fields.TenantId[this] = value;
        }

        [DisplayName("Scan Sheet Id")]
        public Guid? ScanSheetId
        {
            get => fields.ScanSheetId[this];
            set => fields.ScanSheetId[this] = value;
        }

        [DisplayName("Scan Batch Id")]
        public Guid? ScanBatchId
        {
            get => fields.ScanBatchId[this];
            set => fields.ScanBatchId[this] = value;
        }

        [DisplayName("Score")]
        public string Score
        {
            get => fields.Score[this];
            set => fields.Score[this] = value;
        }

        [DisplayName("Corrected Roll No")]
        public string CorrectedRollNo
        {
            get => fields.CorrectedRollNo[this];
            set => fields.CorrectedRollNo[this] = value;
        }

        [DisplayName("Sheet Number"), QuickSearch, NameProperty]
        public string SheetNumber
        {
            get => fields.SheetNumber[this];
            set => fields.SheetNumber[this] = value;
        }

        [DisplayName("Right Options")]
        public string RightOptions
        {
            get => fields.RightOptions[this];
            set => fields.RightOptions[this] = value;
        }

        [DisplayName("Corrected Options")]
        public string CorrectedOptions
        {
            get => fields.CorrectedOptions[this];
            set => fields.CorrectedOptions[this] = value;
        }

        [DisplayName("Rule Type Id")]
        public int? RuleTypeId
        {
            get => fields.RuleTypeId[this];
            set => fields.RuleTypeId[this] = value;
        }

        public GetScanDataRow()
            : base()
        {
        }

        public GetScanDataRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field StudentId;
            public Int32Field ExamId;
            public SingleField NegativeMarks;
            public Int32Field QuestionIndex;
            public Int32Field TenantId;
            public GuidField ScanSheetId;
            public GuidField ScanBatchId;
            public StringField Score;
            public StringField CorrectedRollNo;
            public StringField SheetNumber;
            public StringField RightOptions;
            public StringField CorrectedOptions;
            public Int32Field RuleTypeId;
        }
    }
}