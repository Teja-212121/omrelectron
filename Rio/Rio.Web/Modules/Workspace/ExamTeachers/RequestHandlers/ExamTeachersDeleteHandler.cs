using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.ExamTeachersRow;

namespace Rio.Workspace
{
    public interface IExamTeachersDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamTeachersDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IExamTeachersDeleteHandler
    {
        public ExamTeachersDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}