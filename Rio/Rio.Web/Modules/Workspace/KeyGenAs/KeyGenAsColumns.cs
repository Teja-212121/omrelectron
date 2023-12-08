using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.KeyGenAs")]
    [BasedOnRow(typeof(KeyGenAsRow), CheckNames = true)]
    public class KeyGenAsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string ExamListName { get; set; }
        public int ValidityType { get; set; }
        public int ValidityInDays { get; set; }
        public DateTime ValidDate { get; set; }
        [EditLink]
        public string Note { get; set; }
        public int EStatus { get; set; }
        public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public int IsActive { get; set; }
    }
}