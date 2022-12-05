using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[ScannedBatches]")]
    [DisplayName("Scanned Batch"), InstanceName("Scanned Batch")]
    [ReadPermission(PermissionKeys.ScannedDataManagement.View)]
    [ModifyPermission(PermissionKeys.ScannedDataManagement.Modify)]
    [LookupScript("Workspace.ScannedBatchs", Permission = "*", LookupType = typeof(MultiTenantRowLookupScript<>))]
    public sealed class ScannedBatchRow :Row<ScannedBatchRow.RowFields>, IIdRow, INameRow,IMultiTenantRow,IIsActiveRow
    {
        [DisplayName("Id"), PrimaryKey, NotNull, IdProperty, Insertable(false), Updatable(false), LookupInclude]
        [SortOrder(1,descending:true)]
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

        [DisplayName("Insert Date"), LookupInclude]
        public DateTime? InsertDate
        {
            get => fields.InsertDate[this];
            set => fields.InsertDate[this] = value;
        }

        [DisplayName("Insert User Id")]
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

        [DisplayName("Is Active"), NotNull,Insertable(false),Updatable(true)]
        public short? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        [DisplayName("Tenant Id"), NotNull]
        [Insertable(false), Updatable(false)]
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
        public ScannedBatchRow()
            : base()
        {
        }

        public ScannedBatchRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public GuidField Id;
            public StringField Name;
            public StringField Description;
            public Int16Field IsActive;
            public Int32Field TenantId;
            public DateTimeField InsertDate;
            public Int32Field InsertUserId;
            public DateTimeField UpdateDate;
            public Int32Field UpdateUserId;
            
        }
    }
}