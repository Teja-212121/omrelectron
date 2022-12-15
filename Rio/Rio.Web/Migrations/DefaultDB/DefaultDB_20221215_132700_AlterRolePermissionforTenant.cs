using FluentMigrator;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20221215132700)]
    public class DefaultDB_20221215_132700_AlterRolePermissionforTenant : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:SheetType:View"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:StudentManagement:Modify"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:StudentManagement:Delete"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:StudentManagement:View"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:ExamQuestionManagement:Modify"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:ExamQuestionManagement:Delete"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:ExamQuestionManagement:View"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:ExamResultManagement:View"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:ExamsAndSectionManagement:Modify"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:ExamsAndSectionManagement:Delete"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:ExamsAndSectionManagement:View"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:GroupManagement:Modify"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:GroupManagement:Delete"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:GroupManagement:View"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:ImportedDataManagement:Modify"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:ImportedDataManagement:Delete"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:ImportedDataManagement:View"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:RuleTypeManagement:View"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:ScannedDataManagement:Modify"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:ScannedDataManagement:Delete"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:ScannedDataManagement:View"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:SheetTypeTenant:Modify"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:SheetTypeTenant:Delete"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:SheetTypeTenant:View"
                });

        }
        public override void Down()
        {

        }
    }
}