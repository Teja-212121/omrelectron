using FluentMigrator;
using Serenity.Extensions;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20240802_113900)]
    public class DefaultDB_20240802_113900_CloudSettingTable : Migration
    {
        public override void Up()
        {
            Create.Table("CloudStorageProviders")
                 .WithColumn("Id").AsString(500).PrimaryKey().NotNullable()
                 .WithColumn("Name").AsString(500).NotNullable()
                 .WithColumn("Description").AsString(1000).Nullable()
                 .WithColumn("NumberOfParameter").AsInt16().NotNullable()
                 .WithColumn("TenantId").AsInt32().Nullable()
                 .ForeignKey("Tenants","TenantId")
                 .WithColumn("Parameter1Title").AsString(1000).Nullable()
                 .WithColumn("Parameter2Title").AsString(1000).Nullable()
                 .WithColumn("Parameter3Title").AsString(1000).Nullable()
                 .WithColumn("Parameter4Title").AsString(1000).Nullable()
                 .WithColumn("Parameter5Title").AsString(1000).Nullable()
                 .WithColumn("Parameter6Title").AsString(1000).Nullable()
                 .WithColumn("Parameter7Title").AsString(1000).Nullable()
                 .WithColumn("Parameter8Title").AsString(1000).Nullable()
                 .WithColumn("Parameter9Title").AsString(1000).Nullable()
                 .WithColumn("Parameter10Title").AsString(1000).Nullable()
                 .WithColumn("ParameterProvider").AsString(1000).Nullable();
            


            Create.Table("CloudStorageSettings")
            .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
            .WithColumn("CloudStorageProvidersId").AsString(500).ForeignKey("CloudStorageProviders", "Id").Nullable()
             .WithColumn("TenantId").AsInt32().Nullable()
                 .ForeignKey("Tenants", "TenantId")
            .WithColumn("Parameter1").AsString(1000).Nullable()
            .WithColumn("Parameter2").AsString(1000).Nullable()
            .WithColumn("Parameter3").AsString(1000).Nullable()
            .WithColumn("Parameter4").AsString(1000).Nullable()
            .WithColumn("Parameter5").AsString(1000).Nullable()
            .WithColumn("Parameter6").AsString(1000).Nullable()
            .WithColumn("Parameter7").AsString(1000).Nullable()
            .WithColumn("Parameter8").AsString(1000).Nullable()
            .WithColumn("Parameter9").AsString(1000).Nullable()
            .WithColumn("Parameter10").AsString(1000).Nullable()
            .WithColumn("ParameterProvider").AsString(1000).Nullable(); ;

        }
        public override void Down()
        {

        }
    }
}