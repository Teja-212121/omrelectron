using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.ExamTeachers")]
    [BasedOnRow(typeof(ExamTeachersRow), CheckNames = true)]
    public class ExamTeachersForm
    {
        public long TheoryExamId { get; set; }
        public long TeacherId { get; set; }
        public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public short IsActive { get; set; }
        public int TenantId { get; set; }
    }
}