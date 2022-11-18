using Serenity.Data;
using Serenity.Services;
using Serenity.Web;
using System.Net;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.SelectSheetTypeRow>;
using MyRow = Rio.Workspace.SelectSheetTypeRow;

namespace Rio.Workspace
{
    public interface ISelectSheetTypeListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class SelectSheetTypeListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISelectSheetTypeListHandler
    {
        public SelectSheetTypeListHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override MyRow ProcessEntity(MyRow row)
        {
            row.OverlayImage = VirtualPathUtility.ToAbsolute(row.OverlayImage, "~/upload/");
            return base.ProcessEntity(row);
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);


            /*if (!Authorization.HasPermission(Administration.PermissionKeys.Security))
            {
                query.Where(MyRow.Fields.IsPrivate == 0);
                query.Where("T0.Id not in (Select SheetTypeId from SheetTypesTenants where TenantId = " + ((UserDefinition)Authorization.UserDefinition).TenantId + ")");
            }*/
        }
    }
}