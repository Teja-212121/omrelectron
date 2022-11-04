using FluentMigrator;
using Serenity.Extensions;

namespace Rio.Migrations.DefaultDB
{

    [Migration(20220825121800)]
    public class DefaultDB_20220825_121800_Sheets : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("SheetTypes", "Id", s => s
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("Description").AsString(1000).Nullable()
                .WithColumn("TotalQuestions").AsInt32().NotNullable()
                .WithColumn("EPaperSize").AsInt32().NotNullable()
                .WithColumn("HeightInPixel").AsInt32().Nullable()
                .WithColumn("WidthInPixel").AsInt32().Nullable()
                .WithColumn("SheetData").AsString(int.MaxValue).NotNullable()
                .WithColumn("SheetImage").AsString(1000).Nullable()
                .WithColumn("OverlayImage").AsString(1000).Nullable()
                .WithColumn("Synced").AsBoolean().Nullable()
                .WithColumn("IsPrivate").AsBoolean().Nullable()
                .WithColumn("PdfTemplate").AsString(1000).Nullable()
                .WithColumn("SheetNumber").AsInt64().NotNullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

            this.CreateTableWithId32("SheetTypesTenants", "Id", s => s
                .WithColumn("SheetTypeId").AsInt32().NotNullable()
                    .ForeignKey("SheetTypes", "Id")
                .WithColumn("TenantId").AsInt32().NotNullable()
                    .ForeignKey("Tenants", "TenantId")
                .WithColumn("IsDefault").AsBoolean().NotNullable()
                    .WithDefaultValue(false)
                .WithColumn("DisplayOrder").AsFloat().Nullable()
                .WithColumn("SheetDesignPdf").AsString(2000).Nullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

            this.Create.Table("ScannedBatches")
                .WithColumn("Id").AsGuid().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("Description").AsString(1000).Nullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1)
                .WithColumn("TenantId").AsInt32().NotNullable();

            this.Create.Table("ImportedScannedBatches")
                .WithColumn("Id").AsGuid().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("Description").AsString(1000).Nullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1)
                .WithColumn("TenantId").AsInt32().NotNullable();

