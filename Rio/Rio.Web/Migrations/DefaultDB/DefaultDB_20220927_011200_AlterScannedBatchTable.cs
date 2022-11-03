using FluentMigrator;
using Serenity.Extensions;
using System;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20220927011200)]
    public class DefaultDB_20220927_011200_AlterScannedBatchTable : Migration
    {
        public override void Up()
        {
            Alter.Table("ScannedBatches")
                .AddColumn("Description").AsString(1000).Nullable();

            Alter.Table("ImportedScannedBatches")
                .AddColumn("Description").AsString(1000).Nullable();

        }

        public override void Down()
        {
        }
    }
}