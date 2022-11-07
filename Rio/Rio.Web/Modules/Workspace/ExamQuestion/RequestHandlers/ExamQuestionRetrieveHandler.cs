using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.ExamQuestionRow>;
using MyRow = Rio.Workspace.ExamQuestionRow;

namespace Rio.Workspace
{
    public interface IExamQuestionRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamQuestionRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamQuestionRetrieveHandler
    {
        public ExamQuestionRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}