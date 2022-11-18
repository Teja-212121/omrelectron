using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.SelectSheetTypeRow;

namespace Rio.Workspace
{
    public interface ISelectSheetTypeDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class SelectSheetTypeDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISelectSheetTypeDeleteHandler
    {
        public SelectSheetTypeDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}