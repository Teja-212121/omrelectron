﻿using Microsoft.AspNetCore.Mvc;
using Serenity;
using Serenity.Data;
using System;

namespace Rio
{
    public static class GridPageExtensions
    {
        public static string PageTitle(this RowFieldsBase fields)
        {
            return "Db." + fields.LocalTextPrefix + ".EntityPlural";
        }

        public static ViewResult GridPage(this Controller controller,
            string module, LocalText pageTitle)
        {
            if (module == null)
                throw new ArgumentNullException(nameof(module));

            if (module.StartsWith("@/"))
                module = "~/esm/Modules/" + module[2..];

            return controller.View(MVC.Views.Shared.GridPage, new GridPageModel
            {
                Module = module,
                PageTitle = pageTitle
            });
        }
    }
}