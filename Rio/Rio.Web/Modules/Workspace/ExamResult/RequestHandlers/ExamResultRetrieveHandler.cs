using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.ExamResultRow>;
using MyRow = Rio.Workspace.ExamResultRow;

namespace Rio.Workspace
{
    public interface IExamResultRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamResultRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamResultRetrieveHandler
    {
        public ExamResultRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}