using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[dbo].[Groups]")]
    [DisplayName("Group"), InstanceName("Group")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class GroupRow : Row<GroupRow.RowFields>, IIdRow, INameRow
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

        [DisplayName("Parent"), ForeignKey("[dbo].[Groups]", "Id"), LeftJoin("jParent"), TextualField("ParentName")]
        public int? ParentId
        {
            get => fields.ParentId[this];
            set => fields.ParentId[this] = value;
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

        [DisplayName("Parent Parent Id"), Expression("jParent.[ParentId]")]
        public int? ParentParentId
        {
            get => fields.ParentParentId[this];
            set => fields.ParentParentId[this] = value;
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

        public GroupRow()
            : base()
        {
        }

        public GroupRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Name;
            public StringField Description;
            public Int32Field ParentId;
            public DateTimeField InsertDate;
            public Int32Field InsertUserId;
            public DateTimeField UpdateDate;
            public Int32Field UpdateUserId;
            public Int16Field IsActive;
            public Int32Field TenantId;

            public StringField ParentName;
            public StringField ParentDescription;
            public Int32Field ParentParentId;
            public DateTimeField ParentInsertDate;
            public Int32Field ParentInsertUserId;
            public DateTimeField ParentUpdateDate;
            public Int32Field ParentUpdateUserId;
            public Int16Field ParentIsActive;
            public Int32Field ParentTenantId;
        }
    }
}