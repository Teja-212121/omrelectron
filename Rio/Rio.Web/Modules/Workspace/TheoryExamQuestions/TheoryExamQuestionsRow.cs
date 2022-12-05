using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using Serenity.Extensions.Entities;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[dbo].[TheoryExamQuestions]")]
    [DisplayName("Theory Exam Questions"), InstanceName("Theory Exam Questions")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Workspace.TheoryExamQuestions", Permission = "?", Expiration = 1, LookupType = typeof(MultiTenantRowLookupScript<>))]
    public sealed class TheoryExamQuestionsRow : LoggingRow<TheoryExamQuestionsRow.RowFields>, IIdRow, INameRow, IMultiTenantRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public long? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Theory Exam"), NotNull, ForeignKey("[dbo].[TheoryExams]", "Id"), LeftJoin("jTheoryExam"), TextualField("TheoryExamCode")]
        [LookupEditor(typeof(TheoryExamsRow)), LookupInclude]
        public long? TheoryExamId
        {
            get => fields.TheoryExamId[this];
            set => fields.TheoryExamId[this] = value;
        }

        [DisplayName("Question Index"), NotNull]
        public int? QuestionIndex
        {
            get => fields.QuestionIndex[this];
            set => fields.QuestionIndex[this] = value;
        }

        [DisplayName("Max Marks"), NotNull]
        public float? MaxMarks
        {
            get => fields.MaxMarks[this];
            set => fields.MaxMarks[this] = value;
        }

        [DisplayName("Display Index"), Size(100), QuickSearch, NameProperty]
        public string DisplayIndex
        {
            get => fields.DisplayIndex[this];
            set => fields.DisplayIndex[this] = value;
        }

        [DisplayName("Tags"), Size(1000)]
        public string Tags
        {
            get => fields.Tags[this];
            set => fields.Tags[this] = value;
        }

        [DisplayName("Theory Exam Section"), ForeignKey("[dbo].[TheoryExamSections]", "Id"), LeftJoin("jTheoryExamSection"), TextualField("TheoryExamSectionName")]
        [LookupEditor(typeof(TheoryExamSectionsRow),CascadeFrom = "TheoryExamId", CascadeField = "TheoryExamId"), LookupInclude]
        public int? TheoryExamSectionId
        {
            get => fields.TheoryExamSectionId[this];
            set => fields.TheoryExamSectionId[this] = value;
        }

        

        [DisplayName("Is Active"), NotNull,DefaultValue(1)]
        public short? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        public Int32Field TenantIdField
        {
            get => Fields.TenantId;
        }
        [DisplayName("Tenant Id"), NotNull, Insertable(false), Updatable(true)]
        public int? TenantId
        {
            get => fields.TenantId[this];
            set => fields.TenantId[this] = value;
        }

        [DisplayName("Theory Exam Code"), Expression("jTheoryExam.[Code]")]
        public string TheoryExamCode
        {
            get => fields.TheoryExamCode[this];
            set => fields.TheoryExamCode[this] = value;
        }

        [DisplayName("Theory Exam Name"), Expression("jTheoryExam.[Name]")]
        public string TheoryExamName
        {
            get => fields.TheoryExamName[this];
            set => fields.TheoryExamName[this] = value;
        }

        [DisplayName("Theory Exam Description"), Expression("jTheoryExam.[Description]")]
        public string TheoryExamDescription
        {
            get => fields.TheoryExamDescription[this];
            set => fields.TheoryExamDescription[this] = value;
        }

        [DisplayName("Theory Exam Total Marks"), Expression("jTheoryExam.[TotalMarks]")]
        public int? TheoryExamTotalMarks
        {
            get => fields.TheoryExamTotalMarks[this];
            set => fields.TheoryExamTotalMarks[this] = value;
        }

        [DisplayName("Theory Exam Insert Date"), Expression("jTheoryExam.[InsertDate]")]
        public DateTime? TheoryExamInsertDate
        {
            get => fields.TheoryExamInsertDate[this];
            set => fields.TheoryExamInsertDate[this] = value;
        }

        [DisplayName("Theory Exam Insert User Id"), Expression("jTheoryExam.[InsertUserId]")]
        public int? TheoryExamInsertUserId
        {
            get => fields.TheoryExamInsertUserId[this];
            set => fields.TheoryExamInsertUserId[this] = value;
        }

        [DisplayName("Theory Exam Update Date"), Expression("jTheoryExam.[UpdateDate]")]
        public DateTime? TheoryExamUpdateDate
        {
            get => fields.TheoryExamUpdateDate[this];
            set => fields.TheoryExamUpdateDate[this] = value;
        }

        [DisplayName("Theory Exam Update User Id"), Expression("jTheoryExam.[UpdateUserId]")]
        public int? TheoryExamUpdateUserId
        {
            get => fields.TheoryExamUpdateUserId[this];
            set => fields.TheoryExamUpdateUserId[this] = value;
        }

        [DisplayName("Theory Exam Is Active"), Expression("jTheoryExam.[IsActive]")]
        public short? TheoryExamIsActive
        {
            get => fields.TheoryExamIsActive[this];
            set => fields.TheoryExamIsActive[this] = value;
        }

        [DisplayName("Theory Exam Tenant Id"), Expression("jTheoryExam.[TenantId]")]
        public int? TheoryExamTenantId
        {
            get => fields.TheoryExamTenantId[this];
            set => fields.TheoryExamTenantId[this] = value;
        }

        [DisplayName("Theory Exam Section Name"), Expression("jTheoryExamSection.[Name]")]
        public string TheoryExamSectionName
        {
            get => fields.TheoryExamSectionName[this];
            set => fields.TheoryExamSectionName[this] = value;
        }

        [DisplayName("Theory Exam Section Description"), Expression("jTheoryExamSection.[Description]")]
        public string TheoryExamSectionDescription
        {
            get => fields.TheoryExamSectionDescription[this];
            set => fields.TheoryExamSectionDescription[this] = value;
        }

        [DisplayName("Theory Exam Section Theory Exam Id"), Expression("jTheoryExamSection.[TheoryExamId]")]
        public long? TheoryExamSectionTheoryExamId
        {
            get => fields.TheoryExamSectionTheoryExamId[this];
            set => fields.TheoryExamSectionTheoryExamId[this] = value;
        }

        [DisplayName("Theory Exam Section Parent Id"), Expression("jTheoryExamSection.[ParentId]")]
        public int? TheoryExamSectionParentId
        {
            get => fields.TheoryExamSectionParentId[this];
            set => fields.TheoryExamSectionParentId[this] = value;
        }

        [DisplayName("Theory Exam Section Sort Order"), Expression("jTheoryExamSection.[SortOrder]")]
        public float? TheoryExamSectionSortOrder
        {
            get => fields.TheoryExamSectionSortOrder[this];
            set => fields.TheoryExamSectionSortOrder[this] = value;
        }

        [DisplayName("Theory Exam Section Insert Date"), Expression("jTheoryExamSection.[InsertDate]")]
        public DateTime? TheoryExamSectionInsertDate
        {
            get => fields.TheoryExamSectionInsertDate[this];
            set => fields.TheoryExamSectionInsertDate[this] = value;
        }

        [DisplayName("Theory Exam Section Insert User Id"), Expression("jTheoryExamSection.[InsertUserId]")]
        public int? TheoryExamSectionInsertUserId
        {
            get => fields.TheoryExamSectionInsertUserId[this];
            set => fields.TheoryExamSectionInsertUserId[this] = value;
        }

        [DisplayName("Theory Exam Section Update Date"), Expression("jTheoryExamSection.[UpdateDate]")]
        public DateTime? TheoryExamSectionUpdateDate
        {
            get => fields.TheoryExamSectionUpdateDate[this];
            set => fields.TheoryExamSectionUpdateDate[this] = value;
        }

        [DisplayName("Theory Exam Section Update User Id"), Expression("jTheoryExamSection.[UpdateUserId]")]
        public int? TheoryExamSectionUpdateUserId
        {
            get => fields.TheoryExamSectionUpdateUserId[this];
            set => fields.TheoryExamSectionUpdateUserId[this] = value;
        }

        [DisplayName("Theory Exam Section Is Active"), Expression("jTheoryExamSection.[IsActive]")]
        public short? TheoryExamSectionIsActive
        {
            get => fields.TheoryExamSectionIsActive[this];
            set => fields.TheoryExamSectionIsActive[this] = value;
        }

        [DisplayName("Theory Exam Section Tenant Id"), Expression("jTheoryExamSection.[TenantId]")]
        public int? TheoryExamSectionTenantId
        {
            get => fields.TheoryExamSectionTenantId[this];
            set => fields.TheoryExamSectionTenantId[this] = value;
        }

        public TheoryExamQuestionsRow()
            : base()
        {
        }

        public TheoryExamQuestionsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int64Field Id;
            public Int64Field TheoryExamId;
            public Int32Field QuestionIndex;
            public SingleField MaxMarks;
            public StringField DisplayIndex;
            public StringField Tags;
            public Int32Field TheoryExamSectionId;
            public Int16Field IsActive;
            public Int32Field TenantId;

            public StringField TheoryExamCode;
            public StringField TheoryExamName;
            public StringField TheoryExamDescription;
            public Int32Field TheoryExamTotalMarks;
            public DateTimeField TheoryExamInsertDate;
            public Int32Field TheoryExamInsertUserId;
            public DateTimeField TheoryExamUpdateDate;
            public Int32Field TheoryExamUpdateUserId;
            public Int16Field TheoryExamIsActive;
            public Int32Field TheoryExamTenantId;

            public StringField TheoryExamSectionName;
            public StringField TheoryExamSectionDescription;
            public Int64Field TheoryExamSectionTheoryExamId;
            public Int32Field TheoryExamSectionParentId;
            public SingleField TheoryExamSectionSortOrder;
            public DateTimeField TheoryExamSectionInsertDate;
            public Int32Field TheoryExamSectionInsertUserId;
            public DateTimeField TheoryExamSectionUpdateDate;
            public Int32Field TheoryExamSectionUpdateUserId;
            public Int16Field TheoryExamSectionIsActive;
            public Int32Field TheoryExamSectionTenantId;
        }
    }
}