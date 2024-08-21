using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.CloudStorageSettingRow;

namespace Rio.Workspace
{
    public interface ICloudStorageSettingDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class CloudStorageSettingDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICloudStorageSettingDeleteHandler
    {
        public CloudStorageSettingDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}