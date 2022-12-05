using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.Teachers")]
    [BasedOnRow(typeof(TeachersRow), CheckNames = true)]
    public class TeachersForm
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        //public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime Dob { get; set; }
        public string AllowedIps { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
       // public int UserId { get; set; }
       
    }
}