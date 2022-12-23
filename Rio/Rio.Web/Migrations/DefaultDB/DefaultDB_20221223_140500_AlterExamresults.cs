using FluentMigrator;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20221223140500)]
    public class DefaultDB_20221223_140500_AlterExamresults : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("ExamResults")
                .AlterColumn("StudentId").AsInt64().Nullable().ForeignKey("Students","Id");
            Alter.Table("ExamQuestionResults")
                .AlterColumn("StudentId").AsInt64().Nullable().ForeignKey("Students", "Id");
            Alter.Table("ExamSectionResults")
                .AlterColumn("StudentId").AsInt64().Nullable().ForeignKey("Students", "Id");
        }
    }
}