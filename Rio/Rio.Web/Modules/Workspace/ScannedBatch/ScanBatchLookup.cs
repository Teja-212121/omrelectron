using Rio.Workspace;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Web;

namespace Rio.Workspace.Lookups
{
    [LookupScript("Workspace.ScanBatch", Expiration = 1, Permission = "?")]
    public sealed class ScanBatchLookup : RowLookupScript<ScannedBatchRow>
    {
        public ScanBatchLookup(ISqlConnections sqlConnections)
            : base(sqlConnections)
        {
            IdField = ScannedBatchRow.Fields.Id.PropertyName;
            Permission = "*";
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);

            query.Select(ScannedBatchRow.Fields.Id, ScannedBatchRow.Fields.InsertDate);
        }
    }
}