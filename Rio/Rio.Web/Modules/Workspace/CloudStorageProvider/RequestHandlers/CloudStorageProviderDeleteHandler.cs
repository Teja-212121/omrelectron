using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.CloudStorageProviderRow;

namespace Rio.Workspace
{
    public interface ICloudStorageProviderDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class CloudStorageProviderDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICloudStorageProviderDeleteHandler
    {
        public CloudStorageProviderDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}