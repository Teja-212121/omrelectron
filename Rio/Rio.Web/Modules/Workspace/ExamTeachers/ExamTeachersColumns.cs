using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.ExamTeachers")]
    [BasedOnRow(typeof(ExamTeachersRow), CheckNames = true)]
    public class ExamTeachersColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public long Id { get; set; }
        [QuickFilter,FilterOnly]
        public long TheoryExamId { get; set; }
        [QuickFilter, FilterOnly]
        public long TeacherId { get; set; }
        public string TheoryExamCode { get; set; }
        public string TeacherFirstName { get; set; }
       
    }
}