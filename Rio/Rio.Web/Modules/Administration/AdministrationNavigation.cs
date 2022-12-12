using Serenity.Navigation;
using MyPages = Rio.Administration.Pages;
using Administration = Rio.Administration.Pages;

[assembly: NavigationMenu(9000, "Administration", icon: "fa-tools")]
[assembly: NavigationLink(9100, "Administration/Data Audit Log", typeof(Serenity.Pro.DataAuditLog.DataAuditLogController), icon: "fa-history premium-feature")]
[assembly: NavigationLink(9200, "Administration/Data Explorer", typeof(Serenity.Pro.DataExplorer.DataExplorerController), icon: "fa-database premium-feature")]
[assembly: NavigationLink(9300, "Administration/Email Queue", typeof(Serenity.Pro.EmailQueue.EmailQueueController), icon: "fa-envelope-o premium-feature")]
[assembly: NavigationLink(9400, "Administration/Exception Log", typeof(Administration.UserController), action: "ExceptionLog", icon: "fa-ban", Target = "_blank")]
[assembly: NavigationLink(9500, "Administration/Languages", typeof(Administration.LanguageController), icon: "fa-comments")]
[assembly: NavigationLink(9600, "Administration/Translations", typeof(Administration.TranslationController), icon: "fa-comment-o")]
[assembly: NavigationLink(9700, "Administration/Roles", typeof(Administration.RoleController), icon: "fa-lock")]
[assembly: NavigationLink(9800, "Administration/User Management", typeof(Administration.UserController), icon: "fa-users")]
[assembly: NavigationLink(9900, "Administration/Tenant", typeof(MyPages.TenantController), icon: "fa-users")]
