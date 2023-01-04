using FluentMigrator;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20230104110500)]
    public class DefaultDB_20230104_110500_AlterExams : Migration
    {
        public override void Up()
        {
            
            Alter.Table("ScannedSheets").AddColumn("ImageBase64").AsString(int.MaxValue).Nullable();
            Alter.Table("Exams").AddColumn("QuestionPaper").AsString(int.MaxValue).Nullable()
                .AddColumn("ModelAnswer").AsString(int.MaxValue).Nullable();
        }
        public override void Down() { }
    }
}