
namespace MVC
{
    public static class Views
    {
        public static class Common
        {
            public static class Dashboard
            {
                public const string DashboardIndex = "~/Modules/Common/Dashboard/DashboardIndex.cshtml";
            }
        }

        public static class Errors
        {
            public const string AccessDenied = "~/Views/Errors/AccessDenied.cshtml";
            public const string ValidationError = "~/Views/Errors/ValidationError.cshtml";
        }

        public static class ExamQuestionResult
        {
            public const string ExamQuestionResultPivot = "~/Views/ExamQuestionResult/ExamQuestionResultPivot.cshtml";
        }

        public static class ExamResult
        {
            public const string ExamResultEmail = "~/Views/ExamResult/ExamResultEmail.cshtml";
            public const string ExamResultReport = "~/Views/ExamResult/ExamResultReport.cshtml";
            public const string ExamSectionResultNormalReport = "~/Views/ExamResult/ExamSectionResultNormalReport.cshtml";
            public const string ExamsectionResultPivotReport = "~/Views/ExamResult/ExamsectionResultPivotReport.cshtml";
        }

        public static class Membership
        {
            public static class Account
            {
                public const string AccountLogin = "~/Modules/Membership/Account/AccountLogin.cshtml";
                public static class ChangePassword
                {
                    public const string AccountChangePassword = "~/Modules/Membership/Account/ChangePassword/AccountChangePassword.cshtml";
                }

                public static class ForgotPassword
                {
                    public const string AccountForgotPassword = "~/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.cshtml";
                }

                public static class ResetPassword
                {
                    public const string AccountResetPassword = "~/Modules/Membership/Account/ResetPassword/AccountResetPassword.cshtml";
                    public const string AccountResetPasswordEmail = "~/Modules/Membership/Account/ResetPassword/AccountResetPasswordEmail.cshtml";
                }

                public static class SignUp
                {
                    public const string AccountActivateEmail = "~/Modules/Membership/Account/SignUp/AccountActivateEmail.cshtml";
                    public const string AccountSignUp = "~/Modules/Membership/Account/SignUp/AccountSignUp.cshtml";
                    public const string PublisherActivateEmail = "~/Modules/Membership/Publisher/SignUp/PublisherActivateEmail.cshtml";
                    public const string PublisherSignUp = "~/Modules/Membership/Publisher/SignUp/PublisherSignUp.cshtml";
                    public const string TeacherSignupEmail = "~/Modules/Membership/Publisher/SignUp/TeacherSignupEmail.cshtml";
                    public const string TenantApprovedEmail = "~/Modules/Membership/Publisher/SignUp/TenantApprovedEmail.cshtml";
                    public const string TenantSignupEmail = "~/Modules/Membership/Publisher/SignUp/TenantSignupEmail.cshtml";
                }
            }
        }

        public static class Rectify
        {
            public const string ScanQuestions = "~/Views/Rectify/ScanQuestions.cshtml";
        }

        public static class Shared
        {
            public const string _Layout = "~/Views/Shared/_Layout.cshtml";
            public const string _LayoutHead = "~/Views/Shared/_LayoutHead.cshtml";
            public const string _LayoutNoNavigation = "~/Views/Shared/_LayoutNoNavigation.cshtml";
            public const string _Sidebar = "~/Views/Shared/_Sidebar.cshtml";
            public const string Error = "~/Views/Shared/Error.cshtml";
            public const string GridPage = "~/Views/Shared/GridPage.cshtml";
        }

        public static class Workspace
        {
            public static class ScannedSheet
            {
                public const string ScannedSheetIndex = "~/Modules/Workspace/ScannedSheet/ScannedSheetIndex.cshtml";
            }

            public static class SerialKey
            {
                public const string SerialKeyIndex = "~/Modules/Workspace/SerialKey/SerialKeyIndex.cshtml";
            }

        }

    }
}
