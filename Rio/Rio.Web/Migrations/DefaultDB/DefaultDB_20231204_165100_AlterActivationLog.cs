using FluentMigrator;
using Serenity.Extensions;

namespace Rio.Migrations.DefaultDB
{

    [Migration(20231204165100)]
    public class DefaultDB_20231204_165100_AlterActivationLog : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("ActivationLog")
                .AddColumn("SerialKeyId").AsInt32().Nullable()
                    .ForeignKey("SerialKeys", "Id")

            .AddColumn("ActivationId").AsInt32().Nullable()
                    .ForeignKey("Activations", "Id");
        }
    }
}