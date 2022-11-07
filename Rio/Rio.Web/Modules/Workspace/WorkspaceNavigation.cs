﻿using Serenity.Navigation;
using MyPages = Rio.Workspace.Pages;

[assembly: NavigationLink(int.MaxValue, "Workspace/Sheet Type", typeof(MyPages.SheetTypeController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Workspace/Group", typeof(MyPages.GroupController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Workspace/Exam", typeof(MyPages.ExamController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Workspace/Exam Section", typeof(MyPages.ExamSectionController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Workspace/Exam Question", typeof(MyPages.ExamQuestionController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Workspace/Student", typeof(MyPages.StudentController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Workspace/Group Student", typeof(MyPages.GroupStudentController), icon: null)]

[assembly: NavigationLink(int.MaxValue, "Workspace/Sheet Type Tenant", typeof(MyPages.SheetTypeTenantController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Workspace/Scanned Batch", typeof(MyPages.ScannedBatchController), icon: null)]
