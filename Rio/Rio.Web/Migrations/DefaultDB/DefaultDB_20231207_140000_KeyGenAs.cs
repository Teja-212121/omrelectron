using FluentMigrator;
using Serenity.Extensions;

namespace Rio.Migrations.DefaultDB
{

    [Migration(20231207140000)]
    public class DefaultDB_20231207_140000_KeyGenAs : Migration
    {
        public override void Up()
        {
            this.CreateTableWithId32("KeyGenAs", "Id", s => s
                 .WithColumn("Quantity").AsInt16().NotNullable()
                 .WithColumn("ExamListId").AsInt32().NotNullable()
                     .ForeignKey("ExamLists", "Id")
                 .WithColumn("ValidityType").AsInt16().Nullable()
                 .WithColumn("ValidityInDays").AsInt16().Nullable()
                 .WithColumn("ValidDate").AsDateTime().Nullable()
                 .WithColumn("Note").AsString(1000).Nullable()
                 .WithColumn("eStatus").AsInt16().Nullable()
                 .WithColumn("InsertDate").AsDateTime().NotNullable()
                 .WithColumn("InsertUserId").AsInt32().NotNullable()
                 .WithColumn("UpdateDate").AsDateTime().Nullable()
                 .WithColumn("UpdateUserId").AsInt32().Nullable()
                 .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

            Alter.Table("SerialKeys").AddColumn("KeyGenAsId").AsInt32().Nullable().ForeignKey("KeyGenAs", "Id");
             Alter.Table("SerialKeys").AlterColumn("SerialKey").AsString(100).Nullable();
            //Delete.Column("SerialKey").FromTable("SerialKeys");
            //Alter.Table("SerialKeys").AddColumn("SerialKey").AsString(100).Nullable();
        }
        public override void Down()
        {

        }
    }
}