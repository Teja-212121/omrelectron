using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[ImportedScannedBatches]")]
    [DisplayName("Imported Scanned Batch"), InstanceName("Imported Scanned Batch")]
    [ReadPermission(PermissionKeys.ScannedData)]
    [ModifyPermission(PermissionKeys.ScannedData)]
    [LookupScript("Workspace.ImportedScannedBatches", LookupType = typeof(MultiTenantRowLookupScript<>))]
    public sealed class ImportedScannedBatchRow :LoggingRow<ImportedScannedBatchRow.RowFields>, IIdRow, INameRow,IMultiTenantRow,IIsActiveRow
    {
        [DisplayName("Id"), PrimaryKey, NotNull, IdProperty,Insertable(false),Updatable(false)]
        public Guid? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Name"), Size(100), NotNull, QuickSearch, NameProperty]
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

       
        [DisplayName("Is Active"), NotNull,Insertable(false),UpdatePermission(false)]
        public short? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        [DisplayName("Tenant Id"), NotNull, Insertable(false), UpdatePermission(false)]
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
        public ImportedScannedBatchRow()
            : base()
        {
        }

        public ImportedScannedBatchRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public GuidField Id;
            public StringField Name;
            public StringField Description;
            public Int16Field IsActive;
            public Int32Field TenantId;
        }
    }
}