using Serenity.Services;
using System;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ScannedBatchRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ScannedBatchRow;

namespace Rio.Workspace
{
    public interface IScannedBatchSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ScannedBatchSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IScannedBatchSaveHandler
    {
        public ScannedBatchSaveHandler(IRequestContext context)
             : base(context)
        {
        }
        protected override void SetInternalFields()
        {
            base.SetInternalFields();
            if (IsCreate)
            {
                if (Row.Id == null)
                {
                    Row.Id = Guid.NewGuid();
                }
            }
        }
    }
}