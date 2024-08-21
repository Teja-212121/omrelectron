using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.CloudStorageSettingRow>;
using MyRow = Rio.Workspace.CloudStorageSettingRow;

namespace Rio.Workspace
{
    public interface ICloudStorageSettingRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class CloudStorageSettingRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICloudStorageSettingRetrieveHandler
    {
        public CloudStorageSettingRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}