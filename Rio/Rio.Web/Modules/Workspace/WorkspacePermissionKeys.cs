
using Serenity.ComponentModel;
using System.ComponentModel;

namespace Rio.Workspace
{
    [NestedPermissionKeys]
    [DisplayName("Workspace")]
    public class PermissionKeys
    {
        [Description("Groups and Students Management")]
        public const string GroupStudents = "Workspace:GroupStudents";

        [Description("Read")]
        public const string Sheets_SheetType_Read = "Workspace:Sheets:SheetType:Read";

        [Description("Modify")]
        public const string Sheets_SheetType_Modify = "Workspace:Sheets:SheetType:Modify";

        [Description("Read")]
        public const string Sheets_SheetTypesTenant_Read = "Workspace:Sheets:SheetTypesTenant:Read";

        [Description("Modify")]
        public const string Sheets_SheetTypesTenant_Modify = "Workspace:Sheets:SheetTypesTenant:Modify";

        [Description("Exam Management")]
        public const string Exams = "Workspace:Exams";

        [Description("Scanned Data Management")]
        public const string ScannedData = "Workspace:ScannedData";
    }
}
