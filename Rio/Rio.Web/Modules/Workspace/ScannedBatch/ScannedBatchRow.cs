using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[ScannedBatches]")]
    [DisplayName("Scanned Batch"), InstanceName("Scanned Batch")]
    [ReadPermission(PermissionKeys.ScannedDataManagement.View)]
    [ModifyPermission(PermissionKeys.ScannedDataManagement.Modify)]
    [LookupScript("Workspace.ScannedBatchs", Permission = "*", LookupType = typeof(MultiTenantRowLookupScript<>),Expiration =1)]
    public sealed class ScannedBatchRow :LoggingRow<ScannedBatchRow.RowFields>, IIdRow, INameRow,IMultiTenantRow,IIsActiveRow
    {
        [DisplayName("Id"), PrimaryKey, NotNull, IdProperty, Insertable(false), Updatable(false)]
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

        [NotMapped]
        public List<ScannedSheetRow> ScannedSheets
        {
            get { return Fields.ScannedSheets[this]; }
            set { Fields.ScannedSheets[this] = value; }
        }
        [NotMapped]
        public List<ScannedQuestionRow> ScannedQuestions
        {
            get { return Fields.ScannedQuestions[this]; }
            set { Fields.ScannedQuestions[this] = value; }
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

        public class RowFields : LoggingRowFields
        {
            public GuidField Id;
            public StringField Name;
            public StringField Description;
            public Int16Field IsActive;
            public Int32Field TenantId;
            public ListField<ScannedSheetRow> ScannedSheets;
            public ListField<ScannedQuestionRow> ScannedQuestions;
        }
    }
}