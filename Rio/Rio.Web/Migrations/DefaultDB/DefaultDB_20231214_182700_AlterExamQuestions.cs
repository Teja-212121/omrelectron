using FluentMigrator;
using Serenity.Extensions;

namespace Rio.Migrations.DefaultDB
{

    [Migration(20231214182700)]
    public class DefaultDB_20231214_182700_AlterExamQuestions : Migration
    {
        public override void Up()
        {
            Alter.Table("ExamQuestions")
                .AlterColumn("RightOption").AsString(20).Nullable();
        }
        public override void Down()
        {

        }
    }
}