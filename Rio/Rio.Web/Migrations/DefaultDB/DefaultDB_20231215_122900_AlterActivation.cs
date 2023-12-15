using FluentMigrator;
using Serenity.Extensions;

namespace Rio.Migrations.DefaultDB
{

    [Migration(20231215122900)]
    public class DefaultDB_20231215_122900_AlterActivation : Migration
    {
        public override void Up()
        {
            Alter.Table("Activations")
                .AddColumn("TenantId").AsInt32().Nullable();
        }
        public override void Down()
        {

        }
    }
}