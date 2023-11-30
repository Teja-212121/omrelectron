using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.GroupStudent")]
    [BasedOnRow(typeof(GroupStudentRow), CheckNames = true)]
    public class GroupStudentColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public long Id { get; set; }
        [EditLink, QuickFilter]
        public string GroupName { get; set; }
        public int StudentRollNo { get; set; }
        public String StudentFullName { get; set; }
        public string StudentEmail { get; set; }
        public int StudentMobile { get; set; }
        public DateTime StudentDob { get; set; }
        public short StudentGender { get; set; }
        public string StudentNote { get; set; }

        public int TeacherId { get; set; }
        /*public int StudentTenantName { get; set; }*/
    }
}