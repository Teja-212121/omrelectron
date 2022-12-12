using FluentMigrator;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20221212155800)]
    public class DefaultDB_20221212_155800_AlterScannedSheetTable : AutoReversingMigration
    {
        public override void Up()
        {
            this.Alter.Table("ScannedSheets").AddColumn("ScannedSheetDisplayName").AsString(500).Nullable();
            this.Alter.Table("ImportedScannedSheets").AddColumn("ImportScannedSheetDisplayName").AsString(500).Nullable();
        }
    }
}