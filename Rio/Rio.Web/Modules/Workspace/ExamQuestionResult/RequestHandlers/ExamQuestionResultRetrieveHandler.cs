using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.ExamQuestionResultRow>;
using MyRow = Rio.Workspace.ExamQuestionResultRow;

namespace Rio.Workspace
{
    public interface IExamQuestionResultRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamQuestionResultRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamQuestionResultRetrieveHandler
    {
        public ExamQuestionResultRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}