using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.ExamListRow>;
using MyRow = Rio.Workspace.ExamListRow;

namespace Rio.Workspace
{
    public interface IExamListRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamListRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamListRetrieveHandler
    {
        public ExamListRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}