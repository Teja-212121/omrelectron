using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.ExamListExamsRow>;
using MyRow = Rio.Workspace.ExamListExamsRow;

namespace Rio.Workspace
{
    public interface IExamListExamsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamListExamsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamListExamsRetrieveHandler
    {
        public ExamListExamsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}