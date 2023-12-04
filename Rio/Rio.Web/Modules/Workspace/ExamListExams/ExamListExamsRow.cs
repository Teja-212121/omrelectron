using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("ExamListExams")]
    [DisplayName("Exam List Exams"), InstanceName("Exam List Exams")]
    [ReadPermission(PermissionKeys.ExamListManagement.View)]
    [ModifyPermission(PermissionKeys.ExamListManagement.Modify)]
    [LookupScript("Workspace.ExamListExams", Permission = "*")]
    public sealed class ExamListExamsRow : LoggingRow<ExamListExamsRow.RowFields>, IIdRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Exam List"), NotNull, ForeignKey("ExamLists", "Id"), LeftJoin("jExamList"), TextualField("ExamListName")]
        [LookupEditor("Workspace.ExamList")]
        public int? ExamListId
        {
            get => fields.ExamListId[this];
            set => fields.ExamListId[this] = value;
        }

        [DisplayName("Exam"), NotNull, ForeignKey("Exams", "Id"), LeftJoin("jExam"), TextualField("ExamCode")]
        [LookupEditor("Workspace.Exam")]
        public int? ExamId
        {
            get => fields.ExamId[this];
            set => fields.ExamId[this] = value;
        }

        [DisplayName("Tenant"), NotNull, ForeignKey("Tenants", "TenantId"), LeftJoin("jTenant"), TextualField("TenantTenantName")]
        [LookupEditor("Administration.Tenant")]
        public int? TenantId
        {
            get => fields.TenantId[this];
            set => fields.TenantId[this] = value;
        }

        [DisplayName("Priority"), NotNull]
        public int? Priority
        {
            get => fields.Priority[this];
            set => fields.Priority[this] = value;
        }

        [DisplayName("Start Date")]
        public DateTime? StartDate
        {
            get => fields.StartDate[this];
            set => fields.StartDate[this] = value;
        }

        [DisplayName("End Date")]
        public DateTime? EndDate
        {
            get => fields.EndDate[this];
            set => fields.EndDate[this] = value;
        }

        [DisplayName("Model Answer Paper Start Date")]
        public DateTime? ModelAnswerPaperStartDate
        {
            get => fields.ModelAnswerPaperStartDate[this];
            set => fields.ModelAnswerPaperStartDate[this] = value;
        }

        [DisplayName("Is Active"), DefaultValue(1)]
        public int? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        [DisplayName("Exam List Name"), Expression("jExamList.[Name]")]
        public string ExamListName
        {
            get => fields.ExamListName[this];
            set => fields.ExamListName[this] = value;
        }

        [DisplayName("Exam List Description"), Expression("jExamList.[Description]")]
        public string ExamListDescription
        {
            get => fields.ExamListDescription[this];
            set => fields.ExamListDescription[this] = value;
        }

        [DisplayName("Exam List Insert Date"), Expression("jExamList.[InsertDate]")]
        public DateTime? ExamListInsertDate
        {
            get => fields.ExamListInsertDate[this];
            set => fields.ExamListInsertDate[this] = value;
        }

        [DisplayName("Exam List Insert User Id"), Expression("jExamList.[InsertUserId]")]
        public int? ExamListInsertUserId
        {
            get => fields.ExamListInsertUserId[this];
            set => fields.ExamListInsertUserId[this] = value;
        }

        [DisplayName("Exam List Update Date"), Expression("jExamList.[UpdateDate]")]
        public DateTime? ExamListUpdateDate
        {
            get => fields.ExamListUpdateDate[this];
            set => fields.ExamListUpdateDate[this] = value;
        }

        [DisplayName("Exam List Update User Id"), Expression("jExamList.[UpdateUserId]")]
        public int? ExamListUpdateUserId
        {
            get => fields.ExamListUpdateUserId[this];
            set => fields.ExamListUpdateUserId[this] = value;
        }

        [DisplayName("Exam List Is Active"), Expression("jExamList.[IsActive]")]
        public int? ExamListIsActive
        {
            get => fields.ExamListIsActive[this];
            set => fields.ExamListIsActive[this] = value;
        }

        [DisplayName("Exam List Tenant Id"), Expression("jExamList.[TenantId]")]
        public int? ExamListTenantId
        {
            get => fields.ExamListTenantId[this];
            set => fields.ExamListTenantId[this] = value;
        }

        [DisplayName("Exam Code"), Expression("jExam.[Code]")]
        public string ExamCode
        {
            get => fields.ExamCode[this];
            set => fields.ExamCode[this] = value;
        }
        [NotMapped]
        public String RowIds
        {
            get => fields.RowIds[this];
            set => fields.RowIds[this] = value;
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
        public decimal? ExamNegativeMarks
        {
            get => fields.ExamNegativeMarks[this];
            set => fields.ExamNegativeMarks[this] = value;
        }

        [DisplayName("Exam Options Available"), Expression("jExam.[OptionsAvailable]")]
        public int? ExamOptionsAvailable
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
        public int? ExamIsActive
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

        [DisplayName("Exam Total Questions"), Expression("jExam.[TotalQuestions]")]
        public int? ExamTotalQuestions
        {
            get => fields.ExamTotalQuestions[this];
            set => fields.ExamTotalQuestions[this] = value;
        }

        [DisplayName("Exam Exam Display Name"), Expression("jExam.[ExamDisplayName]")]
        public string ExamExamDisplayName
        {
            get => fields.ExamExamDisplayName[this];
            set => fields.ExamExamDisplayName[this] = value;
        }

        [DisplayName("Exam Question Paper"), Expression("jExam.[QuestionPaper]")]
        public string ExamQuestionPaper
        {
            get => fields.ExamQuestionPaper[this];
            set => fields.ExamQuestionPaper[this] = value;
        }

        [DisplayName("Exam Model Answer"), Expression("jExam.[ModelAnswer]")]
        public string ExamModelAnswer
        {
            get => fields.ExamModelAnswer[this];
            set => fields.ExamModelAnswer[this] = value;
        }

        [DisplayName("Exam Sheet Type Id"), Expression("jExam.[SheetTypeId]")]
        public int? ExamSheetTypeId
        {
            get => fields.ExamSheetTypeId[this];
            set => fields.ExamSheetTypeId[this] = value;
        }

        [DisplayName("Tenant Tenant Name"), Expression("jTenant.[TenantName]")]
        public string TenantTenantName
        {
            get => fields.TenantTenantName[this];
            set => fields.TenantTenantName[this] = value;
        }

        [DisplayName("Tenant E Approval Status"), Expression("jTenant.[EApprovalStatus]")]
        public int? TenantEApprovalStatus
        {
            get => fields.TenantEApprovalStatus[this];
            set => fields.TenantEApprovalStatus[this] = value;
        }

        [DisplayName("Tenant Is Active"), Expression("jTenant.[IsActive]")]
        public int? TenantIsActive
        {
            get => fields.TenantIsActive[this];
            set => fields.TenantIsActive[this] = value;
        }

        public ExamListExamsRow()
            : base()
        {
        }

        public ExamListExamsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields :LoggingRowFields
        {
            public Int32Field Id;
            public Int32Field ExamListId;
            public Int32Field ExamId;
            public Int32Field TenantId;
            public Int32Field Priority;
            public DateTimeField StartDate;
            public DateTimeField EndDate;
            public DateTimeField ModelAnswerPaperStartDate;

            public StringField RowIds;
            public Int32Field IsActive;

            public StringField ExamListName;
            public StringField ExamListDescription;
            public DateTimeField ExamListInsertDate;
            public Int32Field ExamListInsertUserId;
            public DateTimeField ExamListUpdateDate;
            public Int32Field ExamListUpdateUserId;
            public Int32Field ExamListIsActive;
            public Int32Field ExamListTenantId;

            public StringField ExamCode;
            public StringField ExamName;
            public StringField ExamDescription;
            public Int32Field ExamTotalMarks;
            public DecimalField ExamNegativeMarks;
            public Int32Field ExamOptionsAvailable;
            public StringField ExamResultCriteria;
            public DateTimeField ExamInsertDate;
            public Int32Field ExamInsertUserId;
            public DateTimeField ExamUpdateDate;
            public Int32Field ExamUpdateUserId;
            public Int32Field ExamIsActive;
            public Int32Field ExamTenantId;
            public Int32Field ExamTotalQuestions;
            public StringField ExamExamDisplayName;
            public StringField ExamQuestionPaper;
            public StringField ExamModelAnswer;
            public Int32Field ExamSheetTypeId;

            public StringField TenantTenantName;
            public Int32Field TenantEApprovalStatus;
            public Int32Field TenantIsActive;
        }
    }
}