using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.SelectSheetTypeRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.SelectSheetTypeRow;

namespace Rio.Workspace
{
    public interface ISelectSheetTypeSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class SelectSheetTypeSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISelectSheetTypeSaveHandler
    {
        public SelectSheetTypeSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}