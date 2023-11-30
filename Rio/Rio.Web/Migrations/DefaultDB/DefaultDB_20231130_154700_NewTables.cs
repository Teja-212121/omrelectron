using FluentMigrator;
using Serenity.Extensions;

namespace Rio.Migrations.DefaultDB
{

    [Migration(20231130154700)]
    public class DefaultDB_20231130_154700_NewTables : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("ExamLists", "Id", s => s
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("Description").AsString(1000).Nullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1)
                .WithColumn("TenantId").AsInt32().NotNullable()
                    .ForeignKey("Tenants", "TenantId"));

            this.CreateTableWithId32("ExamListExams", "Id", s => s
                .WithColumn("ExamListId").AsInt32().NotNullable()
                    .ForeignKey("ExamLists", "Id")
                .WithColumn("ExamId").AsInt64().NotNullable()
                    .ForeignKey("Exams", "Id")
                .WithColumn("TenantId").AsInt32().NotNullable()
                    .ForeignKey("Tenants", "TenantId")
                .WithColumn("Priority").AsInt16().NotNullable()
                .WithColumn("StartDate").AsDateTime().Nullable()
                .WithColumn("EndDate").AsDateTime().Nullable()
                .WithColumn("ModelAnswerPaperStartDate").AsDateTime().Nullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

            this.CreateTableWithId32("PreDefinedKeys", "Id", s => s
                .WithColumn("SerialKey").AsString(100).NotNullable()
                .WithColumn("eStatus").AsInt16().Nullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

            this.CreateTableWithId32("SerialKeys", "Id", s => s
                .WithColumn("SerialKey").AsString(100).NotNullable()
                .WithColumn("ExamListId").AsInt32().NotNullable()
                    .ForeignKey("ExamLists", "Id")
                .WithColumn("ValidityType").AsInt16().Nullable()
                .WithColumn("ValidityInDays").AsInt16().Nullable()
                .WithColumn("ValidDate").AsDateTime().Nullable()
                .WithColumn("Note").AsString(1000).Nullable()
                .WithColumn("eStatus").AsInt16().Nullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

            this.CreateTableWithId32("CouponCodes", "Id", s => s
                .WithColumn("Code").AsString(100).NotNullable()
                .WithColumn("ExamListId").AsInt32().NotNullable()
                    .ForeignKey("ExamLists", "Id")
                .WithColumn("ValidityType").AsInt16().Nullable()
                .WithColumn("CountType").AsInt16().Nullable()
                .WithColumn("Count").AsInt16().Nullable()
                .WithColumn("ValidityInDays").AsInt16().Nullable()
                .WithColumn("ValidDate").AsDateTime().Nullable()
                .WithColumn("ConsumedCount").AsInt32().Nullable()
                .WithColumn("CouponValidityDate").AsDateTime().Nullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

            this.CreateTableWithId32("Activations", "Id", s => s
                .WithColumn("ExamListId").AsInt32().NotNullable()
                    .ForeignKey("ExamLists", "Id")
                .WithColumn("TeacherId").AsInt32().NotNullable()
                    .ForeignKey("Teachers", "Id")
                .WithColumn("DeviceId").AsString(200).Nullable()
                .WithColumn("DeviceDetails").AsString(500).Nullable()
                .WithColumn("ActivationDate").AsDateTime().Nullable()
                .WithColumn("ExpiryDate").AsDateTime().Nullable()
                .WithColumn("eStatus").AsInt16().Nullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

            this.CreateTableWithId32("ActivationLog", "Id", s => s
                .WithColumn("Code").AsString(100).NotNullable()
                .WithColumn("SerialKey").AsString(100).NotNullable()
                .WithColumn("TeacherId").AsInt32().Nullable()
                    .ForeignKey("Teachers", "Id")
                .WithColumn("ExamListId").AsInt32().NotNullable()
                    .ForeignKey("ExamLists", "Id")
                .WithColumn("DeviceId").AsString(200).Nullable()
                .WithColumn("DeviceDetails").AsString(500).Nullable()
                .WithColumn("eStatus").AsInt16().Nullable()
                .WithColumn("Note").AsString(1000).Nullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

            Alter.Table("Groups")
                .AddColumn("TeacherId").AsInt32().Nullable()
                    .ForeignKey("Teachers", "Id");

            Alter.Table("GroupStudents")
                .AddColumn("TeacherId").AsInt32().Nullable()
                    .ForeignKey("Teachers", "Id");

            Alter.Table("Teachers")
                .AddColumn("SchoolOrInstitute").AsString(500).Nullable();
        }
    }
}