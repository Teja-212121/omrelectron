using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.CloudStorageProviderRow>;
using MyRow = Rio.Workspace.CloudStorageProviderRow;

namespace Rio.Workspace
{
    public interface ICloudStorageProviderRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class CloudStorageProviderRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICloudStorageProviderRetrieveHandler
    {
        public CloudStorageProviderRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}