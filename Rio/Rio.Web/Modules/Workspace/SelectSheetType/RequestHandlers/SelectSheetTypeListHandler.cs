using Serenity.Services;
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
    }
}