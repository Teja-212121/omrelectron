using Serenity.Navigation;
using MyPages = Rio.Workspace.Pages;


[assembly: NavigationMenu(2000, "Sheets", icon: "fa-files-o")]
[assembly: NavigationLink(2001, "Sheets/Sheet Type", typeof(MyPages.SheetTypeController), icon: "fa-circle-o")]
[assembly: NavigationLink(2002, "Sheets/My Sheet Types", typeof(MyPages.SheetTypeTenantController), icon: "fa-circle-o")]

[assembly: NavigationMenu(3000, "Exams", icon: "fa-pencil-square-o")]
[assembly: NavigationLink(3001, "Exams/Exam", typeof(MyPages.ExamController), icon: "fa-circle-o")]
[assembly: NavigationLink(3002, "Exams/Exam Section", typeof(MyPages.ExamSectionController), icon: "fa-circle-o")]
[assembly: NavigationLink(3003, "Exams/Exam Question", typeof(MyPages.ExamQuestionController), icon: "fa-circle-o")]

[assembly: NavigationMenu(4000, "Students", icon: "fa-users")]
[assembly: NavigationLink(4001, "Students/Student", typeof(MyPages.StudentController), icon: "fa-circle-o")]
[assembly: NavigationLink(4002, "Students/Groups", typeof(MyPages.GroupController), icon: "fa-circle-o")]
[assembly: NavigationLink(4003, "Students/Group Students", typeof(MyPages.GroupStudentController), icon: "fa-circle-o")]

[assembly: NavigationMenu(5000, "Scanned Data", icon: "fa-files-o")]
[assembly: NavigationLink(5001, "Scanned Data/Scanned Batches", typeof(MyPages.ScannedBatchController), icon: "fa-circle-o")]
[assembly: NavigationLink(5002, "Scanned Data/Scanned Sheet", typeof(MyPages.ScannedSheetController), icon: "fa-circle-o")]
[assembly: NavigationLink(5003, "Scanned Data/Scanned Question", typeof(MyPages.ScannedQuestionController), icon: "fa-circle-o")]
[assembly: NavigationLink(5004, "Scanned Data/Imported Batch", typeof(MyPages.ImportedScannedBatchController), icon: "fa-circle-o")]
[assembly: NavigationLink(5005, "Scanned Data/Imported Sheet", typeof(MyPages.ImportedScannedSheetController), icon: "fa-circle-o")]
[assembly: NavigationLink(5006, "Scanned Data/Imported  Question", typeof(MyPages.ImportedScannedQuestionController), icon: "fa-circle-o")]


