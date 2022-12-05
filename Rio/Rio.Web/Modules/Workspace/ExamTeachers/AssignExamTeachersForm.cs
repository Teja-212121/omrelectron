using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.AssignExamTeachers")]
    [BasedOnRow(typeof(ExamTeachersRow), CheckNames = true)]
    public class AssignExamTeachersForm
    {
        [DisplayName("Teachers"), LookupEditor(typeof(TeachersRow)), Required]
        public Int64 TeacherId { get; set; }
        [HideOnInsert, HideOnUpdate]
        public String RowIds { get; set; }
    }
}