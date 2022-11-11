using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.ExamGroupWiseResultRow>;
using MyRow = Rio.Workspace.ExamGroupWiseResultRow;

namespace Rio.Workspace
{
    public interface IExamGroupWiseResultRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamGroupWiseResultRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamGroupWiseResultRetrieveHandler
    {
        public ExamGroupWiseResultRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}