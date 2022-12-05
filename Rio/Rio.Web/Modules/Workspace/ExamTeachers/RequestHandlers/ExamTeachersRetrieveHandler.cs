using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.ExamTeachersRow>;
using MyRow = Rio.Workspace.ExamTeachersRow;

namespace Rio.Workspace
{
    public interface IExamTeachersRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamTeachersRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamTeachersRetrieveHandler
    {
        public ExamTeachersRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}