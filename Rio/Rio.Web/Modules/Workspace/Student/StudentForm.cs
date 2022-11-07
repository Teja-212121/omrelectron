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
        public long RollNo { get; set; }
        /*public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }*/
        [HalfWidth]
        public string FullName { get; set; }
        [EmailEditor]
        public string Email { get; set; }
        [HalfWidth]
        public string Mobile { get; set; }
        [HalfWidth]
        public DateTime Dob { get; set; }
        [HalfWidth]
        public short Gender { get; set; }
        [TextAreaEditor(Rows = 3)]
        public string Note { get; set; }
    }
}