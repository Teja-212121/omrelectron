using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using Serenity.Extensions.Entities;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[dbo].[TheoryExamResults]")]
    [DisplayName("Theory Exam Results"), InstanceName("Theory Exam Results")]
    [ReadPermission(PermissionKeys.ExamsAndSectionManagement.View)]
    [ModifyPermission(PermissionKeys.ExamsAndSectionManagement.Modify)]
    public sealed class TheoryExamResultsRow : LoggingRow<TheoryExamResultsRow.RowFields>, IIdRow, INameRow, IMultiTenantRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public long? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Theory Exam"), NotNull, ForeignKey("[dbo].[TheoryExams]", "Id"), LeftJoin("jTheoryExam"), TextualField("TheoryExamCode")]
        public long? TheoryExamId
        {
            get => fields.TheoryExamId[this];
            set => fields.TheoryExamId[this] = value;
        }

        [DisplayName("Student Scan Id"), Size(500), NotNull, QuickSearch, NameProperty]
        public string StudentScanId
        {
            get => fields.StudentScanId[this];
            set => fields.StudentScanId[this] = value;
        }

        [DisplayName("Theory Exam Question"), ForeignKey("[dbo].[TheoryExamQuestions]", "Id"), LeftJoin("jTheoryExamQuestion"), TextualField("TheoryExamQuestionDisplayIndex")]
        public long? TheoryExamQuestionId
        {
            get => fields.TheoryExamQuestionId[this];
            set => fields.TheoryExamQuestionId[this] = value;
        }

        [DisplayName("Marks Obtained"), NotNull]
        public float? MarksObtained
        {
            get => fields.MarksObtained[this];
            set => fields.MarksObtained[this] = value;
        }

        [DisplayName("Attempt Status"), NotNull]
        public short? AttemptStatus
        {
            get => fields.AttemptStatus[this];
            set => fields.AttemptStatus[this] = value;
        }

        [DisplayName("Roll Number"), Size(500)]
        public string RollNumber
        {
            get => fields.RollNumber[this];
            set => fields.RollNumber[this] = value;
        }

        [DisplayName("Student"), NotNull, ForeignKey("[dbo].[Students]", "Id"), LeftJoin("jStudent"), TextualField("StudentFirstName")]
        public long? StudentId
        {
            get => fields.StudentId[this];
            set => fields.StudentId[this] = value;
        }

       

        [DisplayName("Is Active"), NotNull,DefaultValue(1)]
        public short? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        [DisplayName("Tenant Id"), NotNull]
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

        [DisplayName("Student Roll No"), Expression("jStudent.[RollNo]")]
        public long? StudentRollNo
        {
            get => fields.StudentRollNo[this];
            set => fields.StudentRollNo[this] = value;
        }

        [DisplayName("Student First Name"), Expression("jStudent.[FirstName]")]
        public string StudentFirstName
        {
            get => fields.StudentFirstName[this];
            set => fields.StudentFirstName[this] = value;
        }

        [DisplayName("Student Middle Name"), Expression("jStudent.[MiddleName]")]
        public string StudentMiddleName
        {
            get => fields.StudentMiddleName[this];
            set => fields.StudentMiddleName[this] = value;
        }

        [DisplayName("Student Last Name"), Expression("jStudent.[LastName]")]
        public string StudentLastName
        {
            get => fields.StudentLastName[this];
            set => fields.StudentLastName[this] = value;
        }

        [DisplayName("Student Full Name"), Expression("jStudent.[FullName]")]
        public string StudentFullName
        {
            get => fields.StudentFullName[this];
            set => fields.StudentFullName[this] = value;
        }

        [DisplayName("Student Email"), Expression("jStudent.[Email]")]
        public string StudentEmail
        {
            get => fields.StudentEmail[this];
            set => fields.StudentEmail[this] = value;
        }

        [DisplayName("Student Mobile"), Expression("jStudent.[Mobile]")]
        public string StudentMobile
        {
            get => fields.StudentMobile[this];
            set => fields.StudentMobile[this] = value;
        }

        [DisplayName("Student Dob"), Expression("jStudent.[DOB]")]
        public DateTime? StudentDob
        {
            get => fields.StudentDob[this];
            set => fields.StudentDob[this] = value;
        }

        [DisplayName("Student Gender"), Expression("jStudent.[Gender]")]
        public short? StudentGender
        {
            get => fields.StudentGender[this];
            set => fields.StudentGender[this] = value;
        }

        [DisplayName("Student Note"), Expression("jStudent.[Note]")]
        public string StudentNote
        {
            get => fields.StudentNote[this];
            set => fields.StudentNote[this] = value;
        }

        [DisplayName("Student Insert Date"), Expression("jStudent.[InsertDate]")]
        public DateTime? StudentInsertDate
        {
            get => fields.StudentInsertDate[this];
            set => fields.StudentInsertDate[this] = value;
        }

        [DisplayName("Student Insert User Id"), Expression("jStudent.[InsertUserId]")]
        public int? StudentInsertUserId
        {
            get => fields.StudentInsertUserId[this];
            set => fields.StudentInsertUserId[this] = value;
        }

        [DisplayName("Student Update Date"), Expression("jStudent.[UpdateDate]")]
        public DateTime? StudentUpdateDate
        {
            get => fields.StudentUpdateDate[this];
            set => fields.StudentUpdateDate[this] = value;
        }

        [DisplayName("Student Update User Id"), Expression("jStudent.[UpdateUserId]")]
        public int? StudentUpdateUserId
        {
            get => fields.StudentUpdateUserId[this];
            set => fields.StudentUpdateUserId[this] = value;
        }

        [DisplayName("Student Is Active"), Expression("jStudent.[IsActive]")]
        public short? StudentIsActive
        {
            get => fields.StudentIsActive[this];
            set => fields.StudentIsActive[this] = value;
        }

        [DisplayName("Student Tenant Id"), Expression("jStudent.[TenantId]")]
        public int? StudentTenantId
        {
            get => fields.StudentTenantId[this];
            set => fields.StudentTenantId[this] = value;
        }
        public Int32Field TenantIdField
        {
            get => Fields.TenantId;
        }
        public TheoryExamResultsRow()
            : base()
        {
        }

        public TheoryExamResultsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int64Field Id;
            public Int64Field TheoryExamId;
            public StringField StudentScanId;
            public Int64Field TheoryExamQuestionId;
            public SingleField MarksObtained;
            public Int16Field AttemptStatus;
            public StringField RollNumber;
            public Int64Field StudentId;
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

            public Int64Field StudentRollNo;
            public StringField StudentFirstName;
            public StringField StudentMiddleName;
            public StringField StudentLastName;
            public StringField StudentFullName;
            public StringField StudentEmail;
            public StringField StudentMobile;
            public DateTimeField StudentDob;
            public Int16Field StudentGender;
            public StringField StudentNote;
            public DateTimeField StudentInsertDate;
            public Int32Field StudentInsertUserId;
            public DateTimeField StudentUpdateDate;
            public Int32Field StudentUpdateUserId;
            public Int16Field StudentIsActive;
            public Int32Field StudentTenantId;
        }
    }
}