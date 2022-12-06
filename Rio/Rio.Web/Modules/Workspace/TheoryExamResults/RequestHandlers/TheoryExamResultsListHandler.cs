using Serenity.Data;
using Serenity.Services;
using Serenity.Abstractions;
using System;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.TheoryExamResultsRow>;
using MyRow = Rio.Workspace.TheoryExamResultsRow;
using Serenity;

namespace Rio.Workspace
{
    public interface ITheoryExamResultsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class TheoryExamResultsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITheoryExamResultsListHandler
    {
        private readonly IPermissionService permissions;
        public TheoryExamResultsListHandler(IRequestContext context, IPermissionService permissions)
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