using Rio.Web;
using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.GroupStudentRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.GroupStudentRow;

namespace Rio.Workspace
{
    public interface IGroupStudentSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

    public class GroupStudentSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IGroupStudentSaveHandler
    {
        public GroupStudentSaveHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void SetInternalFields()
        {
            base.SetInternalFields();
            if (Row.RowIds != null && Row.StudentId == null)
            {
                Row.StudentId = 0;
            }
        }

        protected override void BeforeSave()
        {
            base.BeforeSave();

            if (Row.RowIds != null)
            {
                string[] rowIds = Row.RowIds.Split(',');
                string SId = "";
                if (rowIds.Length > 0)
                {
                    foreach (var id in rowIds)
                    {
                        Row.StudentId = Convert.ToInt32(id);

                        if (!(Connection.Exists<MyRow>
                                  (MyRow.Fields.StudentId == Convert.ToInt32(id) &&
                                      MyRow.Fields.GroupId == Convert.ToInt32(Request.Entity.GroupId))))
                        {
                            Connection.Insert<MyRow>(new MyRow
                            {
                                StudentId = Row.StudentId,
                                GroupId = Request.Entity.GroupId,
                                TenantId = User.GetTenantId(),
                                InsertDate = DateTime.UtcNow,
                                InsertUserId = Convert.ToInt32(User.GetIdentifier())
                            });
                        }
                        else
                        {
                            SId = SId + id + ",";
                        }
                    }
                    if (SId != string.Empty)
                        throw new ValidationError("Students with Ids " + SId + " are already mapped to Group,Other students are successfully mapped to group");
                }
            }

            
        }

        protected override void ExecuteSave()
        {
            
        }
    }
}