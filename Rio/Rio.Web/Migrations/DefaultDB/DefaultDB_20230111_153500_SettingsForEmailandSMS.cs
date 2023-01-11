using FluentMigrator;
using Serenity.Extensions;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20230111153500)]
    public class DefaultDB_20230111_153500_SettingsForEmailandSMS : Migration
    {
        public override void Up()
        {
            this.CreateTableWithId64("Settings", "Id", s => s
                .WithColumn("Host").AsString(100).Nullable()
                .WithColumn("Port").AsInt32().Nullable()
                .WithColumn("UseSsl").AsBoolean().Nullable()
                .WithColumn("From").AsString(100).Nullable()
                .WithColumn("UserName").AsString(100).Nullable()
                .WithColumn("Password").AsString(100).Nullable()
                .WithColumn("ApiKey").AsString(1000).Nullable()
                .WithColumn("Sender").AsString(100).Nullable()
                .WithColumn("GatewayUrl").AsString(1000).Nullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1)
                .WithColumn("TenantId").AsInt32().NotNullable());
        }
        public override void Down() { }
    }
}