using Rio.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.Student")]
    [BasedOnRow(typeof(StudentRow), CheckNames = true)]
    public class StudentForm
    {
        [HalfWidth]
        public Guid StudentId { get; set; }
        [HalfWidth]
        public long RollNo { get; set; }
        [HalfWidth]
        public string FullName { get; set; }
        [EmailEditor]
        public string Email { get; set; }
        [HalfWidth]
        public string Mobile { get; set; }
        [HalfWidth]
        public DateTime Dob { get; set; }
        [HalfWidth]
        public Gender Gender { get; set; }
        [TextAreaEditor(Rows = 3)]
        public string Note { get; set; }
        [TextAreaEditor(Rows = 3)]
        public string Comments { get; set; }
    }
}