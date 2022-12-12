using Microsoft.AspNetCore.Builder;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Rio.Web;
using Serenity.Data;
using Serenity.Services;
using System;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ExamRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ExamRow;

namespace Rio.Workspace
{
    public interface IExamSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamSaveHandler
    {
        public ExamSaveHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void BeforeSave()
        {
            base.BeforeSave();
            if(!string.IsNullOrEmpty( Row.Code)&& !string.IsNullOrEmpty(Row.Name))
                Row.ExamDisplayName= Row.Name + " ("+ Row.Code + ")";
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

            if(IsUpdate)
            {
                var tenantid = Row.TenantId;
                if(Old.TenantId != tenantid)
                {
                    Row.TenantId = Row.SelectedTenant;
                }
                else
                {
                    Request.Entity.TenantId = tenantid;
                }
            }
        }        
    }
}