
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

        [Description("Exams And Section Management")]
        public class ExamsAndSectionManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Workspace:ExamsAndSectionManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Workspace:ExamsAndSectionManagement:Modify";
            public const string View = "Workspace:ExamsAndSectionManagement:View";
        }

        [DisplayName("Exam Question Management")]
        public class ExamQuestionManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Workspace:ExamQuestionManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Workspace:ExamQuestionManagement:Modify";
            public const string View = "Workspace:ExamQuestionManagement:View";
        }

        [DisplayName("ExamList Management")]
        public class ExamListManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Workspace:ExamListManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Workspace:ExamListManagement:Modify";
            public const string View = "Workspace:ExamListManagement:View";
        }


        [DisplayName("Activation Management")]
        public class ActivationManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Workspace:ActivationManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Workspace:ActivationManagement:Modify";
            public const string View = "Workspace:ActivationManagement:View";
        }

        [DisplayName("Exam Result Management")]
        public class ExamResultManagement
        {
            public const string View = "Workspace:ExamResultManagement:View";
        }

        [DisplayName("RuleType Management")]
        public class RuleTypeManagement
        {
            public const string View = "Workspace:RuleTypeManagement:View";
        }

        [Description("Scanned Data Management")]
        public class ScannedDataManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Workspace:ScannedDataManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Workspace:ScannedDataManagement:Modify";
            public const string View = "Workspace:ScannedDataManagement:View";
        }

        [Description("Imported Data Management")]
        public class ImportedDataManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Workspace:ImportedDataManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Workspace:ImportedDataManagement:Modify";
            public const string View = "Workspace:ImportedDataManagement:View";
        }

        [DisplayName("Teacher Management")]
        public class TeacherManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Workspace:TeacherManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Workspace:TeacherManagement:Modify";
            public const string View = "Workspace:TeacherManagement:View";
        }

        [Description("Theory Exam Management")]
        public class TheoryExamManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Workspace:TheoryExamManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Workspace:TheoryExamManagement:Modify";
            public const string View = "Workspace:TheoryExamManagement:View";
        }

        [Description("Theory Question Management")]
        public class TheoryQuestionManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Workspace:TheoryQuestionManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Workspace:TheoryQuestionManagement:Modify";
            public const string View = "Workspace:TheoryQuestionManagement:View";
        }

        [Description("Theory Result Management")]
        public class TheoryResultManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Workspace:TheoryResultManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Workspace:TheoryResultManagement:Modify";
            public const string View = "Workspace:TheoryResultManagement:View";
        }
    }
}
