using FluentMigrator;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20221215122000)]
    public class DefaultDB_20221215_122000_AlterScannedSheet : AutoReversingMigration
    {
        public override void Up()
        {
            this.Alter.Table("ScannedSheets")
                .AddColumn("IsRectified").AsBoolean().Nullable();

            this.Alter.Table("ImportedScannedSheets")
               .AddColumn("IsRectified").AsBoolean().Nullable();

        }
    }
}