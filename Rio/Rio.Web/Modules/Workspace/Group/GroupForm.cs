using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.Group")]
    [BasedOnRow(typeof(GroupRow), CheckNames = true)]
    public class GroupForm
    {
        [HalfWidth]
        public string Name { get; set; }
        [HalfWidth]
        public int ParentId { get; set; }
        [TextAreaEditor(Rows = 3)]
        public string Description { get; set; }
    }
}