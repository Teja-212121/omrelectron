using FluentMigrator;
using Serenity.Extensions;
using System;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20221206055600)]
    public class DefaultDB_20221206_055600_AlterScannedQuestion : AutoReversingMigration
    {
        public override void Up()
        {
            this.Alter.Table("ScannedQuestions")
                .AddColumn("ScannedBatchId").AsGuid().Nullable()
                    .ForeignKey("ScannedBatches", "Id");

            this.Alter.Table("ImportedScannedQuestions")
                .AddColumn("ScannedBatchId").AsGuid().Nullable()
                    .ForeignKey("ScannedBatches", "Id");
        }
    }
}