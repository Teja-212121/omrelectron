using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[dbo].[ScannedBatchAsPerDate]")]
    [DisplayName("Scanned Batch As Per Date"), InstanceName("Scanned Batch As Per Date")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Workspace.ScannedBatchAsPerDate", Permission = "?", LookupType = typeof(MultiTenantRowLookupScript<>))]
    public sealed class ScannedBatchAsPerDateRow : Row<ScannedBatchAsPerDateRow.RowFields>, IIdRow, INameRow, IMultiTenantRow
    {
        [DisplayName("Id"), NotNull, IdProperty]
        public Guid? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Name"), Size(100), NotNull, QuickSearch, NameProperty,LookupInclude]
        public string Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }

        [DisplayName("Scan Batchid"), NotNull, ForeignKey("[ScannedBatches]", "Id"), LeftJoin("jScannedBatch"), TextualField("ScannedBatchName"), LookupInclude]
        [LookupEditor("Workspace.ScannedBatchs")]
        public Guid? ScanBatchid
        {
            get => fields.ScanBatchid[this];
            set => fields.ScanBatchid[this] = value;
        }

        [DisplayName("Insert Date"), NotNull]
        public DateTime? InsertDate
        {
            get => fields.InsertDate[this];
            set => fields.InsertDate[this] = value;
        }

        [DisplayName("Insert User Id"), NotNull,LookupInclude]
        public int? InsertUserId
        {
            get => fields.InsertUserId[this];
            set => fields.InsertUserId[this] = value;
        }

        [DisplayName("Update User Id")]
        public int? UpdateUserId
        {
            get => fields.UpdateUserId[this];
            set => fields.UpdateUserId[this] = value;
        }

        [DisplayName("Update Date")]
        public DateTime? UpdateDate
        {
            get => fields.UpdateDate[this];
            set => fields.UpdateDate[this] = value;
        }

        [DisplayName("Is Active"), NotNull]
        public short? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        [DisplayName("Scanned Batch Insert Date"), Expression("jScannedBatch.[InsertDate]"), LookupInclude]
        public DateTime? ScannedBatchInsertDate
        {
            get => fields.ScannedBatchInsertDate[this];
            set => fields.ScannedBatchInsertDate[this] = value;
        }

        public Int32Field TenantIdField
        {
            get => Fields.TenantId;
        }

        [DisplayName("Tenant Id"), NotNull]
        public int? TenantId
        {
            get => fields.TenantId[this];
            set => fields.TenantId[this] = value;
        }

        public ScannedBatchAsPerDateRow()
            : base()
        {
        }

        public ScannedBatchAsPerDateRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public GuidField Id;
            public StringField Name;
            public GuidField ScanBatchid;
            public DateTimeField InsertDate;
            public Int32Field InsertUserId;
            public Int32Field UpdateUserId;
            public DateTimeField UpdateDate;
            public DateTimeField ScannedBatchInsertDate;
            public Int16Field IsActive;
            public Int32Field TenantId;
        }
    }
}