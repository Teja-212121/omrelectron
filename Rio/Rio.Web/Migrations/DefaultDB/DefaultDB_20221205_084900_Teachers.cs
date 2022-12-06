using FluentMigrator;
using Serenity.Extensions;
using System;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20221205084900)]
    public class DefaultDB_20221205_084900_Teachers : Migration
    {
        public override void Up()
        {

            this.CreateTableWithId64("Teachers", "Id", s => s
               .WithColumn("FirstName").AsString(100).Nullable()
                .WithColumn("MiddleName").AsString(100).Nullable()
                .WithColumn("LastName").AsString(100).Nullable()
                .WithColumn("FullName").AsString(300).NotNullable()
                .WithColumn("Email").AsString(500).NotNullable()
                .WithColumn("Mobile").AsString(100).NotNullable()
                .WithColumn("DOB").AsDateTime().Nullable()
                .WithColumn("AllowedIps").AsString(2000).Nullable()
                .WithColumn("Address").AsString(2000).Nullable()
                .WithColumn("City").AsString(500).Nullable()
                .WithColumn("UserId").AsInt32().NotNullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1)
                .WithColumn("TenantId").AsInt32().NotNullable());

            this.CreateTableWithId64("TheoryExams", "Id", s => s
               .WithColumn("Code").AsString(100).NotNullable()
               .WithColumn("Name").AsString(500).NotNullable()
               .WithColumn("Description").AsString(1000).Nullable()
               .WithColumn("TotalMarks").AsInt32().NotNullable()
               .WithColumn("InsertDate").AsDateTime().NotNullable()
               .WithColumn("InsertUserId").AsInt32().NotNullable()
               .WithColumn("UpdateDate").AsDateTime().Nullable()
               .WithColumn("UpdateUserId").AsInt32().Nullable()
               .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1)
               .WithColumn("TenantId").AsInt32().NotNullable());

            this.CreateTableWithId32("TheoryExamSections", "Id", s => s
                .WithColumn("Name").AsString(500).NotNullable()
                .WithColumn("Description").AsString(1000).Nullable()
                .WithColumn("TheoryExamId").AsInt64().NotNullable()
                    .ForeignKey("TheoryExams", "Id")
                .WithColumn("ParentId").AsInt32().Nullable()
                    .ForeignKey("TheoryExamSections", "Id")
                .WithColumn("SortOrder").AsFloat().Nullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1)
                .WithColumn("TenantId").AsInt32().NotNullable());

            this.CreateTableWithId64("TheoryExamQuestions", "Id", s => s
                .WithColumn("TheoryExamId").AsInt64().NotNullable()
                    .ForeignKey("TheoryExams", "Id")
                .WithColumn("QuestionIndex").AsInt32().NotNullable()
                .WithColumn("MaxMarks").AsFloat().NotNullable()
                .WithColumn("DisplayIndex").AsString(100).Nullable()
                .WithColumn("Tags").AsString(1000).Nullable()
                .WithColumn("TheoryExamSectionId").AsInt32().Nullable()
                    .ForeignKey("TheoryExamSections", "Id")
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1)
                .WithColumn("TenantId").AsInt32().NotNullable());

            /*Execute.Sql(@"Insert into Roles (RoleName,RoleKey) values ('Tenant','Administration.Tenants')
                          Insert into Roles (RoleName,RoleKey) values ('Teacher','Administration.Teachers')");*/

            this.CreateTableWithId64("ExamTeachers", "Id", s => s
                .WithColumn("TheoryExamId").AsInt64().NotNullable()
                    .ForeignKey("TheoryExams", "Id")
                .WithColumn("TeacherId").AsInt64().NotNullable()
                    .ForeignKey("Teachers", "Id")
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