using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[Groups]")]
    [DisplayName("Group"), InstanceName("Group")]
    [ReadPermission(PermissionKeys.GroupManagement.View)]
    [ModifyPermission(PermissionKeys.GroupManagement.Modify)]
    [LookupScript("Workspace.Group", Permission = "*", LookupType = typeof(MultiTenantRowLookupScript<>))]
    public sealed class GroupRow : LoggingRow<GroupRow.RowFields>, IIdRow, INameRow, IMultiTenantRow, IIsActiveRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        [SortOrder(1, descending: true)]
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

        [DisplayName("Parent"), ForeignKey("[Groups]", "Id"), LeftJoin("jParent"), TextualField("ParentName")]
        [LookupEditor("Workspace.Group")]
        public int? ParentId
        {
            get => fields.ParentId[this];
            set => fields.ParentId[this] = value;
        }

        [DisplayName("Is Active"), NotNull, Insertable(false), Updatable(true)]
        public short? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }
        [DisplayName("Teacher"),  ForeignKey("Teachers", "Id"), LeftJoin("jTeacher"), TextualField("TeacherFirstName")]
        [LookupEditor("Workspace.Teachers")]
        public long? TeacherId
        {
            get => fields.TeacherId[this];
            set => fields.TeacherId[this] = value;
        }
        [DisplayName("Tenant Id"), ForeignKey("[Tenants]", "TenantId"), LeftJoin("jTenant"), TextualField("TenantName")]
        [LookupEditor("Administration.Tenant")]
        public int? TenantId
        {
            get => fields.TenantId[this];
            set => fields.TenantId[this] = value;
        }

        [DisplayName("Tenant Name"), Expression("jTenant.[TenantName]")]
        public string TenantName
        {
            get => fields.TenantName[this];
            set => fields.TenantName[this] = value;
        }

        [DisplayName("Tenant Id"), NotMapped]
        [LookupEditor("Administration.Tenant")]
        public int? SelectedTenant
        {
            get => fields.SelectedTenant[this];
            set => fields.SelectedTenant[this] = value;
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

        public Int32Field TenantIdField
        {
            get => Fields.TenantId;
        }

        Int16Field IIsActiveRow.IsActiveField
        {
            get => fields.IsActive;
        }

        public GroupRow()
            : base()
        {
        }

        public GroupRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int32Field Id;
            public StringField Name;
            public StringField Description;
            public Int32Field ParentId;
            public Int16Field IsActive;
            public Int32Field TenantId;
            public StringField TenantName;
            public Int32Field SelectedTenant;
            public Int64Field TeacherId;
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