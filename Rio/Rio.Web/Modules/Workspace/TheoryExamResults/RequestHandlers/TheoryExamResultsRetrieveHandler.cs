using Serenity;
using Serenity.Abstractions;
using Serenity.Data;
using Serenity.Services;
using System;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Rio.Workspace.TheoryExamResultsRow>;
using MyRow = Rio.Workspace.TheoryExamResultsRow;

namespace Rio.Workspace
{
    public interface ITheoryExamResultsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class TheoryExamResultsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITheoryExamResultsRetrieveHandler
    {
        private readonly IPermissionService permissions;
        public TheoryExamResultsRetrieveHandler(IRequestContext context, IPermissionService permissions)
             : base(context)
        {
            this.permissions = permissions ?? throw new ArgumentNullException(nameof(permissions));
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);
            if (!permissions.HasPermission("Administration:Security"))
            {
                if (permissions.HasPermission("Administration:Teachers"))
                {
                    var fld = MyRow.Fields;
                    var ExamTeachers = ExamTeachersRow.Fields.As("ExamTeachers");
                    query.InnerJoin(ExamTeachers, fld.TheoryExamId == ExamTeachers.TheoryExamId)
                        .Where(ExamTeachers.TeacherUserId == User.GetIdentifier());
                }
            }
        }
    }
}