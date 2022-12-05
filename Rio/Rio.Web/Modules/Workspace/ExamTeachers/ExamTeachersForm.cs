using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.ExamTeachers")]
    [BasedOnRow(typeof(ExamTeachersRow), CheckNames = true)]
    public class ExamTeachersForm
    {
        [Required(true)]
        public long TheoryExamId { get; set; }
        public long TeacherId { get; set; }
      
    }
}