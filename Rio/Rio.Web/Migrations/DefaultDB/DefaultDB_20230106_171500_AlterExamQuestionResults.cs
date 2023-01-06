using FluentMigrator;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20230106171500)]
    public class DefaultDB_20230106_171500_AlterExamQuestionResults : Migration
    {
        public override void Up()
        {
            Alter.Table("ExamQuestionResults").AddColumn("ExamQuestionId").AsInt64().Nullable().ForeignKey("ExamQuestions", "Id")
                .AddColumn("ExamSectionId").AsInt32().Nullable().ForeignKey("ExamSections", "Id");
        }
        public override void Down() { }
    }
}