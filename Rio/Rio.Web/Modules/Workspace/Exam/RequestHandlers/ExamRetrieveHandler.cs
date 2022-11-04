using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.ExamRow>;
using MyRow = Rio.Workspace.ExamRow;

namespace Rio.Workspace
{
    public interface IExamRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamRetrieveHandler
    {
        public ExamRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}