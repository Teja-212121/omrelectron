using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Rio.Workspace.TheoryExamQuestionsRow;

namespace Rio.Workspace
{
    public interface ITheoryExamQuestionsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class TheoryExamQuestionsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITheoryExamQuestionsDeleteHandler
    {
        public TheoryExamQuestionsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}