
using Serenity.ComponentModel;
using System.ComponentModel;

namespace Rio.Workspace
{
    [NestedPermissionKeys]
    [DisplayName("Workspace")]
    public class PermissionKeys
    {
        [Description("[General]")]
        public const string General = "Workspace:General";

        [Description("Groups and Students Management")]
        public const string GroupStudents = "Workspace:GroupStudents";

        [DisplayName("Sheet Types")]
        public class SheetType
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Workspace:SheetType:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Workspace:SheetType:Modify";
            public const string View = "Workspace:SheetType:View";
        }

        [DisplayName("Sheet Types By Tenant")]
        public class SheetTypeTenant
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Workspace:SheetTypeTenant:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Workspace:SheetTypeTenant:Modify";
            public const string View = "Workspace:SheetTypeTenant:View";
        }

        [Description("Exam Management")]
        public const string Exams = "Workspace:Exams";

        [Description("Scanned Data Management")]
        public const string ScannedData = "Workspace:ScannedData";
    }
}
