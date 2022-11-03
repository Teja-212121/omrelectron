using FluentMigrator;
using Serenity.Extensions;
using System;

namespace Rio.Migrations.DefaultDB
{

    [Migration(20220825122100)]
    public class DefaultDB_20220825_122100_GroupStudents : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("Groups", "Id", s => s
                .WithColumn("Name").AsString(500).NotNullable()
                .WithColumn("Description").AsString(1000).Nullable()
                .WithColumn("ParentId").AsInt32().Nullable()
                    .ForeignKey("Groups","Id")
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1)
                .WithColumn("TenantId").AsInt32().NotNullable());

            this.CreateTableWithId64("Students", "Id", s => s
                .WithColumn("RollNo").AsInt64().NotNullable()
                .WithColumn("FirstName").AsString(100).Nullable()
                .WithColumn("MiddleName").AsString(100).Nullable()
                .WithColumn("LastName").AsString(100).Nullable()
                .WithColumn("FullName").AsString(300).NotNullable()
                .WithColumn("Email").AsString(500).NotNullable()
                .WithColumn("Mobile").AsString(100).NotNullable()
                .WithColumn("DOB").AsDateTime().Nullable()
                .WithColumn("Gender").AsInt16().Nullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1)
                .WithColumn("TenantId").AsInt32().NotNullable());

            this.CreateTableWithId64("GroupStudents", "Id", s => s
                .WithColumn("GroupId").AsInt32().NotNullable()
                    .ForeignKey("Groups","Id")
                .WithColumn("StudentId").AsInt64().NotNullable()
                    .ForeignKey("Students","Id")
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1)
                .WithColumn("TenantId").AsInt32().NotNullable());            
        }
    }
}