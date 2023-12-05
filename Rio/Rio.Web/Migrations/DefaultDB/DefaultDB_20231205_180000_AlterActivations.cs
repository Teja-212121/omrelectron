using FluentMigrator;
using Serenity.Extensions;

namespace Rio.Migrations.DefaultDB
{

    [Migration(20231205180000)]
    public class DefaultDB_20231205_180000_AlterActivations : Migration
    {
        public override void Up()
        {
            Execute.Sql(@"ALTER TABLE ActivationLog DROP CONSTRAINT FK_ActivationLog_ActivationId_Activations_Id;");
            Delete.Column("ActivationId").FromTable("ActivationLog");
            Alter.Table("Activations")
                .AddColumn("ActivationLogId").AsInt32().Nullable()
                    .ForeignKey("ActivationLog", "Id");
        }
        public override void Down()
        {

        }
    }
}