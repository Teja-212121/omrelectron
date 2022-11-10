
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

        [Description("Sheets Management")]
        public const string Sheets = "Workspace:Sheets";

        [Description("Exam Management")]
        public const string Exams = "Workspace:Exams";

        [Description("Scanned Data Management")]
        public const string ScannedData = "Workspace:ScannedData";
    }
}
