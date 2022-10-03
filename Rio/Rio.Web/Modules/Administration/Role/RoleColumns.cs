using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Administration.Forms
{
    [ColumnsScript("Administration.Role")]
    [BasedOnRow(typeof(RoleRow), CheckNames = true)]
    public class RoleColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 RoleId { get; set; }
        [EditLink, Width(300)]
        public String RoleName { get; set; }
        [EditLink, Width(200)]
        public String RoleKey { get; set; }
    }
}