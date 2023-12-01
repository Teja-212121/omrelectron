using FluentMigrator;
using Serenity.Extensions;

namespace Rio.Migrations.DefaultDB
{

    [Migration(20231201175700)]
    public class DefaultDB_20231201_175700_AlterActivation : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Activations")
                .AddColumn("SerialKeyId").AsInt32().Nullable()
                    .ForeignKey("SerialKeys", "Id");
        }
    }
}