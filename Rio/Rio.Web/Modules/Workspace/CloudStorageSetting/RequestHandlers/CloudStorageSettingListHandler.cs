using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.CloudStorageSettingRow>;
using MyRow = Rio.Workspace.CloudStorageSettingRow;

namespace Rio.Workspace
{
    public interface ICloudStorageSettingListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CloudStorageSettingListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICloudStorageSettingListHandler
    {
        public CloudStorageSettingListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}