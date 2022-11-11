using FluentMigrator;
using Serenity.Extensions;
using System;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20221111064900)]
    public class DefaultDB_20221111_064900_AlterExams : AutoReversingMigration
    {
        public override void Up()
        {
            this.Alter.Table("Exams")
                .AddColumn("TotalQuestions").AsInt32().Nullable();
        }
    }
}