using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.CloudStorageProviderRow>;
using MyRow = Rio.Workspace.CloudStorageProviderRow;

namespace Rio.Workspace
{
    public interface ICloudStorageProviderListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CloudStorageProviderListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICloudStorageProviderListHandler
    {
        public CloudStorageProviderListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}