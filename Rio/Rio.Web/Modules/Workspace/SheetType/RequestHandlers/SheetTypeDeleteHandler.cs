using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.SheetTypeRow;

namespace Rio.Workspace
{
    public interface ISheetTypeDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class SheetTypeDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISheetTypeDeleteHandler
    {
        public SheetTypeDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}