using Microsoft.AspNetCore.Mvc;
using Rio.Administration;
using Rio.Workspace;
using Serenity;
using Serenity.Abstractions;
using Serenity.Data;
using Serenity.Web;
using System;

namespace Rio.Common.Pages
{
    [Route("Dashboard/[action]")]
    public class DashboardController : Controller
    {
        [PageAuthorize, HttpGet, Route("~/")]
        public ActionResult Index(
            [FromServices] ITwoLevelCache cache,
            [FromServices] ISqlConnections sqlConnections,
            [FromServices] IPermissionService permissions
            )
        {
            DashboardPageModel model = new DashboardPageModel();
            using (var Connection = sqlConnections.NewByKey("Default"))
            {
                if (permissions.HasPermission("Administration.Security"))
                {
                    model.TotalStudents = Connection.List<StudentRow>().Count;
                    model.TotalScannedSheets = Connection.List<ScannedSheetRow>().Count;
                    model.TotalTests = Connection.List<ExamRow>().Count;
                    model.TotalAssignedSheet = Connection.List<SheetTypeTenantRow>().Count;
                    model.BalanceSheet = Connection.List<SheetTypeRow>().Count;
                    model.TotalCustomers = Connection.List<TenantRow>().Count;
                }
                else
                {
                    var tenantId = Connection.TryFirst<UserRow>(UserRow.Fields.UserId == User.GetIdentifier()).TenantId;
                    model.TotalStudents = Connection.List<StudentRow>(StudentRow.Fields.TenantId == tenantId.Value).Count;
                    model.TotalScannedSheets = Connection.List<ScannedSheetRow>(ScannedSheetRow.Fields.TenantId == tenantId.Value).Count;
                    model.TotalTests = Connection.List<ExamRow>(ExamRow.Fields.TenantId == tenantId.Value).Count;
                    model.TotalAssignedSheet = Connection.List<SheetTypeTenantRow>(SheetTypeTenantRow.Fields.TenantId == tenantId.Value).Count;
                    model.BalanceSheet = Connection.List<SheetTypeRow>().Count;
                    model.TotalCustomers = Connection.List<TenantRow>(ScannedSheetRow.Fields.TenantId == tenantId.Value).Count;
                }
                return View(MVC.Views.Common.Dashboard.DashboardIndex, model);

            }

        }
    }
}
