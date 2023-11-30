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
        public int EStatus { get; set; }
        public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public int IsActive { get; set; }
    }
}