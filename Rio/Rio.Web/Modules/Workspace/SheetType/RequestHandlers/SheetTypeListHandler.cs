using Serenity.Services;
using Serenity.Web;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.SheetTypeRow>;
using MyRow = Rio.Workspace.SheetTypeRow;

namespace Rio.Workspace
{
    public interface ISheetTypeListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class SheetTypeListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISheetTypeListHandler
    {
        public SheetTypeListHandler(IRequestContext context)
             : base(context)
        {
        }
        protected override MyRow ProcessEntity(MyRow row)
        {
            Row.OverlayImage = VirtualPathUtility.ToAbsolute("","~/upload/" + Row.OverlayImage);
            return base.ProcessEntity(row);
        }
    }
}