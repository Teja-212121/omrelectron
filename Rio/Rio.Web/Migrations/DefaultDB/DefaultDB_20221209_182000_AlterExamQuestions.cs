using FluentMigrator;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20221209182000)]
    public class DefaultDB_20221209_182000_AlterExamQuestions : AutoReversingMigration
    {
        public override void Up()
        {
            this.Alter.Table("ExamQuestions").AlterColumn("RightOptions").AsString(20).Nullable()
                .AlterColumn("Score").AsString(20).Nullable();

            this.Alter.Table("ScannedSheets").AlterColumn("ScannedRollNo").AsString(100).Nullable()
                .AlterColumn("ScannedExamNo").AsString(500).Nullable()
                .AlterColumn("ExamSetNo").AsString(500).Nullable()
                .AlterColumn("CorrectedRollNo").AsString(100).Nullable()
                .AlterColumn("CorrectedExamNo").AsString(500).Nullable();

            this.Alter.Table("ScannedQuestions").AlterColumn("ScannedOptions").AsString(20).Nullable()
               .AlterColumn("CorrectedOptions").AsString(20).Nullable();

            this.Alter.Table("ImportedScannedQuestions").AlterColumn("ScannedOptions").AsString(20).Nullable()
              .AlterColumn("CorrectedOptions").AsString(20).Nullable();

            this.Alter.Table("Exams").AddColumn("ExamDisplayName").AsString(500).Nullable();
            this.Alter.Table("SheetTypes").AddColumn("SheetTypeDisplayName").AsString(500).Nullable();

        }
    }
}