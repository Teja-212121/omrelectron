using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[Exams]")]
    [DisplayName("Exam"), InstanceName("Exam")]
    [ReadPermission(PermissionKeys.ExamsAndSectionManagement.View)]
    [ModifyPermission(PermissionKeys.ExamsAndSectionManagement.Modify)]
    [LookupScript("Workspace.Exam", Permission = "*", Expiration = 1, LookupType = typeof(MultiTenantRowLookupScript<>))]
    public sealed class ExamRow : LoggingRow<ExamRow.RowFields>, IIdRow, INameRow, IIsActiveRow, IMultiTenantRow
    {
        [DisplayName("Id"), Identity, IdProperty, QuickSearch]
        [SortOrder(1, descending: true)]
        public long? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Code"), Size(100), NotNull, QuickSearch]
        public string Code
        {
            get => fields.Code[this];
            set => fields.Code[this] = value;
        }

        [DisplayName("Name"), Size(500), NotNull, NameProperty, QuickSearch]
        public string Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }

        [DisplayName("Description"), Size(1000)]
        public string Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        [DisplayName("Total Questions"), NotNull]
        public int? TotalQuestions
        {
            get => fields.TotalQuestions[this];
            set => fields.TotalQuestions[this] = value;
        }

        [DisplayName("Total Marks"), NotNull]
        public int? TotalMarks
        {
            get => fields.TotalMarks[this];
            set => fields.TotalMarks[this] = value;
        }

        [DisplayName("Negative Marks")]
        public float? NegativeMarks
        {
            get => fields.NegativeMarks[this];
            set => fields.NegativeMarks[this] = value;
        }

        [DisplayName("Options Available")]
        public short? OptionsAvailable
        {
            get => fields.OptionsAvailable[this];
            set => fields.OptionsAvailable[this] = value;
        }

        [DisplayName("Result Criteria"), Size(1000)]
        public string ResultCriteria
        {
            get => fields.ResultCriteria[this];
            set => fields.ResultCriteria[this] = value;
        }

        [DisplayName("Is Active"), NotNull, Insertable(false), Updatable(true)]
        public short? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        [DisplayName("Tenant Id"), NotNull, Insertable(false), Updatable(true)]
        [LookupEditor("Administration.Tenant")]
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
       

        public ExamRow()
            : base()
        {
        }

        public ExamRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int64Field Id;
            public StringField Code;
            public StringField Name;
            public StringField Description;
            public Int32Field TotalQuestions;
            public Int32Field TotalMarks;
            public SingleField NegativeMarks;
            public Int16Field OptionsAvailable;
            public StringField ResultCriteria;
           
            public Int16Field IsActive;
            public Int32Field TenantId;
        }
    }
}