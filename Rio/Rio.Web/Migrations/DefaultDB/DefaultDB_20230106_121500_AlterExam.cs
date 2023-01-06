using FluentMigrator;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20230106121500)]
    public class DefaultDB_20230106_121500_AlterExam : Migration
    {
        public override void Up()
        {
            Alter.Table("Exams").AddColumn("SheetTypeId").AsInt32().Nullable().ForeignKey("SheetTypes", "Id");
        }
        public override void Down() { }
    }
}