using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.TeachersRow;

namespace Rio.Workspace
{
    public interface ITeachersDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class TeachersDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITeachersDeleteHandler
    {
        public TeachersDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}