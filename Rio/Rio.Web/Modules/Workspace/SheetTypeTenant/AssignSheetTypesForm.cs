using Serenity.ComponentModel;
using System;
using System.ComponentModel;
using Rio.Administration;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.AssignSheetTypesForm")]
    [BasedOnRow(typeof(SheetTypeTenantRow))]
    public class AssignSheetTypesForm
    {
       
        [DisplayName("Tenants"),LookupEditor(typeof(TenantRow)),Required]
        public Int64 Tenants { get; set; }
        [HideOnInsert, HideOnUpdate]
        public String RowIds { get; set; }

    }
}