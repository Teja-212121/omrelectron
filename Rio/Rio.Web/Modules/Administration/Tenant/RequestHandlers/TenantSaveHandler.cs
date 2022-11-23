using Serenity.Data;
using Serenity.Services;
using System;
using MyRequest = Serenity.Services.SaveRequest<Rio.Administration.TenantRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Administration.TenantRow;

namespace Rio.Administration
{
    public interface ITenantSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class TenantSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITenantSaveHandler
    {
        public TenantSaveHandler(IRequestContext context)
             : base(context)
        {
        }
        protected override void BeforeSave()
        {
            base.BeforeSave();
            if (Old.EApprovalStatus != Row.EApprovalStatus)
            {
                if (Row.EApprovalStatus == Web.Enums.EApprovalStatus.Approved)
                {
                    Row.IsActive = 1;
                    var user = Connection.TryFirst<UserRow>(UserRow.Fields.TenantId == Convert.ToInt32(Row.TenantId));
                    if (user != null)
                    {
                        user.IsActive = 1;
                        Connection.UpdateById<UserRow>(user);

                    }
                }
                else
                {
                    Row.IsActive = 0;
                    var user = Connection.TryFirst<UserRow>(UserRow.Fields.TenantId == Convert.ToInt32(Row.TenantId));
                    if (user != null)
                    {
                        user.IsActive = 0;
                        Connection.UpdateById<UserRow>(user);

                    }
                }
            }
        }
    }
}