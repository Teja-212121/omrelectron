using FluentMigrator;
using Serenity.Extensions;

namespace Rio.Migrations.DefaultDB
{

    [Migration(20231207191700)]
    public class DefaultDB_20231207_191700_AlterActivationlogCode : Migration
    {
        public override void Up()
        {
            Alter.Table("ActivationLog")
                .AlterColumn("Code").AsString(100).Nullable() ;
        }
        public override void Down()
        {

        }
    }
}