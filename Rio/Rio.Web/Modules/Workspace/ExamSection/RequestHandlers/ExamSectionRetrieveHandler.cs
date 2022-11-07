using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.ExamSectionRow>;
using MyRow = Rio.Workspace.ExamSectionRow;

namespace Rio.Workspace
{
    public interface IExamSectionRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamSectionRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamSectionRetrieveHandler
    {
        public ExamSectionRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}