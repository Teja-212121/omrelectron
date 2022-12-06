using Serenity;
using Serenity.Abstractions;
using Serenity.Data;
using Serenity.Services;
using System;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.TheoryExamsRow>;
using MyRow = Rio.Workspace.TheoryExamsRow;

namespace Rio.Workspace
{
    public interface ITheoryExamsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class TheoryExamsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITheoryExamsListHandler
    {
        private readonly IPermissionService permissions;
        public TheoryExamsListHandler(IRequestContext context, IPermissionService permissions)
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
                    query.InnerJoin(ExamTeachers, fld.Id == ExamTeachers.TheoryExamId)
                        .Where(ExamTeachers.TeacherUserId == User.GetIdentifier());
                }
            }

        }
    }
}