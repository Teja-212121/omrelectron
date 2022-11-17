using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Web;

namespace Rio.Workspace.Lookups
{
    [LookupScript, Module("Workspace")]
    public class ExamSectionLookup : RowLookupScript<ExamSectionRow>
    {
        public ExamSectionLookup(ISqlConnections sqlConnections)
            : base(sqlConnections)
        {
            IdField = TextField = ExamSectionRow.Fields.Name.PropertyName;
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            var fld = ExamSectionRow.Fields;
            query.Distinct(true)
                .Select(fld.ExamId)
                .Select(fld.Name)
                .Where(
                    new Criteria(fld.ExamId) != "" &
                    new Criteria(fld.ExamId).IsNotNull() &
                    new Criteria(fld.Name) != "" &
                    new Criteria(fld.Name).IsNotNull());
        }

        protected override void ApplyOrder(SqlQuery query)
        {
        }
    }
}