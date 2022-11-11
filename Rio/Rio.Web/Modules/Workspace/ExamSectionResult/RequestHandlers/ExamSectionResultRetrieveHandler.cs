using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.ExamSectionResultRow>;
using MyRow = Rio.Workspace.ExamSectionResultRow;

namespace Rio.Workspace
{
    public interface IExamSectionResultRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamSectionResultRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamSectionResultRetrieveHandler
    {
        public ExamSectionResultRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}