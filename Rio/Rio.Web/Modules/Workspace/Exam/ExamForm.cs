using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.Exam")]
    [BasedOnRow(typeof(ExamRow), CheckNames = true)]
    public class ExamForm
    {
        [HalfWidth]
        public string Code { get; set; }
        [HalfWidth]
        public string Name { get; set; }
        [TextAreaEditor(Rows = 5)]
        [HalfWidth]
        public string Description { get; set; }
        [HalfWidth]
        public int TotalQuestions { get; set; }
        [HalfWidth]
        public int TotalMarks { get; set; }
        [HalfWidth]
        public float NegativeMarks { get; set; }
        [HalfWidth]
        public short OptionsAvailable { get; set; }
        [HalfWidth]
        public string ResultCriteria { get; set; }
        
    }
}