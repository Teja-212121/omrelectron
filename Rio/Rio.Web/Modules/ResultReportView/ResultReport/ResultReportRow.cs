using Rio.Workspace;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace Rio.ResultReportView
{
    [ConnectionKey("Default"), Module("ResultReportView"), TableName("vw_ExamResultReport")]
    [DisplayName("Result Report"), InstanceName("Result Report")]
    [ReadPermission(PermissionKeys.General)]
    [ModifyPermission(PermissionKeys.General)]
    public sealed class ResultReportRow : Row<ResultReportRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Scanned Sheet Id")]
        public Guid? ScannedSheetId
        {
            get => fields.ScannedSheetId[this];
            set => fields.ScannedSheetId[this] = value;
        }

        [DisplayName("Roll Number")]
        public long? RollNumber
        {
            get => fields.RollNumber[this];
            set => fields.RollNumber[this] = value;
        }

        [DisplayName("Exam Id")]
        public int? ExamId
        {
            get => fields.ExamId[this];
            set => fields.ExamId[this] = value;
        }

        [DisplayName("Exam Code"), QuickSearch, NameProperty]
        public string ExamCode
        {
            get => fields.ExamCode[this];
            set => fields.ExamCode[this] = value;
        }

        [DisplayName("Question Index")]
        public int? QuestionIndex
        {
            get => fields.QuestionIndex[this];
            set => fields.QuestionIndex[this] = value;
        }

        [DisplayName("Is Attempted")]
        public int? IsAttempted
        {
            get => fields.IsAttempted[this];
            set => fields.IsAttempted[this] = value;
        }

        [DisplayName("Is Correct")]
        public int? IsCorrect
        {
            get => fields.IsCorrect[this];
            set => fields.IsCorrect[this] = value;
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

        [DisplayName("Score")]
        public string Score
        {
            get => fields.Score[this];
            set => fields.Score[this] = value;
        }

        [DisplayName("Obtained Marks")]
        public float? ObtainedMarks
        {
            get => fields.ObtainedMarks[this];
            set => fields.ObtainedMarks[this] = value;
        }

        public ResultReportRow()
            : base()
        {
        }

        public ResultReportRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public GuidField ScannedSheetId;
            public Int64Field RollNumber;
            public Int32Field ExamId;
            public StringField ExamCode;
            public Int32Field QuestionIndex;
            public Int32Field IsAttempted;
            public Int32Field IsCorrect;
            public StringField RightOptions;
            public StringField CorrectedOptions;
            public StringField Score;
            public SingleField ObtainedMarks;
        }
    }
}