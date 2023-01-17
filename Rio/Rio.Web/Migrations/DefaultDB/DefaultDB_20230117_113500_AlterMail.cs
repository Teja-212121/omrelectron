using FluentMigrator;
using Serenity.Extensions;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20230117113500)]
    public class DefaultDB_20230117_113500_AlterMail : Migration
    {
        public override void Up()
        {
            
            Alter.Table("Mail").AddColumn("Host").AsString(500).Nullable()
                .AddColumn("FromName").AsString(500).Nullable()
                .AddColumn("Port").AsInt32().Nullable();
        }
        public override void Down() { }
    }
}