using FluentMigrator;
using Serenity.Extensions;
using System;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20221123064900)]
    public class DefaultDB_20221123_064900_AlterMail : AutoReversingMigration
    {
        public override void Up()
        {
            this.Alter.Table("Mail")
                .AddColumn("AwsUserId").AsString(500).Nullable()
                .AddColumn("AwsPassword").AsString(500).Nullable();
        }
    }
}