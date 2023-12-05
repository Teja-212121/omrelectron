using Rio.Web.Enums;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.SerialKey")]
    [BasedOnRow(typeof(SerialKeyRow), CheckNames = true)]
    public class SerialKeyColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string SerialKey { get; set; }
        public string ExamListName { get; set; }
        public int ValidityType { get; set; }
        public int ValidityInDays { get; set; }
        public DateTime ValidDate { get; set; }
        public string Note { get; set; }
        public KeyStatus EStatus { get; set; }
        
    }
}