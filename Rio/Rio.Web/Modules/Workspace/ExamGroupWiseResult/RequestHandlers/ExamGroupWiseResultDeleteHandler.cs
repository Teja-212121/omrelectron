using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.ExamGroupWiseResultRow;

namespace Rio.Workspace
{
    public interface IExamGroupWiseResultDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamGroupWiseResultDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IExamGroupWiseResultDeleteHandler
    {
        public ExamGroupWiseResultDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}