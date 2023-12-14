using FluentMigrator;
using Serenity.Extensions;

namespace Rio.Migrations.DefaultDB
{

    [Migration(20231214163000)]
    public class DefaultDB_20231214_163000_AlterExamQuestions : Migration
    {
        public override void Up()
        {
            Delete.Column("RightOptions").FromTable("ExamQuestions");
            Alter.Table("ExamQuestions")
                .AddColumn("RightOption").AsInt32().Nullable()
                    ;
        }
        public override void Down()
        {

        }
    }
}