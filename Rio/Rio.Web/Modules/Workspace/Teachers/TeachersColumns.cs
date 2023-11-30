using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.Teachers")]
    [BasedOnRow(typeof(TeachersRow), CheckNames = true)]
    public class TeachersColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public long Id { get; set; }
        [EditLink]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime Dob { get; set; }
        public string AllowedIps { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int UserId { get; set; }
        public string SchoolOrInstitute { get; set; }
      
        public int TenantId { get; set; }
    }
}