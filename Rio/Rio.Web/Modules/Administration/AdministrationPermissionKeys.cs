
using Serenity.ComponentModel;
using System.ComponentModel;

namespace Rio.Administration
{
    [NestedPermissionKeys]
    [DisplayName("Administration")]
    public class PermissionKeys
    {
        [Description("User, Role Management and Permissions")]
        public const string Security = "Administration:Security";

        [Description("Languages and Translations")]
        public const string Translation = "Administration:Translation";

        [Description("Publisher")]
        public const string Tenants = "Administration:Tenants";

        [Description("Manager")]
        public const string Managers = "Administration:Managers";

        [Description("Student")]
        public const string Student = "Administration:Students";

        [Description("Teachers")]
        public const string Teachers = "Administration:Teachers";
    }
}
