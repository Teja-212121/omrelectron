using FluentMigrator;
using Serenity.Extensions;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20230116113500)]
    public class DefaultDB_20230116_113500_AlterSettings : Migration
    {
        public override void Up()
        {
            Alter.Table("Settings").AddColumn("UseXOAUTH2").AsBoolean().Nullable();
            Alter.Table("Mail").AddColumn("UseXOAUTH2").AsBoolean().Nullable();
        }
        public override void Down() { }
    }
}