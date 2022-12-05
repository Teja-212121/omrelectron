using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using Serenity.Extensions.Entities;
using System.ComponentModel;
using System.Collections.Generic;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[dbo].[TheoryExams]")]
    [DisplayName("Theory Exams"), InstanceName("Theory Exams")]
    [ReadPermission(PermissionKeys.ExamsAndSectionManagement.View)]
    [ModifyPermission(PermissionKeys.ExamsAndSectionManagement.Modify)]
    [LookupScript("Workspace.TheoryExams", Permission = "?", Expiration = 1, LookupType = typeof(MultiTenantRowLookupScript<>))]
    public sealed class TheoryExamsRow : LoggingRow<TheoryExamsRow.RowFields>, IIdRow, INameRow, IMultiTenantRow
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

        [DisplayName("Code"), Size(100), NotNull, QuickSearch, NameProperty]
        public string Code
        {
            get => fields.Code[this];
            set => fields.Code[this] = value;
        }

        [DisplayName("Name"), Size(500), NotNull]
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

        [DisplayName("Total Marks"), NotNull]
        public int? TotalMarks
        {
            get => fields.TotalMarks[this];
            set => fields.TotalMarks[this] = value;
        }

        [NotMapped]
        public List<TheoryExamSectionsRow> ExamSections
        {
            get { return Fields.ExamSections[this]; }
            set { Fields.ExamSections[this] = value; }
        }
        [NotMapped]
        public List<TheoryExamQuestionsRow> ExamQuestions
        {
            get { return Fields.ExamQuestions[this]; }
            set { Fields.ExamQuestions[this] = value; }
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

        public TheoryExamsRow()
            : base()
        {
        }

        public TheoryExamsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int64Field Id;
            public StringField RowIds;
            public StringField Code;
            public StringField Name;
            public StringField Description;
            public Int32Field TotalMarks;
            public Int16Field IsActive;
            public Int32Field TenantId;
            public ListField<TheoryExamSectionsRow> ExamSections;            
            public RowListField<TheoryExamQuestionsRow> ExamQuestions;
        }
    }
}