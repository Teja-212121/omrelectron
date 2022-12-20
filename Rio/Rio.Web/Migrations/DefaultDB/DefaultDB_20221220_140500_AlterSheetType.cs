using FluentMigrator;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20221220140500)]
    public class DefaultDB_20221220_140500_AlterSheetType : AutoReversingMigration
    {
        public override void Up()
        {
            this.Alter.Table("SheetTypes")
                .AddColumn("IsPublic").AsBoolean().Nullable();
        }
    }
}