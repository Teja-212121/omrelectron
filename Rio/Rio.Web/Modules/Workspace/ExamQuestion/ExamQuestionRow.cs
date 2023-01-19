using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[ExamQuestions]")]
    [DisplayName("Exam Question"), InstanceName("Exam Question")]
    [ReadPermission(PermissionKeys.ExamQuestionManagement.View)]
    [ModifyPermission(PermissionKeys.ExamQuestionManagement.Modify)]
    public sealed class ExamQuestionRow : LoggingRow<ExamQuestionRow.RowFields>, IIdRow, INameRow, IIsActiveRow, IMultiTenantRow
    {
        [DisplayName("Id"), Identity, IdProperty,QuickSearch]
        [SortOrder(1, descending: false)]
        public long? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [NotMapped]
        public String RowIds
        {
            get { return Fields.RowIds[this]; }
            set { Fields.RowIds[this] = value; }
        }

        [DisplayName("Exam"), NotNull, ForeignKey("[Exams]", "Id"), LeftJoin("jExam"), TextualField("ExamName")]
        [LookupEditor("Workspace.Exam")]
        public long? ExamId
        {
            get => fields.ExamId[this];
            set => fields.ExamId[this] = value;
        }

        [DisplayName("Question Index")]
        public int? QuestionIndex
        {
            get => fields.QuestionIndex[this];
            set => fields.QuestionIndex[this] = value;
        }

        [DisplayName("Display Index")]
        public string? DisplayIndex
        {
            get => fields.DisplayIndex[this];
            set => fields.DisplayIndex[this] = value;
        }

        [DisplayName("Right Options")]
        public string RightOptions
        {
            get => fields.RightOptions[this];
            set => fields.RightOptions[this] = value;
        }

        [DisplayName("Score")]
        public string Score
        {
            get => fields.Score[this];
            set => fields.Score[this] = value;
        }

        [DisplayName("Tags"), Size(1000), QuickSearch, NameProperty]
        public string Tags
        {
            get => fields.Tags[this];
            set => fields.Tags[this] = value;
        }

        [DisplayName("Rule Type"), ForeignKey("[RuleTypes]", "Id"), LeftJoin("jRuleType"), TextualField("RuleTypeName")]
        [LookupEditor("Workspace.RuleType")]
        public int? RuleTypeId
        {
            get => fields.RuleTypeId[this];
            set => fields.RuleTypeId[this] = value;
        }

        [DisplayName("Exam Section"), ForeignKey("[ExamSections]", "Id"), LeftJoin("jExamSection"), TextualField("ExamSectionName")]
        [LookupEditor("Workspace.ExamSection", CascadeFrom = "ExamId", CascadeField = "ExamId")]
        public int? ExamSectionId
        {
            get => fields.ExamSectionId[this];
            set => fields.ExamSectionId[this] = value;
        }
        
        [DisplayName("Is Active"), NotNull, Insertable(false), Updatable(true)]
        public short? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }
        public Int32Field TenantIdField
        {
            get => Fields.TenantId;
        }
        Int16Field IIsActiveRow.IsActiveField
        {
            get => fields.IsActive;
        }
        [DisplayName("Tenant Id"), ForeignKey("[Tenants]", "TenantId"), LeftJoin("jTenant"), TextualField("TenantName"), NotNull, Insertable(false), Updatable(true)]
        public int? TenantId
        {
            get => fields.TenantId[this];
            set => fields.TenantId[this] = value;
        }

        [DisplayName("Tenant Name"), Expression("jTenant.[TenantName]")]
        public string TenantName
        {
            get => fields.TenantName[this];
            set => fields.TenantName[this] = value;
        }

        [DisplayName("Exam Code"), Expression("jExam.[Code]"),QuickSearch]
        public string ExamCode
        {
            get => fields.ExamCode[this];
            set => fields.ExamCode[this] = value;
        }

        [DisplayName("Exam Name"), Expression("jExam.[Name]")]
        public string ExamName
        {
            get => fields.ExamName[this];
            set => fields.ExamName[this] = value;
        }

        [DisplayName("Exam Description"), Expression("jExam.[Description]")]
        public string ExamDescription
        {
            get => fields.ExamDescription[this];
            set => fields.ExamDescription[this] = value;
        }

        [DisplayName("Exam Total Marks"), Expression("jExam.[TotalMarks]")]
        public int? ExamTotalMarks
        {
            get => fields.ExamTotalMarks[this];
            set => fields.ExamTotalMarks[this] = value;
        }

        [DisplayName("Exam Negative Marks"), Expression("jExam.[NegativeMarks]")]
        public float? ExamNegativeMarks
        {
            get => fields.ExamNegativeMarks[this];
            set => fields.ExamNegativeMarks[this] = value;
        }

        [DisplayName("Exam Options Available"), Expression("jExam.[OptionsAvailable]")]
        public short? ExamOptionsAvailable
        {
            get => fields.ExamOptionsAvailable[this];
            set => fields.ExamOptionsAvailable[this] = value;
        }

        [DisplayName("Exam Result Criteria"), Expression("jExam.[ResultCriteria]")]
        public string ExamResultCriteria
        {
            get => fields.ExamResultCriteria[this];
            set => fields.ExamResultCriteria[this] = value;
        }

        [DisplayName("Exam Insert Date"), Expression("jExam.[InsertDate]")]
        public DateTime? ExamInsertDate
        {
            get => fields.ExamInsertDate[this];
            set => fields.ExamInsertDate[this] = value;
        }

        [DisplayName("Exam Insert User Id"), Expression("jExam.[InsertUserId]")]
        public int? ExamInsertUserId
        {
            get => fields.ExamInsertUserId[this];
            set => fields.ExamInsertUserId[this] = value;
        }

        [DisplayName("Exam Update Date"), Expression("jExam.[UpdateDate]")]
        public DateTime? ExamUpdateDate
        {
            get => fields.ExamUpdateDate[this];
            set => fields.ExamUpdateDate[this] = value;
        }

        [DisplayName("Exam Update User Id"), Expression("jExam.[UpdateUserId]")]
        public int? ExamUpdateUserId
        {
            get => fields.ExamUpdateUserId[this];
            set => fields.ExamUpdateUserId[this] = value;
        }

        [DisplayName("Exam Is Active"), Expression("jExam.[IsActive]")]
        public short? ExamIsActive
        {
            get => fields.ExamIsActive[this];
            set => fields.ExamIsActive[this] = value;
        }

        [DisplayName("Exam Tenant Id"), Expression("jExam.[TenantId]")]
        public int? ExamTenantId
        {
            get => fields.ExamTenantId[this];
            set => fields.ExamTenantId[this] = value;
        }

        [DisplayName("Rule Type Name"), Expression("jRuleType.[Name]")]
        public string RuleTypeName
        {
            get => fields.RuleTypeName[this];
            set => fields.RuleTypeName[this] = value;
        }

        [DisplayName("Rule Type Description"), Expression("jRuleType.[Description]")]
        public string RuleTypeDescription
        {
            get => fields.RuleTypeDescription[this];
            set => fields.RuleTypeDescription[this] = value;
        }

        [DisplayName("Exam Section Name"), Expression("jExamSection.[Name]"), QuickSearch]
        public string ExamSectionName
        {
            get => fields.ExamSectionName[this];
            set => fields.ExamSectionName[this] = value;
        }

        [DisplayName("Exam Section Description"), Expression("jExamSection.[Description]")]
        public string ExamSectionDescription
        {
            get => fields.ExamSectionDescription[this];
            set => fields.ExamSectionDescription[this] = value;
        }

        [DisplayName("Exam Section Exam Id"), Expression("jExamSection.[ExamId]")]
        public long? ExamSectionExamId
        {
            get => fields.ExamSectionExamId[this];
            set => fields.ExamSectionExamId[this] = value;
        }

        [DisplayName("Exam Section Parent Id"), Expression("jExamSection.[ParentId]")]
        public int? ExamSectionParentId
        {
            get => fields.ExamSectionParentId[this];
            set => fields.ExamSectionParentId[this] = value;
        }

        [DisplayName("Exam Section Insert Date"), Expression("jExamSection.[InsertDate]")]
        public DateTime? ExamSectionInsertDate
        {
            get => fields.ExamSectionInsertDate[this];
            set => fields.ExamSectionInsertDate[this] = value;
        }

        [DisplayName("Exam Section Insert User Id"), Expression("jExamSection.[InsertUserId]")]
        public int? ExamSectionInsertUserId
        {
            get => fields.ExamSectionInsertUserId[this];
            set => fields.ExamSectionInsertUserId[this] = value;
        }

        [DisplayName("Exam Section Update Date"), Expression("jExamSection.[UpdateDate]")]
        public DateTime? ExamSectionUpdateDate
        {
            get => fields.ExamSectionUpdateDate[this];
            set => fields.ExamSectionUpdateDate[this] = value;
        }

        [DisplayName("Exam Section Update User Id"), Expression("jExamSection.[UpdateUserId]")]
        public int? ExamSectionUpdateUserId
        {
            get => fields.ExamSectionUpdateUserId[this];
            set => fields.ExamSectionUpdateUserId[this] = value;
        }

        [DisplayName("Exam Section Is Active"), Expression("jExamSection.[IsActive]")]
        public short? ExamSectionIsActive
        {
            get => fields.ExamSectionIsActive[this];
            set => fields.ExamSectionIsActive[this] = value;
        }

        [DisplayName("Exam Section Tenant Id"), Expression("jExamSection.[TenantId]")]
        public int? ExamSectionTenantId
        {
            get => fields.ExamSectionTenantId[this];
            set => fields.ExamSectionTenantId[this] = value;
        }

        public ExamQuestionRow()
            : base()
        {
        }

        public ExamQuestionRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int64Field Id;
            public Int64Field ExamId;
            public Int32Field QuestionIndex;
            public StringField DisplayIndex;
            public StringField RightOptions;
            public StringField Score;
            public StringField Tags;
            public Int32Field RuleTypeId;
            public Int32Field ExamSectionId;
            
            public Int16Field IsActive;
            public Int32Field TenantId;
            public StringField TenantName;

            public StringField ExamCode;
            public StringField ExamName;
            public StringField ExamDescription;
            public Int32Field ExamTotalMarks;
            public SingleField ExamNegativeMarks;
            public Int16Field ExamOptionsAvailable;
            public StringField ExamResultCriteria;
            public DateTimeField ExamInsertDate;
            public Int32Field ExamInsertUserId;
            public DateTimeField ExamUpdateDate;
            public Int32Field ExamUpdateUserId;
            public Int16Field ExamIsActive;
            public Int32Field ExamTenantId;

            public StringField RuleTypeName;
            public StringField RuleTypeDescription;

            public StringField ExamSectionName;
            public StringField ExamSectionDescription;
            public Int64Field ExamSectionExamId;
            public Int32Field ExamSectionParentId;
            public DateTimeField ExamSectionInsertDate;
            public Int32Field ExamSectionInsertUserId;
            public DateTimeField ExamSectionUpdateDate;
            public Int32Field ExamSectionUpdateUserId;
            public Int16Field ExamSectionIsActive;
            public Int32Field ExamSectionTenantId;
            public StringField RowIds;
        }
    }
}