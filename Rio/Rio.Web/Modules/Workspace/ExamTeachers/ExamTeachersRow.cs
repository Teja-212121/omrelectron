using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[ExamTeachers]")]
    [DisplayName("Exam Teachers"), InstanceName("Exam Teachers")]
    [ReadPermission(PermissionKeys.StudentManagement.View)]
    [ModifyPermission(PermissionKeys.StudentManagement.Modify)]
    public sealed class ExamTeachersRow : LoggingRow<ExamTeachersRow.RowFields>, IIdRow, IMultiTenantRow
    {
        [DisplayName("Id"), Identity, IdProperty]
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

        [DisplayName("Theory Exam"),  ForeignKey("[TheoryExams]", "Id"), LeftJoin("jTheoryExam"), TextualField("TheoryExamCode")]
        [LookupEditor(typeof(TheoryExamsRow))]
        public long? TheoryExamId
        {
            get => fields.TheoryExamId[this];
            set => fields.TheoryExamId[this] = value;
        }

        [DisplayName("Teacher"), NotNull, ForeignKey("[Teachers]", "Id"), LeftJoin("jTeacher"), TextualField("TeacherFirstName")]
        [LookupEditor(typeof(TeachersRow))]
        public long? TeacherId
        {
            get => fields.TeacherId[this];
            set => fields.TeacherId[this] = value;
        }

       

        [DisplayName("Is Active"), NotNull,DefaultValue(1)]
        public short? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        [DisplayName("Tenant Id"), Insertable(true), Updatable(true)]
        [LookupEditor("Administration.Tenant")]
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

        [DisplayName("Teacher First Name"), Expression("jTeacher.[FirstName]")]
        public string TeacherFirstName
        {
            get => fields.TeacherFirstName[this];
            set => fields.TeacherFirstName[this] = value;
        }

        [DisplayName("Teacher Middle Name"), Expression("jTeacher.[MiddleName]")]
        public string TeacherMiddleName
        {
            get => fields.TeacherMiddleName[this];
            set => fields.TeacherMiddleName[this] = value;
        }

        [DisplayName("Teacher Last Name"), Expression("jTeacher.[LastName]")]
        public string TeacherLastName
        {
            get => fields.TeacherLastName[this];
            set => fields.TeacherLastName[this] = value;
        }

        [DisplayName("Teacher Full Name"), Expression("jTeacher.[FullName]")]
        public string TeacherFullName
        {
            get => fields.TeacherFullName[this];
            set => fields.TeacherFullName[this] = value;
        }

        [DisplayName("Teacher Email"), Expression("jTeacher.[Email]")]
        public string TeacherEmail
        {
            get => fields.TeacherEmail[this];
            set => fields.TeacherEmail[this] = value;
        }

        [DisplayName("Teacher Mobile"), Expression("jTeacher.[Mobile]")]
        public string TeacherMobile
        {
            get => fields.TeacherMobile[this];
            set => fields.TeacherMobile[this] = value;
        }

        [DisplayName("Teacher Dob"), Expression("jTeacher.[DOB]")]
        public DateTime? TeacherDob
        {
            get => fields.TeacherDob[this];
            set => fields.TeacherDob[this] = value;
        }

        [DisplayName("Teacher Allowed Ips"), Expression("jTeacher.[AllowedIps]")]
        public string TeacherAllowedIps
        {
            get => fields.TeacherAllowedIps[this];
            set => fields.TeacherAllowedIps[this] = value;
        }

        [DisplayName("Teacher Address"), Expression("jTeacher.[Address]")]
        public string TeacherAddress
        {
            get => fields.TeacherAddress[this];
            set => fields.TeacherAddress[this] = value;
        }

        [DisplayName("Teacher City"), Expression("jTeacher.[City]")]
        public string TeacherCity
        {
            get => fields.TeacherCity[this];
            set => fields.TeacherCity[this] = value;
        }

        [DisplayName("Teacher User Id"), Expression("jTeacher.[UserId]")]
        public int? TeacherUserId
        {
            get => fields.TeacherUserId[this];
            set => fields.TeacherUserId[this] = value;
        }

        [DisplayName("Teacher Insert Date"), Expression("jTeacher.[InsertDate]")]
        public DateTime? TeacherInsertDate
        {
            get => fields.TeacherInsertDate[this];
            set => fields.TeacherInsertDate[this] = value;
        }

        [DisplayName("Teacher Insert User Id"), Expression("jTeacher.[InsertUserId]")]
        public int? TeacherInsertUserId
        {
            get => fields.TeacherInsertUserId[this];
            set => fields.TeacherInsertUserId[this] = value;
        }

        [DisplayName("Teacher Update Date"), Expression("jTeacher.[UpdateDate]")]
        public DateTime? TeacherUpdateDate
        {
            get => fields.TeacherUpdateDate[this];
            set => fields.TeacherUpdateDate[this] = value;
        }

        [DisplayName("Teacher Update User Id"), Expression("jTeacher.[UpdateUserId]")]
        public int? TeacherUpdateUserId
        {
            get => fields.TeacherUpdateUserId[this];
            set => fields.TeacherUpdateUserId[this] = value;
        }

        [DisplayName("Teacher Is Active"), Expression("jTeacher.[IsActive]")]
        public short? TeacherIsActive
        {
            get => fields.TeacherIsActive[this];
            set => fields.TeacherIsActive[this] = value;
        }

        [DisplayName("Teacher Tenant Id"), Expression("jTeacher.[TenantId]")]
        public int? TeacherTenantId
        {
            get => fields.TeacherTenantId[this];
            set => fields.TeacherTenantId[this] = value;
        }
        public Int32Field TenantIdField
        {
            get => Fields.TenantId;
        }
        public ExamTeachersRow()
            : base()
        {
        }

        public ExamTeachersRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int64Field Id;
            public StringField RowIds;
            public Int64Field TheoryExamId;
            public Int64Field TeacherId;
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

            public StringField TeacherFirstName;
            public StringField TeacherMiddleName;
            public StringField TeacherLastName;
            public StringField TeacherFullName;
            public StringField TeacherEmail;
            public StringField TeacherMobile;
            public DateTimeField TeacherDob;
            public StringField TeacherAllowedIps;
            public StringField TeacherAddress;
            public StringField TeacherCity;
            public Int32Field TeacherUserId;
            public DateTimeField TeacherInsertDate;
            public Int32Field TeacherInsertUserId;
            public DateTimeField TeacherUpdateDate;
            public Int32Field TeacherUpdateUserId;
            public Int16Field TeacherIsActive;
            public Int32Field TeacherTenantId;
        }
    }
}