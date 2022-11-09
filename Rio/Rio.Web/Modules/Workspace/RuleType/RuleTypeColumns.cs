using Serenity.ComponentModel;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.RuleType")]
    [BasedOnRow(typeof(RuleTypeRow), CheckNames = true)]
    public class RuleTypeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}