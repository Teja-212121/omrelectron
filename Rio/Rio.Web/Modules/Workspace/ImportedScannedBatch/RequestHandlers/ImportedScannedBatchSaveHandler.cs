using Serenity.Services;
using System;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ImportedScannedBatchRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ImportedScannedBatchRow;

namespace Rio.Workspace
{
    public interface IImportedScannedBatchSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ImportedScannedBatchSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IImportedScannedBatchSaveHandler
    {
        public ImportedScannedBatchSaveHandler(IRequestContext context)
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