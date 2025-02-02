using Serenity.Navigation;
using MyPages = Rio.Workspace.Pages;
using MyPage = Rio.Common.Pages;

[assembly: NavigationMenu(2000, "Sheets", icon: "fa-files-o")]
[assembly: NavigationLink(2001, "Sheets/Sheet Types", typeof(MyPages.SheetTypeController), icon: "fa-circle-o")]
[assembly: NavigationLink(2003, "Sheets/My Sheet Types", typeof(MyPages.SheetTypeTenantController), icon: "fa-circle-o")]

[assembly: NavigationMenu(3000, "Exams", icon: "fa-pencil-square-o")]
[assembly: NavigationLink(3001, "Exams/Exams", typeof(MyPages.ExamController), icon: "fa-circle-o")]
[assembly: NavigationLink(3002, "Exams/Exam List", typeof(MyPages.ExamListController), icon: "fa-circle-o")]
/*[assembly: NavigationLink(3003, "Exams/Exam List Exams", typeof(MyPages.ExamListExamsController), icon: "fa-circle-o")]
[assembly: NavigationLink(3002, "Exams/Exam Sections", typeof(MyPages.ExamSectionController), icon: "fa-circle-o")]
[assembly: NavigationLink(3003, "Exams/Exam Questions", typeof(MyPages.ExamQuestionController), icon: "fa-circle-o")]*/

[assembly: NavigationMenu(4000, "Activation", icon: "fa fa-check")]
[assembly: NavigationLink(4001, "Activation/Pre Defined Key", typeof(MyPages.PreDefinedKeyController), icon: "fa-circle-o", Permission = ("Administrattion:Security"))]
[assembly: NavigationLink(4002, "Activation/Serial Key", typeof(MyPages.SerialKeyController), icon: "fa-circle-o")]
[assembly: NavigationLink(4003, "Activation/Coupon Code", typeof(MyPages.CouponCodeController), icon: "fa-circle-o")]
[assembly: NavigationLink(4004, "Activation/Activation", typeof(MyPages.ActivationController), icon: "fa-circle-o")]
//[assembly: NavigationLink(4005, "Activation/Activation Log", typeof(MyPages.ActivationLogController), icon: "fa-circle-o")]

[assembly: NavigationMenu(5000, "Students", icon: "fa-users")]
[assembly: NavigationLink(5001, "Students/Students", typeof(MyPages.StudentController), icon: "fa-circle-o")]
[assembly: NavigationLink(5002, "Students/Groups", typeof(MyPages.GroupController), icon: "fa-circle-o")]
[assembly: NavigationLink(5003, "Students/Group Students", typeof(MyPages.GroupStudentController), icon: "fa-circle-o")]

[assembly: NavigationMenu(6000, "Scanned Data", icon: "fa-files-o")]
[assembly: NavigationLink(6001, "Scanned Data/Scanned Batches", typeof(MyPages.ScannedBatchController), icon: "fa-circle-o")]
[assembly: NavigationLink(6002, "Scanned Data/Scanned Sheets", typeof(MyPages.ScannedSheetController), icon: "fa-circle-o")]
[assembly: NavigationLink(6003, "Scanned Data/Scanned Questions", typeof(MyPages.ScannedQuestionController), icon: "fa-circle-o")]
[assembly: NavigationLink(6004, "Scanned Data/Imported Batches", typeof(MyPages.ImportedScannedBatchController), icon: "fa-circle-o")]
[assembly: NavigationLink(6005, "Scanned Data/Imported Sheets", typeof(MyPages.ImportedScannedSheetController), icon: "fa-circle-o")]
[assembly: NavigationLink(6006, "Scanned Data/Imported  Questions", typeof(MyPages.ImportedScannedQuestionController), icon: "fa-circle-o")]

[assembly: NavigationMenu(7000, "Master", icon: "fa-graduation-cap")]
[assembly: NavigationLink(7001, "Master/Rule Types", typeof(MyPages.RuleTypeController), icon: "fa-circle-o")]
[assembly: NavigationLink(7002, "Master/Cloud Storage Provider", typeof(MyPages.CloudStorageProviderController), icon:"fa-solid fa-cloud")]
[assembly: NavigationLink(7003, "Master/Cloud Storage Setting", typeof(MyPages.CloudStorageSettingController), "fa-solid fa-gears")]
[assembly: NavigationMenu(8000, "Reports", icon: "fa-files-o")]
[assembly: NavigationLink(8001, "Reports/Exam Results", typeof(MyPages.ExamResultController), icon: "fa-circle-o")]
[assembly: NavigationLink(8002, "Reports/Exam Section Results", typeof(MyPages.ExamSectionResultController), icon: "fa-circle-o")]
[assembly: NavigationLink(8003, "Reports/Exam Question Results", typeof(MyPages.ExamQuestionResultController), icon: "fa-circle-o")]
[assembly: NavigationLink(8004, "Reports/Exam Group Wise Results", typeof(MyPages.ExamGroupWiseResultController), icon: "fa-circle-o")]
[assembly: NavigationLink(8005, "Reports/Exam Rank Wise Results", typeof(MyPages.ExamRankWiseResultController), icon: "fa-circle-o")]

[assembly: NavigationMenu(6100, "Users", icon:"fa-Users")]
[assembly: NavigationLink(6101, "Users/Teachers", typeof(MyPages.TeachersController), icon: "fa-User")]

[assembly: NavigationMenu(10000, "Workspace", icon: "fa-building-o")]
[assembly: NavigationLink(10002, "Workspace/Exam Teachers", typeof(MyPages.ExamTeachersController), icon: "fa-circle-o")]
[assembly: NavigationLink(10003, "Workspace/Theory Exams", typeof(MyPages.TheoryExamsController), icon: "fa-circle-o")]
[assembly: NavigationLink(10004, "Workspace/Theory Exam Sections", typeof(MyPages.TheoryExamSectionsController), icon: "fa-circle-o")]
[assembly: NavigationLink(10005, "Workspace/Theory Exam Questions", typeof(MyPages.TheoryExamQuestionsController), icon: "fa-circle-o")]
[assembly: NavigationLink(10006, "Workspace/Theory Exam Results", typeof(MyPages.TheoryExamResultsController), icon: "fa-circle-o")]
[assembly: NavigationLink(10007, "Workspace/Theory Exam Result Questions", typeof(MyPages.TheoryExamResultQuestionsController), icon: "fa-circle-o")]

//[assembly: NavigationLink(2002, "Sheets/Select Sheet Type", typeof(MyPages.SelectSheetTypeController), icon: "fa-circle-o")]
//[assembly: NavigationLink(int.MaxValue, "Workspace/Scanned Batch As Per Date", typeof(MyPages.ScannedBatchAsPerDateController), icon: null)]
[assembly: NavigationLink(10008, "Workspace/Get Scan Data", typeof(MyPages.GetScanDataController), icon: "fa-circle-o")]
//[assembly: NavigationLink(10009, "Workspace/Settings", typeof(MyPages.SettingsController), icon: "fa-circle-o")]
//[assembly: NavigationLink(int.MaxValue, "Workspace/Key Gen As", typeof(MyPages.KeyGenAsController), icon: null)]
