using FluentMigrator;
using Serenity.Extensions;
using System;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20221122064900)]
    public class DefaultDB_20221122_064900_AlterTenants : AutoReversingMigration
    {
        public override void Up()
        {
            this.Alter.Table("Tenants")
                .AddColumn("EApprovalStatus").AsInt16().Nullable()
                .AddColumn("IsActive").AsInt16().Nullable();
        }
    }
}