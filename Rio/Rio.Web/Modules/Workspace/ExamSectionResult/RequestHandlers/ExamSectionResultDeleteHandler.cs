using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.ExamSectionResultRow;

namespace Rio.Workspace
{
    public interface IExamSectionResultDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamSectionResultDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IExamSectionResultDeleteHandler
    {
        public ExamSectionResultDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}