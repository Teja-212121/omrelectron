using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[dbo].[Exams]")]
    [DisplayName("Exam"), InstanceName("Exam")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ExamRow : Row<ExamRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public long? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
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

        [DisplayName("Insert Date"), NotNull]
        public DateTime? InsertDate
        {
            get => fields.InsertDate[this];
            set => fields.InsertDate[this] = value;
        }

        [DisplayName("Insert User Id"), NotNull]
        public int? InsertUserId
        {
            get => fields.InsertUserId[this];
            set => fields.InsertUserId[this] = value;
        }

        [DisplayName("Update Date")]
        public DateTime? UpdateDate
        {
            get => fields.UpdateDate[this];
            set => fields.UpdateDate[this] = value;
        }

        [DisplayName("Update User Id")]
        public int? UpdateUserId
        {
            get => fields.UpdateUserId[this];
            set => fields.UpdateUserId[this] = value;
        }

        [DisplayName("Is Active"), NotNull]
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

        public ExamRow()
            : base()
        {
        }

        public ExamRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public StringField Code;
            public StringField Name;
            public StringField Description;
            public Int32Field TotalMarks;
            public SingleField NegativeMarks;
            public Int16Field OptionsAvailable;
            public StringField ResultCriteria;
            public DateTimeField InsertDate;
            public Int32Field InsertUserId;
            public DateTimeField UpdateDate;
            public Int32Field UpdateUserId;
            public Int16Field IsActive;
            public Int32Field TenantId;
        }
    }
}