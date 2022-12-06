using FluentMigrator;
using Serenity.Extensions;
using System;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20221206124900)]
    public class DefaultDB_20221206_124900_TheoryExamResultsQuestions : Migration
    {
        public override void Up()
        {
            Execute.Sql("Drop Table TheoryExamResults");

            this.CreateTableWithId64("TheoryExamResults", "Id", s => s
                .WithColumn("TheoryExamId").AsInt64().NotNullable()
                    .ForeignKey("TheoryExams", "Id")
                .WithColumn("StudentScanId").AsString(500).NotNullable()
                 .WithColumn("MarksScored").AsFloat().Nullable()
                 .WithColumn("OutOfMarks").AsFloat().Nullable()
                 .WithColumn("ResultStatus").AsInt16().NotNullable()
                 .WithColumn("RollNumber").AsString(500).Nullable()
                 .WithColumn("SheetImage").AsString(500).Nullable()
                 .WithColumn("StudentId").AsInt64().Nullable()
                    .ForeignKey("Students", "Id")
                .WithColumn("AttemptDate").AsDateTime().Nullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1)
                .WithColumn("TenantId").AsInt32().NotNullable());

            this.CreateTableWithId64("TheoryExamResultQuestions", "Id", s => s
               .WithColumn("TheoryExamResultId").AsInt64().NotNullable()
                .ForeignKey("TheoryExamResults", "Id")
                .WithColumn("TheoryExamQuestionId").AsInt64().Nullable()
                 .ForeignKey("TheoryExamQuestions", "Id")
                .WithColumn("MarksObtained").AsFloat().NotNullable()
                .WithColumn("OutOfMarks").AsFloat().Nullable()
                .WithColumn("AttemptStatus").AsInt16().NotNullable()                
               .WithColumn("InsertDate").AsDateTime().NotNullable()
               .WithColumn("InsertUserId").AsInt32().NotNullable()
               .WithColumn("UpdateDate").AsDateTime().Nullable()
               .WithColumn("UpdateUserId").AsInt32().Nullable()
               .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1)
               .WithColumn("TenantId").AsInt32().NotNullable());


        }
        public override void Down()
        {
        }
    }
}