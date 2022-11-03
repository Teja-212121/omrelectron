using FluentMigrator;
using Serenity.Extensions;
using System;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20220919_025700)]
    public class DefaultDB_20220919_025700_AlterTable : Migration
    {
        public override void Up()
        {
            Alter.Table("Students")
                .AddColumn("Note").AsString(300).Nullable()
                    .WithDefaultValue(1);
        }

        public override void Down()
        {
        }
    }
}