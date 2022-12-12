using FluentMigrator;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20221212171600)]
    public class DefaultDB_20221212_171600_AlterExamQuestionsField : AutoReversingMigration
    {
        public override void Up()
        {
            this.Alter.Table("ExamQuestions")
                .AddColumn("DisplayIndex").AsString(100).Nullable();            
        }
    }
}