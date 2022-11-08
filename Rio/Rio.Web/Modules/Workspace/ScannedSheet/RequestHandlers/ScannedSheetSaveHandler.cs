using Serenity.Services;
using System;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ScannedSheetRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ScannedSheetRow;

namespace Rio.Workspace
{
    public interface IScannedSheetSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ScannedSheetSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IScannedSheetSaveHandler
    {
        public ScannedSheetSaveHandler(IRequestContext context)
             : base(context)
        {
        }
        protected override void SetInternalFields()
        {
            base.SetInternalFields();
            if (IsCreate)
            {
                if (Row.Id == null)
                    Row.Id = Guid.NewGuid();
            }
        }
    }
}