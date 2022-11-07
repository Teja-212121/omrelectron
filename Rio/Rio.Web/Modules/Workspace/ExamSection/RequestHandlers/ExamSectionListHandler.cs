using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.ExamSectionRow>;
using MyRow = Rio.Workspace.ExamSectionRow;

namespace Rio.Workspace
{
    public interface IExamSectionListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamSectionListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamSectionListHandler
    {
        public ExamSectionListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}