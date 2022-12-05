using FluentMigrator;
using Serenity.Extensions;
using System;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20221205184900)]
    public class DefaultDB_20221205_184900_TheoryExamResults : Migration
    {
        public override void Up()
        {           

            this.CreateTableWithId64("TheoryExamResults", "Id", s => s
                .WithColumn("TheoryExamId").AsInt64().NotNullable()
                    .ForeignKey("TheoryExams", "Id")
                .WithColumn("StudentScanId").AsString(500).NotNullable()               
                .WithColumn("TheoryExamQuestionId").AsInt64().Nullable()
                 .ForeignKey("TheoryExamQuestions", "Id")
                 .WithColumn("MarksObtained").AsFloat().NotNullable()
                 .WithColumn("AttemptStatus").AsInt16().NotNullable()
                 .WithColumn("RollNumber").AsString(500).Nullable()
                 .WithColumn("StudentId").AsInt64().NotNullable()
                    .ForeignKey("Students", "Id")
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