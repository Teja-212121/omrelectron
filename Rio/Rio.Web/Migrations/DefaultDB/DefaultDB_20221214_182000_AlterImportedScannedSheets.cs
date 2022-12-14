using FluentMigrator;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20221214182000)]
    public class DefaultDB_20221214_182000_AlterImportedScannedSheets : AutoReversingMigration
    {
        public override void Up()
        {
            

            this.Alter.Table("ImportedScannedSheets").AlterColumn("ScannedRollNo").AsString(100).Nullable()
                .AlterColumn("ScannedExamNo").AsString(500).Nullable()
                .AlterColumn("ExamSetNo").AsString(500).Nullable()
                .AlterColumn("CorrectedRollNo").AsString(100).Nullable()
                .AlterColumn("CorrectedExamNo").AsString(500).Nullable();

            
            
        }
    }
}