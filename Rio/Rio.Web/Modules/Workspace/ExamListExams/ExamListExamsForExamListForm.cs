using Serenity.ComponentModel;

using System.ComponentModel;

using System;

namespace Rio.Workspace.Forms;
[FormScript("Rio.ExamListExamsForExamListForm")]
public class ExamListExamsForExamListForm
{
    [HideOnInsert, HideOnUpdate]
    public String RowIds { get; set; }
    [HalfWidth]
    [LookupEditor(typeof(ExamListRow))]
    [Required]
    public int ExamListId { get; set; }
    [HalfWidth]
    public DateTime StartDate { get; set; }
    [HalfWidth]
    public DateTime EndDate { get; set; }
    [HalfWidth]
    public DateTime ModelAnswerPaperStartDate { get; set; }
}