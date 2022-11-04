﻿using Serenity.Navigation;
using MyPages = Rio.Workspace.Pages;

[assembly: NavigationLink(int.MaxValue, "Workspace/Sheet Type", typeof(MyPages.SheetTypeController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Workspace/Group", typeof(MyPages.GroupController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Workspace/Exam", typeof(MyPages.ExamController), icon: null)]