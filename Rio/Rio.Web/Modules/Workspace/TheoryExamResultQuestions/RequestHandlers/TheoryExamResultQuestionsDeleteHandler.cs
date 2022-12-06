using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.TheoryExamResultQuestionsRow;

namespace Rio.Workspace
{
    public interface ITheoryExamResultQuestionsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class TheoryExamResultQuestionsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITheoryExamResultQuestionsDeleteHandler
    {
        public TheoryExamResultQuestionsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}