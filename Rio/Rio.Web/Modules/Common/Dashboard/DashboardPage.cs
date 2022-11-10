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
            [FromServices] ISqlConnections sqlConnections
            )
        {
            DashboardPageModel model = new DashboardPageModel();
            using (var Connection = sqlConnections.NewByKey("Default"))
            {
                model.TotalStudents = Connection.List<StudentRow>().Count;
                model.TotalScannedSheets = Connection.List<ScannedSheetRow>().Count;
                model.TotalTests = Connection.List<ExamRow>().Count;
                model.TotalAssignedSheet = Connection.List<SheetTypeRow>().Count;
                model.BalanceSheet = Connection.List<SheetTypeRow>().Count;
                model.TotalCustomers = Connection.List<TenantRow>().Count;

                return View(MVC.Views.Common.Dashboard.DashboardIndex, model);
            }

        }
    }
}
