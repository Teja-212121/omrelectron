using FluentMigrator;
using Serenity.Extensions;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20230303105900)]
    public class DefaultDB_20230303_105900_AlterSheetTypes : Migration
    {
        public override void Up()
        {
            Alter.Table("SheetTypes").AddColumn("OverlayImageOpenCV").AsString(1000).Nullable();
        }
        public override void Down() { }
    }
}