            Create.Table("ScannedSheets")
                .WithColumn("Id").AsGuid().PrimaryKey()
                .WithColumn("SheetTypeId").AsInt32().NotNullable()
                    .ForeignKey("SheetTypes", "Id")
                .WithColumn("ScannedAt").AsDateTime().NotNullable()
                .WithColumn("SheetNumber").AsString(50).Nullable()
                .WithColumn("ScannedRollNo").AsInt64().Nullable()
                .WithColumn("ScannedExamNo").AsInt64().Nullable()
                .WithColumn("CorrectedRollNo").AsInt64().Nullable()
                .WithColumn("CorrectedExamNo").AsInt64().Nullable()
                .WithColumn("ExamSetNo").AsInt32().Nullable()
                .WithColumn("ScannedImageSourcePath").AsString(2000).Nullable()
                .WithColumn("ScannedImage").AsString(2000).Nullable()
                .WithColumn("ScannedBatchId").AsGuid().NotNullable()
                    .ForeignKey("ScannedBatches", "Id")
                .WithColumn("ScannedStatus").AsInt16().Nullable()
                .WithColumn("ScannedSystemErrors").AsString(1000).Nullable()
                .WithColumn("ScannedUserErrors").AsString(1000).Nullable()
                .WithColumn("ScannedComments").AsString(1000).Nullable()
                .WithColumn("ResultProcessed").AsBoolean().NotNullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1)
                .WithColumn("TenantId").AsInt32().NotNullable();

            Create.Table("ImportedScannedSheets")
                .WithColumn("Id").AsGuid().PrimaryKey()
                .WithColumn("SheetTypeId").AsInt32().NotNullable()
                    .ForeignKey("SheetTypes", "Id")
                .WithColumn("ScannedAt").AsDateTime().NotNullable()
                .WithColumn("SheetNumber").AsString(50).Nullable()
                .WithColumn("SheetGuid").AsGuid().NotNullable()
                .WithColumn("ScannedRollNo").AsInt64().Nullable()
                .WithColumn("ScannedExamNo").AsInt64().Nullable()
                .WithColumn("CorrectedRollNo").AsInt64().Nullable()
                .WithColumn("CorrectedExamNo").AsInt64().Nullable()
                .WithColumn("ExamSetNo").AsInt32().Nullable()
                .WithColumn("ScannedImageSourcePath").AsString(2000).Nullable()
                .WithColumn("ScannedImage").AsString(2000).Nullable()
                .WithColumn("ScannedBatchId").AsGuid().NotNullable()
                    .ForeignKey("ImportedScannedBatches", "Id")
                .WithColumn("ScannedStatus").AsInt16().Nullable()
                .WithColumn("ScannedSystemErrors").AsString(1000).Nullable()
                .WithColumn("ScannedUserErrors").AsString(1000).Nullable()
                .WithColumn("ScannedComments").AsString(1000).Nullable()
                .WithColumn("ResultProcessed").AsBoolean().NotNullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1)
                .WithColumn("TenantId").AsInt32().NotNullable();

            this.CreateTableWithId64("ScannedQuestions", "Id", s => s
                .WithColumn("ScannedSheetId").AsGuid().NotNullable()
                    .ForeignKey("ScannedSheets", "Id")
                .WithColumn("QuestionIndex").AsInt32().NotNullable()
                .WithColumn("ScannedOptions").AsInt64().NotNullable()
                .WithColumn("CorrectedOptions").AsInt64().NotNullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1)
                .WithColumn("TenantId").AsInt32().NotNullable());

            this.CreateTableWithId64("ImportedScannedQuestions", "Id", s => s
                .WithColumn("ScannedSheetId").AsGuid().NotNullable()
                    .ForeignKey("ImportedScannedSheets", "Id")
                .WithColumn("QuestionIndex").AsInt32().NotNullable()
                .WithColumn("ScannedOptions").AsInt64().NotNullable()
                .WithColumn("CorrectedOptions").AsInt64().NotNullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1)
                .WithColumn("TenantId").AsInt32().NotNullable());

            this.CreateTableWithId64("ScannedBatchesSheetsAndQuestionsForExport", "Id", s => s
                .WithColumn("ScannedBatchId").AsGuid().NotNullable()
                .WithColumn("ScannedBatchName").AsString(100).NotNullable()
                .WithColumn("ScannedSheetId").AsGuid().NotNullable()
                .WithColumn("ScannedAt").AsDateTime().NotNullable()
                .WithColumn("SheetNumber").AsString(50).Nullable()
                .WithColumn("ScannedRollNo").AsInt64().Nullable()
                .WithColumn("CorrectedRollNo").AsInt64().Nullable()
                .WithColumn("CorrectedExamNo").AsInt64().Nullable()
                .WithColumn("ExamSetNo").AsInt32().Nullable()
                .WithColumn("ScannedImageSourcePath").AsString(2000).Nullable()
                .WithColumn("ScannedImage").AsString(2000).Nullable()
                .WithColumn("ScannedStatus").AsInt16().Nullable()
                .WithColumn("ScannedSystemErrors").AsString(1000).Nullable()
                .WithColumn("ScannedUserErrors").AsString(1000).Nullable()
                .WithColumn("ScannedComments").AsString(1000).Nullable()
                .WithColumn("QuestionIndex").AsInt32().Nullable()
                .WithColumn("CorrectedOptions").AsInt64().Nullable()
                .WithColumn("TenantId").AsInt32().NotNullable());

            this.CreateTableWithId32("RuleTypes", "Id", s => s
               .WithColumn("Name").AsString(500).NotNullable()
               .WithColumn("Description").AsString(2000).NotNullable());

            Insert.IntoTable("RuleTypes")
                .Row(new
                {
                    Name = "Single Right Answer (Single Option Only)",
                    Description = "Single Right Answer"
                });

            Insert.IntoTable("RuleTypes")
                .Row(new
                {
                    Name = "Multiple Right Answers (Any One Option )",
                    Description = "Any One of Right Answers"
                });
            Insert.IntoTable("RuleTypes")
                .Row(new
                {
                    Name = "Bonus Marks (Everyone)",
                    Description = "All of the Right Answers"
                });
            Insert.IntoTable("RuleTypes")
                .Row(new
                {
                    Name = "Weight Based (Dynamic Marks Per Option(s))",
                    Description = "Weight based"
                });
            Insert.IntoTable("RuleTypes")
                .Row(new
                {
                    Name = "Multiple Right Answers (All Options)",
                    Description = "Everyone get marks"
                });
            Insert.IntoTable("RuleTypes")
                .Row(new
                {
                    Name = "Bonus Marks (If Question Attempted)",
                    Description = "Those who attempted get marks"
                });
            Insert.IntoTable("RuleTypes")
                .Row(new
                {
                    Name = "Multiple Right Answers (Any One or All Options)",
                    Description = "Everyone get marks"
                });
        }
    }
}