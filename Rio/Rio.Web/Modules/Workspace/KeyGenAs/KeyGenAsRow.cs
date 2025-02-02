using Rio.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("KeyGenAs")]
    [DisplayName("Key Gen As"), InstanceName("Key Gen As")]
    [ReadPermission(PermissionKeys.ActivationManagement.View)]
    [ModifyPermission(PermissionKeys.ActivationManagement.Modify)]
    public sealed class KeyGenAsRow : LoggingRow<KeyGenAsRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Quantity"), NotNull]
        public int? Quantity
        {
            get => fields.Quantity[this];
            set => fields.Quantity[this] = value;
        }

        [DisplayName("Exam List"), NotNull, ForeignKey("ExamLists", "Id"), LeftJoin("jExamList"), TextualField("ExamListName")]
        [LookupEditor("Workspace.ExamList")]
        public int? ExamListId
        {
            get => fields.ExamListId[this];
            set => fields.ExamListId[this] = value;
        }

        [DisplayName("Validity Type"), NotNull]
        public EValidityType? ValidityType
        {
            get => (EValidityType?)fields.ValidityType[this];
            set => fields.ValidityType[this] = (short?)value;
        }

        [DisplayName("Validity In Days")]
        public int? ValidityInDays
        {
            get => fields.ValidityInDays[this];
            set => fields.ValidityInDays[this] = value;
        }

        [DisplayName("Valid Date")]
        public DateTime? ValidDate
        {
            get => fields.ValidDate[this];
            set => fields.ValidDate[this] = value;
        }

        [DisplayName("Note"), QuickSearch, NameProperty]
        public string Note
        {
            get => fields.Note[this];
            set => fields.Note[this] = value;
        }

        [DisplayName("E Status"), Column("eStatus"),DefaultValue(2)]
        public KeyStatus? EStatus
        {
            get => (KeyStatus?)fields.EStatus[this];
            set => fields.EStatus[this] = (short?)value;
        }



        [DisplayName("Is Active"), NotNull,DefaultValue(1)]
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

        public KeyGenAsRow()
            : base()
        {
        }

        public KeyGenAsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int32Field Id;
            public Int32Field Quantity;
            public Int32Field ExamListId;
            public Int32Field ValidityType;
            public Int32Field ValidityInDays;
            public DateTimeField ValidDate;
            public StringField Note;
            public Int32Field EStatus;
           
            public Int32Field IsActive;

            public StringField ExamListName;
            public StringField ExamListDescription;
            public DateTimeField ExamListInsertDate;
            public Int32Field ExamListInsertUserId;
            public DateTimeField ExamListUpdateDate;
            public Int32Field ExamListUpdateUserId;
            public Int32Field ExamListIsActive;
            public Int32Field ExamListTenantId;
        }
    }
}