using FluentMigrator;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20231214150300)]
    public class DefaultDB_20231214_150300_UpdateRolePermissionforTenant : Migration
    {
        public override void Up()
        {
            Execute.Sql(@"DELETE FROM RolePermissions");

            #region Tenant Role Update

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
                    PermissionKey = "Workspace:ExamListManagement:Delete"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:ExamListManagement:Modify"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:ExamListManagement:View"
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

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:TeacherManagement:Modify"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:TeacherManagement:Delete"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:TeacherManagement:View"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:ActivationManagement:Delete"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:ActivationManagement:Modify"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Workspace:ActivationManagement:View"
                });
            #endregion

            #region Teacher Role
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "2",
                    PermissionKey = "Workspace:TheoryExamManagement:View"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "2",
                    PermissionKey = "Workspace:TheoryQuestionManagement:View"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "2",
                    PermissionKey = "Workspace:TheoryResultManagement:View"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "2",
                    PermissionKey = "Workspace:ExamListManagement:Delete"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "2",
                    PermissionKey = "Workspace:ExamListManagement:Modify"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "2",
                    PermissionKey = "Workspace:ExamListManagement:View"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "2",
                    PermissionKey = "Workspace:ActivationManagement:Delete"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "2",
                    PermissionKey = "Workspace:ActivationManagement:Modify"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "2",
                    PermissionKey = "Workspace:ActivationManagement:View"
                });
            #endregion

            #region Manager Role

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "3",
                    PermissionKey = "Workspace:StudentManagement:Modify"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "3",
                    PermissionKey = "Workspace:StudentManagement:View"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "3",
                    PermissionKey = "Workspace:ExamQuestionManagement:Modify"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "3",
                    PermissionKey = "Workspace:ExamQuestionManagement:View"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "3",
                    PermissionKey = "Workspace:ExamsAndSectionManagement:Modify"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "3",
                    PermissionKey = "Workspace:ExamsAndSectionManagement:View"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "3",
                    PermissionKey = "Workspace:GroupManagement:Modify"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "3",
                    PermissionKey = "Workspace:GroupManagement:View"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "3",
                    PermissionKey = "Workspace:SheetTypeTenant:Modify"
                });
            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "3",
                    PermissionKey = "Workspace:SheetTypeTenant:View"
                });
            #endregion

            #region Student Role

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "4",
                    PermissionKey = "Workspace:StudentManagement:View"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "4",
                    PermissionKey = "Workspace:GroupManagement:View"
                });

            #endregion

        }
        public override void Down()
        {

        }
    }
}