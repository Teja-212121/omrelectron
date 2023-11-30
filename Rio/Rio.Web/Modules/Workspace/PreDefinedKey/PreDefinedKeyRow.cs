using Rio.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("PreDefinedKeys")]
    [DisplayName("Pre Defined Key"), InstanceName("Pre Defined Key")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class PreDefinedKeyRow : LoggingRow<PreDefinedKeyRow.RowFields>, IIdRow, INameRow
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
        public PreDefinedKeyStatus? EStatus
        {
            get => (PreDefinedKeyStatus?)fields.EStatus[this];
            set => fields.EStatus[this] = (short?)value;
        }

        [DisplayName("Is Active"), DefaultValue(1)]
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

        public class RowFields : LoggingRowFields
        {
            public Int32Field Id;
            public StringField SerialKey;
            public Int32Field EStatus;
          
            public Int32Field IsActive;
        }
    }
}