using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("Settings")]
    [DisplayName("Settings"), InstanceName("Settings")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class SettingsRow : LoggingRow<SettingsRow.RowFields>, IIdRow, INameRow, IMultiTenantRow, IIsActiveRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Host"), QuickSearch, NameProperty]
        public string Host
        {
            get => fields.Host[this];
            set => fields.Host[this] = value;
        }

        [DisplayName("Port")]
        public int? Port
        {
            get => fields.Port[this];
            set => fields.Port[this] = value;
        }

        [DisplayName("Use Ssl")]
        public Boolean? UseSsl
        {
            get => fields.UseSsl[this];
            set => fields.UseSsl[this] = value;
        }

        [DisplayName("From Email")]
        public string From
        {
            get => fields.From[this];
            set => fields.From[this] = value;
        }

        [DisplayName("User Name")]
        public string UserName
        {
            get => fields.UserName[this];
            set => fields.UserName[this] = value;
        }

        [DisplayName("Password")]
        public string Password
        {
            get => fields.Password[this];
            set => fields.Password[this] = value;
        }

        [DisplayName("Api Key")]
        public string ApiKey
        {
            get => fields.ApiKey[this];
            set => fields.ApiKey[this] = value;
        }

        [DisplayName("Sender")]
        public string Sender
        {
            get => fields.Sender[this];
            set => fields.Sender[this] = value;
        }

        [DisplayName("Gateway Url")]
        public string GatewayUrl
        {
            get => fields.GatewayUrl[this];
            set => fields.GatewayUrl[this] = value;
        }

        [DisplayName("Is Active"), NotNull, Insertable(false), Updatable(true)]
        public short? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        [DisplayName("UseXOAUTH2"),DefaultValue(true)]
        public Boolean? UseXOAUTH2
        {
            get => fields.UseXOAUTH2[this];
            set => fields.UseXOAUTH2[this] = value;
        }

        [DisplayName("Tenant Id")]
        [LookupEditor("Administration.Tenant")]
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

        public SettingsRow()
            : base()
        {
        }

        public SettingsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int32Field Id;
            public StringField Host;
            public Int32Field Port;
            public BooleanField UseSsl;
            public StringField From;
            public StringField UserName;
            public StringField Password;
            public StringField ApiKey;
            public StringField Sender;
            public StringField GatewayUrl;
            public Int16Field IsActive;
            public Int32Field TenantId;
            public BooleanField UseXOAUTH2;
        }
    }
}