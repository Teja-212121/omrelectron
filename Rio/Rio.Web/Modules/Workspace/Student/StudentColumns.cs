using Rio.Web.Enums;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.Student")]
    [BasedOnRow(typeof(StudentRow), CheckNames = true)]
    public class StudentColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public long Id { get; set; }
        public long RollNo { get; set; }
        [EditLink]
        /*public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }*/
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime Dob { get; set; }
        public Gender Gender { get; set; }
        public string Note { get; set; }
        [QuickFilter]
        [DisplayName("Insert Date")]
        public DateTime InsertDate { get; set; }
    }
}