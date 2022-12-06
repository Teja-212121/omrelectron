using FluentMigrator;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20221218182000)]
    public class DefaultDB_20221218_182000_AlterScannedSheet : AutoReversingMigration
    {
        public override void Up()
        {
            this.Alter.Table("ScannedSheets")
                .AddColumn("OCRData1Key").AsString(200).Nullable()
                .AddColumn("OCRData1Value").AsString(200).Nullable()
                .AddColumn("OCRData2Key").AsString(200).Nullable()
                .AddColumn("OCRData2Value").AsString(200).Nullable()
                .AddColumn("OCRData3Key").AsString(200).Nullable()
                .AddColumn("OCRData3Value").AsString(200).Nullable()

                .AddColumn("ICRData1Key").AsString(200).Nullable()
                .AddColumn("ICRData1Value").AsString(200).Nullable()
                .AddColumn("ICRData2Key").AsString(200).Nullable()
                .AddColumn("ICRData2Value").AsString(200).Nullable()
                .AddColumn("ICRData3Key").AsString(200).Nullable()
                .AddColumn("ICRData3Value").AsString(200).Nullable();

            this.Alter.Table("ImportedScannedSheets")
                .AddColumn("OCRData1Key").AsString(200).Nullable()
                .AddColumn("OCRData1Value").AsString(200).Nullable()
                .AddColumn("OCRData2Key").AsString(200).Nullable()
                .AddColumn("OCRData2Value").AsString(200).Nullable()
                .AddColumn("OCRData3Key").AsString(200).Nullable()
                .AddColumn("OCRData3Value").AsString(200).Nullable()

                .AddColumn("ICRData1Key").AsString(200).Nullable()
                .AddColumn("ICRData1Value").AsString(200).Nullable()
                .AddColumn("ICRData2Key").AsString(200).Nullable()
                .AddColumn("ICRData2Value").AsString(200).Nullable()
                .AddColumn("ICRData3Key").AsString(200).Nullable()
                .AddColumn("ICRData3Value").AsString(200).Nullable();
        }
    }
}