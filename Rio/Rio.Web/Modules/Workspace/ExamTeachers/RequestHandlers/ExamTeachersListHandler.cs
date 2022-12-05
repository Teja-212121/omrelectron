using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.ExamTeachersRow>;
using MyRow = Rio.Workspace.ExamTeachersRow;

namespace Rio.Workspace
{
    public interface IExamTeachersListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamTeachersListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamTeachersListHandler
    {
        public ExamTeachersListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}