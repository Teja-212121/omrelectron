using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using Serenity.Extensions.Entities;
using System.ComponentModel;
using Rio.Web.Enums;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[TheoryExamResultQuestions]")]
    [DisplayName("Theory Exam Result Questions"), InstanceName("Theory Exam Result Questions")]
    [ReadPermission(PermissionKeys.ExamsAndSectionManagement.View)]
    [ModifyPermission(PermissionKeys.ExamsAndSectionManagement.Modify)]
    public sealed class TheoryExamResultQuestionsRow : LoggingRow<TheoryExamResultQuestionsRow.RowFields>, IIdRow, IMultiTenantRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public long? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Theory Exam Result"), NotNull, ForeignKey("[TheoryExamResults]", "Id"), LeftJoin("jTheoryExamResult"), TextualField("TheoryExamResultStudentScanId")]
        [LookupEditor(typeof(TheoryExamResultsRow)), LookupInclude]
        public long? TheoryExamResultId
        {
            get => fields.TheoryExamResultId[this];
            set => fields.TheoryExamResultId[this] = value;
        }

        [DisplayName("Theory Exam Question"), ForeignKey("[TheoryExamQuestions]", "Id"), LeftJoin("jTheoryExamQuestion"), TextualField("TheoryExamQuestionDisplayIndex")]
        [NotNull]
        public long? TheoryExamQuestionId
        {
            get => fields.TheoryExamQuestionId[this];
            set => fields.TheoryExamQuestionId[this] = value;
        }

        [DisplayName("Marks Obtained")]
        public float? MarksObtained
        {
            get => fields.MarksObtained[this];
            set => fields.MarksObtained[this] = value;
        }

        [DisplayName("Out Of Marks")]
        public float? OutOfMarks
        {
            get => fields.OutOfMarks[this];
            set => fields.OutOfMarks[this] = value;
        }

        [DisplayName("Attempt Status"), NotNull]
        public EAttemptStatus? AttemptStatus
        {
            get => (EAttemptStatus?)fields.AttemptStatus[this];
            set => fields.AttemptStatus[this] = (short?)value;
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

        [DisplayName("Theory Exam Result Theory Exam Id"), Expression("jTheoryExamResult.[TheoryExamId]")]
        public long? TheoryExamResultTheoryExamId
        {
            get => fields.TheoryExamResultTheoryExamId[this];
            set => fields.TheoryExamResultTheoryExamId[this] = value;
        }

        [DisplayName("Theory Exam Result Student Scan Id"), Expression("jTheoryExamResult.[StudentScanId]")]
        public string TheoryExamResultStudentScanId
        {
            get => fields.TheoryExamResultStudentScanId[this];
            set => fields.TheoryExamResultStudentScanId[this] = value;
        }

        [DisplayName("Theory Exam Result Marks Scored"), Expression("jTheoryExamResult.[MarksScored]")]
        public float? TheoryExamResultMarksScored
        {
            get => fields.TheoryExamResultMarksScored[this];
            set => fields.TheoryExamResultMarksScored[this] = value;
        }

        [DisplayName("Theory Exam Result Out Of Marks"), Expression("jTheoryExamResult.[OutOfMarks]")]
        public float? TheoryExamResultOutOfMarks
        {
            get => fields.TheoryExamResultOutOfMarks[this];
            set => fields.TheoryExamResultOutOfMarks[this] = value;
        }

        [DisplayName("Theory Exam Result Result Status"), Expression("jTheoryExamResult.[ResultStatus]")]
        public short? TheoryExamResultResultStatus
        {
            get => fields.TheoryExamResultResultStatus[this];
            set => fields.TheoryExamResultResultStatus[this] = value;
        }

        [DisplayName("Theory Exam Result Roll Number"), Expression("jTheoryExamResult.[RollNumber]")]
        public string TheoryExamResultRollNumber
        {
            get => fields.TheoryExamResultRollNumber[this];
            set => fields.TheoryExamResultRollNumber[this] = value;
        }

        [DisplayName("Theory Exam Result Sheet Image"), Expression("jTheoryExamResult.[SheetImage]")]
        public string TheoryExamResultSheetImage
        {
            get => fields.TheoryExamResultSheetImage[this];
            set => fields.TheoryExamResultSheetImage[this] = value;
        }

        [DisplayName("Theory Exam Result Student Id"), Expression("jTheoryExamResult.[StudentId]")]
        public long? TheoryExamResultStudentId
        {
            get => fields.TheoryExamResultStudentId[this];
            set => fields.TheoryExamResultStudentId[this] = value;
        }

        [DisplayName("Theory Exam Result Attempt Date"), Expression("jTheoryExamResult.[AttemptDate]")]
        public DateTime? TheoryExamResultAttemptDate
        {
            get => fields.TheoryExamResultAttemptDate[this];
            set => fields.TheoryExamResultAttemptDate[this] = value;
        }

        [DisplayName("Theory Exam Result Insert Date"), Expression("jTheoryExamResult.[InsertDate]")]
        public DateTime? TheoryExamResultInsertDate
        {
            get => fields.TheoryExamResultInsertDate[this];
            set => fields.TheoryExamResultInsertDate[this] = value;
        }

        [DisplayName("Theory Exam Result Insert User Id"), Expression("jTheoryExamResult.[InsertUserId]")]
        public int? TheoryExamResultInsertUserId
        {
            get => fields.TheoryExamResultInsertUserId[this];
            set => fields.TheoryExamResultInsertUserId[this] = value;
        }

        [DisplayName("Theory Exam Result Update Date"), Expression("jTheoryExamResult.[UpdateDate]")]
        public DateTime? TheoryExamResultUpdateDate
        {
            get => fields.TheoryExamResultUpdateDate[this];
            set => fields.TheoryExamResultUpdateDate[this] = value;
        }

        [DisplayName("Theory Exam Result Update User Id"), Expression("jTheoryExamResult.[UpdateUserId]")]
        public int? TheoryExamResultUpdateUserId
        {
            get => fields.TheoryExamResultUpdateUserId[this];
            set => fields.TheoryExamResultUpdateUserId[this] = value;
        }

        [DisplayName("Theory Exam Result Is Active"), Expression("jTheoryExamResult.[IsActive]")]
        public short? TheoryExamResultIsActive
        {
            get => fields.TheoryExamResultIsActive[this];
            set => fields.TheoryExamResultIsActive[this] = value;
        }

        [DisplayName("Theory Exam Result Tenant Id"), Expression("jTheoryExamResult.[TenantId]")]
        public int? TheoryExamResultTenantId
        {
            get => fields.TheoryExamResultTenantId[this];
            set => fields.TheoryExamResultTenantId[this] = value;
        }

        [DisplayName("Theory Exam Question Theory Exam Id"), Expression("jTheoryExamQuestion.[TheoryExamId]")]
        public long? TheoryExamQuestionTheoryExamId
        {
            get => fields.TheoryExamQuestionTheoryExamId[this];
            set => fields.TheoryExamQuestionTheoryExamId[this] = value;
        }

        [DisplayName("Theory Exam Question Question Index"), Expression("jTheoryExamQuestion.[QuestionIndex]")]
        public int? TheoryExamQuestionQuestionIndex
        {
            get => fields.TheoryExamQuestionQuestionIndex[this];
            set => fields.TheoryExamQuestionQuestionIndex[this] = value;
        }

        [DisplayName("Theory Exam Question Max Marks"), Expression("jTheoryExamQuestion.[MaxMarks]")]
        public float? TheoryExamQuestionMaxMarks
        {
            get => fields.TheoryExamQuestionMaxMarks[this];
            set => fields.TheoryExamQuestionMaxMarks[this] = value;
        }

        [DisplayName("Theory Exam Question Display Index"), Expression("jTheoryExamQuestion.[DisplayIndex]")]
        public string TheoryExamQuestionDisplayIndex
        {
            get => fields.TheoryExamQuestionDisplayIndex[this];
            set => fields.TheoryExamQuestionDisplayIndex[this] = value;
        }

        [DisplayName("Theory Exam Question Tags"), Expression("jTheoryExamQuestion.[Tags]")]
        public string TheoryExamQuestionTags
        {
            get => fields.TheoryExamQuestionTags[this];
            set => fields.TheoryExamQuestionTags[this] = value;
        }

        [DisplayName("Theory Exam Question Theory Exam Section Id"), Expression("jTheoryExamQuestion.[TheoryExamSectionId]")]
        public int? TheoryExamQuestionTheoryExamSectionId
        {
            get => fields.TheoryExamQuestionTheoryExamSectionId[this];
            set => fields.TheoryExamQuestionTheoryExamSectionId[this] = value;
        }

        [DisplayName("Theory Exam Question Insert Date"), Expression("jTheoryExamQuestion.[InsertDate]")]
        public DateTime? TheoryExamQuestionInsertDate
        {
            get => fields.TheoryExamQuestionInsertDate[this];
            set => fields.TheoryExamQuestionInsertDate[this] = value;
        }

        [DisplayName("Theory Exam Question Insert User Id"), Expression("jTheoryExamQuestion.[InsertUserId]")]
        public int? TheoryExamQuestionInsertUserId
        {
            get => fields.TheoryExamQuestionInsertUserId[this];
            set => fields.TheoryExamQuestionInsertUserId[this] = value;
        }

        [DisplayName("Theory Exam Question Update Date"), Expression("jTheoryExamQuestion.[UpdateDate]")]
        public DateTime? TheoryExamQuestionUpdateDate
        {
            get => fields.TheoryExamQuestionUpdateDate[this];
            set => fields.TheoryExamQuestionUpdateDate[this] = value;
        }

        [DisplayName("Theory Exam Question Update User Id"), Expression("jTheoryExamQuestion.[UpdateUserId]")]
        public int? TheoryExamQuestionUpdateUserId
        {
            get => fields.TheoryExamQuestionUpdateUserId[this];
            set => fields.TheoryExamQuestionUpdateUserId[this] = value;
        }

        [DisplayName("Theory Exam Question Is Active"), Expression("jTheoryExamQuestion.[IsActive]")]
        public short? TheoryExamQuestionIsActive
        {
            get => fields.TheoryExamQuestionIsActive[this];
            set => fields.TheoryExamQuestionIsActive[this] = value;
        }

        [DisplayName("Theory Exam Question Tenant Id"), Expression("jTheoryExamQuestion.[TenantId]")]
        public int? TheoryExamQuestionTenantId
        {
            get => fields.TheoryExamQuestionTenantId[this];
            set => fields.TheoryExamQuestionTenantId[this] = value;
        }

        public TheoryExamResultQuestionsRow()
            : base()
        {
        }

        public TheoryExamResultQuestionsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int64Field Id;
            public Int64Field TheoryExamResultId;
            public Int64Field TheoryExamQuestionId;
            public SingleField MarksObtained;
            public SingleField OutOfMarks;
            public Int16Field AttemptStatus;
            public Int16Field IsActive;
            public Int32Field TenantId;
            

            public Int64Field TheoryExamResultTheoryExamId;
            public StringField TheoryExamResultStudentScanId;
            public SingleField TheoryExamResultMarksScored;
            public SingleField TheoryExamResultOutOfMarks;
            public Int16Field TheoryExamResultResultStatus;
            public StringField TheoryExamResultRollNumber;
            public StringField TheoryExamResultSheetImage;
            public Int64Field TheoryExamResultStudentId;
            public DateTimeField TheoryExamResultAttemptDate;
            public DateTimeField TheoryExamResultInsertDate;
            public Int32Field TheoryExamResultInsertUserId;
            public DateTimeField TheoryExamResultUpdateDate;
            public Int32Field TheoryExamResultUpdateUserId;
            public Int16Field TheoryExamResultIsActive;
            public Int32Field TheoryExamResultTenantId;

            public Int64Field TheoryExamQuestionTheoryExamId;
            public Int32Field TheoryExamQuestionQuestionIndex;
            public SingleField TheoryExamQuestionMaxMarks;
            public StringField TheoryExamQuestionDisplayIndex;
            public StringField TheoryExamQuestionTags;
            public Int32Field TheoryExamQuestionTheoryExamSectionId;
            public DateTimeField TheoryExamQuestionInsertDate;
            public Int32Field TheoryExamQuestionInsertUserId;
            public DateTimeField TheoryExamQuestionUpdateDate;
            public Int32Field TheoryExamQuestionUpdateUserId;
            public Int16Field TheoryExamQuestionIsActive;
            public Int32Field TheoryExamQuestionTenantId;
        }
    }
}