using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.CloudStorageSettingRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.CloudStorageSettingRow;

namespace Rio.Workspace
{
    public interface ICloudStorageSettingSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class CloudStorageSettingSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICloudStorageSettingSaveHandler
    {
        public CloudStorageSettingSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}