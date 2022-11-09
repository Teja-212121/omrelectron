using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace Rio.Workspace
{
    [ConnectionKey("Default"), Module("Workspace"), TableName("[dbo].[RuleTypes]")]
    [DisplayName("Rule Type"), InstanceName("Rule Type")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Workspace.RuleType")]
    public sealed class RuleTypeRow : Row<RuleTypeRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        [SortOrder(1, descending: true)]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Name"), Size(500), NotNull, QuickSearch, NameProperty]
        public string Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }

        [DisplayName("Description"), Size(2000), NotNull]
        public string Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        public RuleTypeRow()
            : base()
        {
        }

        public RuleTypeRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Name;
            public StringField Description;
        }
    }
}