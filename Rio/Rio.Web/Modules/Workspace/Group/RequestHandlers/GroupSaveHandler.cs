using Rio.Web;
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.GroupRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.GroupRow;

namespace Rio.Workspace
{
    public interface IGroupSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class GroupSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IGroupSaveHandler
    {
        public GroupSaveHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void SetInternalFields()
        {
            base.SetInternalFields();
            if (IsCreate)
            {
                if (Permissions.HasPermission("Administration:Security"))
                {
                    Row.TenantId = Row.SelectedTenant;
                }
                else
                {
                    Row.TenantId = User.GetTenantId();
                }
            }

            if (IsUpdate)
            {
                if (Permissions.HasPermission("Administration:Security"))
                {
                    Row.TenantId = Row.SelectedTenant;
                }
                else
                {
                    Row.TenantId = User.GetTenantId();
                }
            }
        }
    }
}