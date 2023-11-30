using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("PreDefinedKeys")]
    [DisplayName("Pre Defined Key"), InstanceName("Pre Defined Key")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class PreDefinedKeyRow : Row<PreDefinedKeyRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Serial Key"), NotNull, QuickSearch, NameProperty]
        public string SerialKey
        {
            get => fields.SerialKey[this];
            set => fields.SerialKey[this] = value;
        }

        [DisplayName("E Status"), Column("eStatus")]
        public int? EStatus
        {
            get => fields.EStatus[this];
            set => fields.EStatus[this] = value;
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
        public int? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        public PreDefinedKeyRow()
            : base()
        {
        }

        public PreDefinedKeyRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField SerialKey;
            public Int32Field EStatus;
            public DateTimeField InsertDate;
            public Int32Field InsertUserId;
            public DateTimeField UpdateDate;
            public Int32Field UpdateUserId;
            public Int32Field IsActive;
        }
    }
}