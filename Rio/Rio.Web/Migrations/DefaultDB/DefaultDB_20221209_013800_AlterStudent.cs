using FluentMigrator;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20221209013800)]
    public class DefaultDB_20221209_013800_AlterStudent : AutoReversingMigration
    {
        public override void Up()
        {
            this.Alter.Table("Students")
                .AddColumn("StudentId").AsGuid().Nullable()
                .AddColumn("Comments").AsString(500).Nullable();

        }
    }
}