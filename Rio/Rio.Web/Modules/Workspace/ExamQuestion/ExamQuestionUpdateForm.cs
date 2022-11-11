
namespace Rio.Workspace.Forms
{

    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System.ComponentModel;

    [FormScript("Rio.ExamQuestionUpdateForm")]
    // [BasedOnRow(typeof(Entities.QuestionsRow), CheckNames = true)]
    public class ExamQuestionUpdateForm
    {
        [HideOnInsert, HideOnUpdate]
        [HalfWidth]
        public StringField RowIds { get; set; }
        [HalfWidth]
        [LookupEditor("Workspace.Exam")]
        [DisplayName("Exam")]
        public int ExamId { get; set; }
        [HalfWidth]
        [LookupEditor("Workspace.ExamSection")]
        [DisplayName("ExamSection")]
        public int ExamSectionId { get; set; }
    }
}