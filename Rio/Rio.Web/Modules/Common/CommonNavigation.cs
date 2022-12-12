using Serenity.Navigation;
using MyPages = Rio.Common.Pages;

[assembly: NavigationMenu(10000, "Common", icon: "fa-circle-o")]
[assembly: NavigationLink(10001, "Common/Mail", typeof(MyPages.MailController), icon: "fa-envelope-o")]