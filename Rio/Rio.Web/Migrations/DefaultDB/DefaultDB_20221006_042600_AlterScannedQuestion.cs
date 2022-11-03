using FluentMigrator;
using Serenity.Extensions;
using System;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20221006042600)]
    public class DefaultDB_20221006_042600_AlterScannedQuestion : Migration
    {
        public override void Up()
        {
            Alter.Table("ScannedQuestions")
                .AddColumn("ExamCode").AsString(300).Nullable()
                .AddColumn("ExamName").AsString(300).Nullable()
                .AddColumn("StudentRollNo").AsInt64().Nullable()
                .AddColumn("ScannedRollNo").AsInt64().Nullable();

        }

        public override void Down()
        {
        }
    }
}