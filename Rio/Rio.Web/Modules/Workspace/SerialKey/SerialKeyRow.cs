using Rio.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("SerialKeys")]
    [DisplayName("Serial Key"), InstanceName("Serial Key")]
    [ReadPermission(PermissionKeys.ActivationManagement.View)]
    [ModifyPermission(PermissionKeys.ActivationManagement.Modify)]
    [LookupScript("Workspace.SerialKey",LookupType = typeof(MultiTenantRowLookupScript<>), Expiration = 1)]
    public sealed class SerialKeyRow : LoggingRow<SerialKeyRow.RowFields>, IIdRow, INameRow, IMultiTenantRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        [SortOrder(1, descending: true)]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Serial Key"),  QuickSearch, NameProperty]
        public string SerialKey
        {
            get => fields.SerialKey[this];
            set => fields.SerialKey[this] = value;
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

        [DisplayName("Note")]
        public string Note
        {
            get => fields.Note[this];
            set => fields.Note[this] = value;
        }

        [DisplayName("E Status"), Column("eStatus")]
        public KeyStatus? EStatus
        {
            get => (KeyStatus?)fields.EStatus[this];
            set => fields.EStatus[this] = (short?)value;
        }

        [DisplayName("KeyGenAsId")]
        public Int32? KeyGenAsId
        {
            get { return Fields.KeyGenAsId[this]; }
            set { Fields.KeyGenAsId[this] = value; }
        }

        [DisplayName("Is Active"), DefaultValue(1)]
        public int? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        [DisplayName("Tenant"), NotNull, ForeignKey("Tenants", "TenantId"), LeftJoin("jTenant"), TextualField("TenantTenantName")]
        public int? TenantId
        {
            get => fields.TenantId[this];
            set => fields.TenantId[this] = value;
        }

        public Int32Field TenantIdField
        {
            get => Fields.TenantId;
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

        public SerialKeyRow()
            : base()
        {
        }

        public SerialKeyRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields :LoggingRowFields
        {
            public Int32Field Id;
            public StringField SerialKey;
            public Int32Field ExamListId;
            public Int32Field ValidityType;
            public Int32Field ValidityInDays;
            public Int32Field KeyGenAsId;
            public DateTimeField ValidDate;
            public StringField Note;
            public Int32Field EStatus;
            public Int32Field TenantId;
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