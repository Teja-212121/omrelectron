using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.GroupStudent")]
    [BasedOnRow(typeof(GroupStudentRow), CheckNames = true)]
    public class GroupStudentForm
    {
        [HalfWidth]
        public int GroupId { get; set; }
        [HalfWidth]
        public long StudentId { get; set; }
        [HalfWidth]
        public int TeacherId { get; set; }
    }
}