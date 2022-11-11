using Serenity.ComponentModel;
using Serenity.Data;
using System.ComponentModel;
using Serenity.Data.Mapping;

namespace Rio.Workspace.Forms
{
    [FormScript("Rio.GroupStudentsForStudentsForm")]
    public class GroupStudentsForStudentsForm
    {
        [HideOnInsert, HideOnUpdate]
        public string RowIds { get; set; }
        [HalfWidth]
        [DisplayName("Group Name"), QuickSearch, NameProperty]
        [LookupEditor("Workspace.Group")]
        public Int32Field GroupId { get; set; }
    }
}