using FluentMigrator;
using Serenity.Extensions;
using System;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20220825122400)]
    public class DefaultDB_20220825_122400_Exams : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId64("Exams", "Id", s => s
                .WithColumn("Code").AsString(100).NotNullable()
                .WithColumn("Name").AsString(500).NotNullable()
                .WithColumn("Description").AsString(1000).Nullable()
                .WithColumn("TotalMarks").AsInt32().NotNullable()
                .WithColumn("NegativeMarks").AsFloat().Nullable()
                .WithColumn("OptionsAvailable").AsInt16().Nullable()
                .WithColumn("ResultCriteria").AsString(1000).Nullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1)
                .WithColumn("TenantId").AsInt32().NotNullable());

            this.CreateTableWithId32("ExamSections", "Id", s => s
                .WithColumn("Name").AsString(500).NotNullable()
                .WithColumn("Description").AsString(1000).Nullable()
                .WithColumn("ExamId").AsInt64().NotNullable()
                    .ForeignKey("Exams", "Id")
                .WithColumn("ParentId").AsInt32().Nullable()
                    .ForeignKey("ExamSections", "Id")
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1)
                .WithColumn("TenantId").AsInt32().NotNullable());

            this.CreateTableWithId64("ExamQuestions", "Id", s => s
                .WithColumn("ExamId").AsInt64().NotNullable()
                    .ForeignKey("Exams", "Id")
                .WithColumn("QuestionIndex").AsInt32().NotNullable()
                .WithColumn("RightOptions").AsInt16().NotNullable()
                .WithColumn("Score").AsFloat().NotNullable()
                .WithColumn("Tags").AsString(1000).Nullable()
                .WithColumn("RuleTypeId").AsInt32().NotNullable()
                    .ForeignKey("RuleTypes", "Id")
                .WithColumn("ExamSectionId").AsInt32().Nullable()
                    .ForeignKey("ExamSections", "Id")
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1)
                .WithColumn("TenantId").AsInt32().NotNullable());

            this.CreateTableWithId32("ExamResults", "Id", s => s
                .WithColumn("StudentId").AsInt64().NotNullable()
                    .ForeignKey("Students", "Id")
                .WithColumn("RollNumber").AsInt64().NotNullable()
                .WithColumn("SheetNumber").AsString(50).Nullable()
                .WithColumn("SheetGuid").AsGuid().NotNullable()
                .WithColumn("ExamId").AsInt64().NotNullable()
                    .ForeignKey("Exams", "Id")
                .WithColumn("TotalMarks").AsFloat().NotNullable()
                .WithColumn("ObtainedMarks").AsFloat().NotNullable()
                .WithColumn("Percentage").AsFloat().NotNullable()
                .WithColumn("TotalQuestions").AsInt32().NotNullable()
                .WithColumn("TotalAttempted").AsInt32().NotNullable()
                .WithColumn("TotalNotAttempted").AsInt32().NotNullable()
                .WithColumn("TotalRightAnswers").AsInt32().NotNullable()
                .WithColumn("TotalWrongAnswers").AsInt32().NotNullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1)
                .WithColumn("TenantId").AsInt32().NotNullable());

            this.CreateTableWithId32("ExamSectionResults", "Id", s => s
                .WithColumn("StudentId").AsInt64().NotNullable()
                    .ForeignKey("Students", "Id")
                .WithColumn("RollNumber").AsInt64().NotNullable()
                .WithColumn("SheetNumber").AsString(50).Nullable()
                .WithColumn("SheetGuid").AsGuid().NotNullable()
                .WithColumn("ExamId").AsInt64().NotNullable()
                    .ForeignKey("Exams", "Id")
                .WithColumn("ExamSectionId").AsInt32().NotNullable()
                    .ForeignKey("ExamSections", "Id")
                .WithColumn("TotalMarks").AsFloat().NotNullable()
                .WithColumn("ObtainedMarks").AsFloat().NotNullable()
                .WithColumn("Percentage").AsFloat().NotNullable()
                .WithColumn("TotalQuestions").AsInt32().NotNullable()
                .WithColumn("TotalAttempted").AsInt32().NotNullable()
                .WithColumn("TotalNotAttempted").AsInt32().NotNullable()
                .WithColumn("TotalRightAnswers").AsInt32().NotNullable()
                .WithColumn("TotalWrongAnswers").AsInt32().NotNullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1)
                .WithColumn("TenantId").AsInt32().NotNullable());

            this.CreateTableWithId64("ExamQuestionResults", "Id", s => s
                .WithColumn("StudentId").AsInt64().NotNullable()
                    .ForeignKey("Students", "Id")
                .WithColumn("RollNumber").AsInt64().NotNullable()
                .WithColumn("SheetNumber").AsString(50).Nullable()
                .WithColumn("SheetGuid").AsGuid().NotNullable()
                .WithColumn("ExamId").AsInt64().NotNullable()
                    .ForeignKey("Exams", "Id")
                .WithColumn("QuestionIndex").AsInt32().NotNullable()
                .WithColumn("IsAttempted").AsBoolean().NotNullable()
                .WithColumn("IsCorrect").AsBoolean().NotNullable()
                .WithColumn("ObtainedMarks").AsFloat().NotNullable()
                .WithColumn("TenantId").AsInt32().NotNullable());

            this.CreateTableWithId64("ExamGroupWiseResults", "Id", s => s
                .WithColumn("StudentId").AsInt64().NotNullable()
                    .ForeignKey("Students", "Id")
                .WithColumn("RollNumber").AsInt64().NotNullable()
                .WithColumn("SheetNumber").AsString(50).Nullable()
                .WithColumn("SheetGuid").AsGuid().NotNullable()
                .WithColumn("ExamId").AsInt64().NotNullable()
                    .ForeignKey("Exams", "Id")
                .WithColumn("Rank").AsInt32().NotNullable()
                .WithColumn("GroupId").AsInt32().NotNullable()
                    .ForeignKey("Groups", "Id")
                .WithColumn("TenantId").AsInt32().NotNullable());

            this.CreateTableWithId64("ExamRankWiseResults", "Id", s => s
                .WithColumn("StudentId").AsInt64().NotNullable()
                    .ForeignKey("Students", "Id")
                .WithColumn("RollNumber").AsInt64().NotNullable()
                .WithColumn("SheetNumber").AsString(50).Nullable()
                .WithColumn("SheetGuid").AsGuid().NotNullable()
                .WithColumn("ExamId").AsInt64().NotNullable()
                    .ForeignKey("Exams", "Id")
                .WithColumn("Rank").AsInt32().NotNullable()
                .WithColumn("TenantId").AsInt32().NotNullable());
        }
    }
}