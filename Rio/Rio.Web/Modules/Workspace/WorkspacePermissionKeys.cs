
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

        [DisplayName("Groups Management")]
        public class GroupManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Workspace:GroupManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Workspace:GroupManagement:Modify";
            public const string View = "Workspace:GroupManagement:View";
        }

        [DisplayName("Students Management")]
        public class StudentManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Workspace:StudentManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Workspace:StudentManagement:Modify";
            public const string View = "Workspace:StudentManagement:View";
        }

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
        public class Exams
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Workspace:Exams:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Workspace:Exams:Modify";
            public const string View = "Workspace:Exams:View";
        }

        [Description("Scanned Data Management")]
        public class ScannedData
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Workspace:ScannedData:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Workspace:ScannedData:Modify";
            public const string View = "Workspace:ScannedData:View";
        }
    }
}
