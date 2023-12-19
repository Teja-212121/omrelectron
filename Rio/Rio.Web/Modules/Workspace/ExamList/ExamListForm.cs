using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.ExamList")]
    [BasedOnRow(typeof(ExamListRow), CheckNames = true)]
    public class ExamListForm
    {
        [HalfWidth]
        public string Name { get; set; }
        [TextAreaEditor(Rows =3)]
        [HalfWidth]
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        [HalfWidth]
        public int TenantId { get; set; }
    }
}