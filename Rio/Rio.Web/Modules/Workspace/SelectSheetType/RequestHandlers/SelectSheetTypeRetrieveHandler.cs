using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.SelectSheetTypeRow>;
using MyRow = Rio.Workspace.SelectSheetTypeRow;

namespace Rio.Workspace
{
    public interface ISelectSheetTypeRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class SelectSheetTypeRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISelectSheetTypeRetrieveHandler
    {
        public SelectSheetTypeRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}