using FluentMigrator;
using Serenity.Extensions;

namespace Rio.Migrations.DefaultDB
{

    [Migration(20231219122900)]
    public class DefaultDB_20231219_122900_AlterExamList : Migration
    {
        public override void Up()
        {
            Alter.Table("ExamLists")
                .AddColumn("Thumbnail").AsString(int.MaxValue).Nullable();


            Alter.Table("Users")
                .AddColumn("CountryCode").AsInt16().Nullable()
                 .AddColumn("SMSVerificationCode").AsInt32().Nullable();
        }
        public override void Down()
        {

        }
    }
}