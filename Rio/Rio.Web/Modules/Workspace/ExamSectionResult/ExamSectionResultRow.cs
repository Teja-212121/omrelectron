using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[ExamSectionResults]")]
    [DisplayName("Exam Section Result"), InstanceName("Exam Section Result")]
    [ReadPermission(PermissionKeys.Exams)]
    [ModifyPermission(PermissionKeys.Exams)]
    public sealed class ExamSectionResultRow : LoggingRow<ExamSectionResultRow.RowFields>, IIdRow, INameRow, IIsActiveRow, IMultiTenantRow
    
    {
        [DisplayName("Id"), Identity, IdProperty]
        [SortOrder(1, descending: true)]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Student"), NotNull, ForeignKey("[Students]", "Id"), LeftJoin("jStudent"), TextualField("StudentFirstName")]
        [LookupEditor("Workspace.Student")]
        public long? StudentId
        {
            get => fields.StudentId[this];
            set => fields.StudentId[this] = value;
        }

        [DisplayName("Roll Number"), NotNull]
        public long? RollNumber
        {
            get => fields.RollNumber[this];
            set => fields.RollNumber[this] = value;
        }

        [DisplayName("Sheet Number"), Size(50), QuickSearch, NameProperty]
        public string SheetNumber
        {
            get => fields.SheetNumber[this];
            set => fields.SheetNumber[this] = value;
        }

        [DisplayName("Sheet Guid"), NotNull]
        public Guid? SheetGuid
        {
            get => fields.SheetGuid[this];
            set => fields.SheetGuid[this] = value;
        }

        [DisplayName("Exam"), NotNull, ForeignKey("[Exams]", "Id"), LeftJoin("jExam"), TextualField("ExamCode")]
        [LookupEditor(typeof(ExamRow))]
        public long? ExamId
        {
            get => fields.ExamId[this];
            set => fields.ExamId[this] = value;
        }

        [DisplayName("Exam Section"), NotNull, ForeignKey("[ExamSections]", "Id"), LeftJoin("jExamSection"), TextualField("ExamSectionName")]
        [LookupEditor("Workspace.ExamSection", CascadeFrom = "ExamId")]
        public int? ExamSectionId
        {
            get => fields.ExamSectionId[this];
            set => fields.ExamSectionId[this] = value;
        }

        [DisplayName("Total Marks"), NotNull]
        public float? TotalMarks
        {
            get => fields.TotalMarks[this];
            set => fields.TotalMarks[this] = value;
        }

        [DisplayName("Obtained Marks"), NotNull]
        public float? ObtainedMarks
        {
            get => fields.ObtainedMarks[this];
            set => fields.ObtainedMarks[this] = value;
        }

        [DisplayName("Percentage"), NotNull]
        public float? Percentage
        {
            get => fields.Percentage[this];
            set => fields.Percentage[this] = value;
        }

        [DisplayName("Total Questions"), NotNull]
        public int? TotalQuestions
        {
            get => fields.TotalQuestions[this];
            set => fields.TotalQuestions[this] = value;
        }

        [DisplayName("Total Attempted"), NotNull]
        public int? TotalAttempted
        {
            get => fields.TotalAttempted[this];
            set => fields.TotalAttempted[this] = value;
        }

        [DisplayName("Total Not Attempted"), NotNull]
        public int? TotalNotAttempted
        {
            get => fields.TotalNotAttempted[this];
            set => fields.TotalNotAttempted[this] = value;
        }

        [DisplayName("Total Right Answers"), NotNull]
        public int? TotalRightAnswers
        {
            get => fields.TotalRightAnswers[this];
            set => fields.TotalRightAnswers[this] = value;
        }

        [DisplayName("Total Wrong Answers"), NotNull]
        public int? TotalWrongAnswers
        {
            get => fields.TotalWrongAnswers[this];
            set => fields.TotalWrongAnswers[this] = value;
        }

        

        [DisplayName("Is Active"), NotNull, Insertable(false), Updatable(true)]
        public short? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        [DisplayName("Tenant Id"), NotNull, Insertable(false), Updatable(true)]
        public int? TenantId
        {
            get => fields.TenantId[this];
            set => fields.TenantId[this] = value;
        }
        public Int32Field TenantIdField
        {
            get => Fields.TenantId;
        }
        Int16Field IIsActiveRow.IsActiveField
        {
            get => fields.IsActive;
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

        [DisplayName("Exam Code"), Expression("jExam.[Code]")]
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

        [DisplayName("Exam Section Name"), Expression("jExamSection.[Name]")]
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

        public ExamSectionResultRow()
            : base()
        {
        }

        public ExamSectionResultRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int32Field Id;
            public Int64Field StudentId;
            public Int64Field RollNumber;
            public StringField SheetNumber;
            public GuidField SheetGuid;
            public Int64Field ExamId;
            public Int32Field ExamSectionId;
            public SingleField TotalMarks;
            public SingleField ObtainedMarks;
            public SingleField Percentage;
            public Int32Field TotalQuestions;
            public Int32Field TotalAttempted;
            public Int32Field TotalNotAttempted;
            public Int32Field TotalRightAnswers;
            public Int32Field TotalWrongAnswers;
            
            public Int16Field IsActive;
            public Int32Field TenantId;

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
        }
    }
}