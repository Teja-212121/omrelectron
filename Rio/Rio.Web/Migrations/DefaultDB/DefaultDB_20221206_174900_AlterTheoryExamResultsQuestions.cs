using FluentMigrator;
using Serenity.Extensions;
using System;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20221206174900)]
    public class DefaultDB_20221206_174900_AlterTheoryExamResultsQuestions : Migration
    {
        public override void Up()
        {
            Alter.Table("TheoryExamResultQuestions").AlterColumn("MarksObtained").AsFloat().Nullable();
            


        }
        public override void Down()
        {
        }
    }
}