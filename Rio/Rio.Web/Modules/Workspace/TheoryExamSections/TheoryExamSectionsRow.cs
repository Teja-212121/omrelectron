using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using Serenity.Extensions.Entities;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[TheoryExamSections]")]
    [DisplayName("Theory Exam Sections"), InstanceName("Theory Exam Sections")]
    [ReadPermission(PermissionKeys.TheoryExamManagement.View)]
    [ModifyPermission(PermissionKeys.TheoryExamManagement.Modify)]
    [LookupScript("Workspace.TheoryExamSections", Permission = "?", Expiration = 1, LookupType = typeof(MultiTenantRowLookupScript<>))]
    public sealed class TheoryExamSectionsRow : LoggingRow<TheoryExamSectionsRow.RowFields>, IIdRow, INameRow, IMultiTenantRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Name"), Size(500), NotNull, QuickSearch, NameProperty]
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

        [DisplayName("Theory Exam"), NotNull, ForeignKey("[TheoryExams]", "Id"), LeftJoin("jTheoryExam"), TextualField("TheoryExamCode")]
        [LookupEditor(typeof(TheoryExamsRow)), LookupInclude]
        public long? TheoryExamId
        {
            get => fields.TheoryExamId[this];
            set => fields.TheoryExamId[this] = value;
        }

        [DisplayName("Parent"), ForeignKey("[TheoryExamSections]", "Id"), LeftJoin("jParent"), TextualField("ParentName")]
        public int? ParentId
        {
            get => fields.ParentId[this];
            set => fields.ParentId[this] = value;
        }

        [DisplayName("Sort Order")]
        public float? SortOrder
        {
            get => fields.SortOrder[this];
            set => fields.SortOrder[this] = value;
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

        [DisplayName("Parent Name"), Expression("jParent.[Name]")]
        public string ParentName
        {
            get => fields.ParentName[this];
            set => fields.ParentName[this] = value;
        }

        [DisplayName("Parent Description"), Expression("jParent.[Description]")]
        public string ParentDescription
        {
            get => fields.ParentDescription[this];
            set => fields.ParentDescription[this] = value;
        }

        [DisplayName("Parent Theory Exam Id"), Expression("jParent.[TheoryExamId]")]
        public long? ParentTheoryExamId
        {
            get => fields.ParentTheoryExamId[this];
            set => fields.ParentTheoryExamId[this] = value;
        }

        [DisplayName("Parent Parent Id"), Expression("jParent.[ParentId]")]
        public int? ParentParentId
        {
            get => fields.ParentParentId[this];
            set => fields.ParentParentId[this] = value;
        }

        [DisplayName("Parent Sort Order"), Expression("jParent.[SortOrder]")]
        public float? ParentSortOrder
        {
            get => fields.ParentSortOrder[this];
            set => fields.ParentSortOrder[this] = value;
        }

        [DisplayName("Parent Insert Date"), Expression("jParent.[InsertDate]")]
        public DateTime? ParentInsertDate
        {
            get => fields.ParentInsertDate[this];
            set => fields.ParentInsertDate[this] = value;
        }

        [DisplayName("Parent Insert User Id"), Expression("jParent.[InsertUserId]")]
        public int? ParentInsertUserId
        {
            get => fields.ParentInsertUserId[this];
            set => fields.ParentInsertUserId[this] = value;
        }

        [DisplayName("Parent Update Date"), Expression("jParent.[UpdateDate]")]
        public DateTime? ParentUpdateDate
        {
            get => fields.ParentUpdateDate[this];
            set => fields.ParentUpdateDate[this] = value;
        }

        [DisplayName("Parent Update User Id"), Expression("jParent.[UpdateUserId]")]
        public int? ParentUpdateUserId
        {
            get => fields.ParentUpdateUserId[this];
            set => fields.ParentUpdateUserId[this] = value;
        }

        [DisplayName("Parent Is Active"), Expression("jParent.[IsActive]")]
        public short? ParentIsActive
        {
            get => fields.ParentIsActive[this];
            set => fields.ParentIsActive[this] = value;
        }

        [DisplayName("Parent Tenant Id"), Expression("jParent.[TenantId]")]
        public int? ParentTenantId
        {
            get => fields.ParentTenantId[this];
            set => fields.ParentTenantId[this] = value;
        }

        public TheoryExamSectionsRow()
            : base()
        {
        }

        public TheoryExamSectionsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int32Field Id;
            public StringField Name;
            public StringField Description;
            public Int64Field TheoryExamId;
            public Int32Field ParentId;
            public SingleField SortOrder;
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

            public StringField ParentName;
            public StringField ParentDescription;
            public Int64Field ParentTheoryExamId;
            public Int32Field ParentParentId;
            public SingleField ParentSortOrder;
            public DateTimeField ParentInsertDate;
            public Int32Field ParentInsertUserId;
            public DateTimeField ParentUpdateDate;
            public Int32Field ParentUpdateUserId;
            public Int16Field ParentIsActive;
            public Int32Field ParentTenantId;
        }
    }
}