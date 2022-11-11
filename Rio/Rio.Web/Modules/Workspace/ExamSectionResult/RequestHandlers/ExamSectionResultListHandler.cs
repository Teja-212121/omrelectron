using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.ExamSectionResultRow>;
using MyRow = Rio.Workspace.ExamSectionResultRow;

namespace Rio.Workspace
{
    public interface IExamSectionResultListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamSectionResultListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamSectionResultListHandler
    {
        public ExamSectionResultListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}