using Serenity.Data;
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.CouponCodeRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.CouponCodeRow;

namespace Rio.Workspace
{
    public interface ICouponCodeSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

    public class CouponCodeSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICouponCodeSaveHandler
    {
        public CouponCodeSaveHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void BeforeSave()
        {
            base.BeforeSave();
            if(IsCreate)
            {
                var code = Connection.TryFirst<CouponCodeRow>(CouponCodeRow.Fields.Code == Row.Code);

                if (code != null )
                {
                    throw new ValidationError("This Code already exists");
                }

            }
            //if(Row.ValidityInDays ==null && Row.ValidDate== null)
            //{

            //    throw new ValidationError(" ValidityInDays and Valid Date both cannot be null");
            //}

           
         
        }

    }
}