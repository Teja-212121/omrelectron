using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rio.Administration;
using Rio.Web.Enums;
using Serenity;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
using System.Net;
using MyRow = Rio.Workspace.CouponCodeRow;

namespace Rio.Workspace.Endpoints
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("Api/Services/Workspace/CouponCode/[action]")]
    [ConnectionKey(typeof(MyRow)), IgnoreAntiforgeryToken]
    public class ApiCouponCodeController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] ICouponCodeSaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost]

        public SaveResponse ActivateCouponCode(IUnitOfWork uow, ActivaieCouponCode request)
        {
            if (string.IsNullOrEmpty(request.CouponCode))
                throw new ValidationError("Couponcode is missing");
            var couponcode = uow.Connection.TryFirst<MyRow>(MyRow.Fields.Code == request.CouponCode);
            if (couponcode == null)
                throw new ValidationError("Invalid Coupon code");
            if (couponcode.ConsumedCount == null)
                couponcode.ConsumedCount = 0;

            if(couponcode.CountType!= ECountType.Unlimited)
            if (couponcode.ConsumedCount >= couponcode.Count)
                throw new ValidationError("Coupon code limit exceeded");

            DateTime date = DateTime.Now.AddDays(1);
            if (couponcode.CouponValidityDate < date.Date)
                throw new ValidationError("Coupon code Expired");
            int? activationId = null;
            
           
            var ExamList = uow.Connection.TryFirst<ExamListRow>(ExamListRow.Fields.Id == couponcode.ExamListId.Value);

            var Teacher= uow.Connection.TryFirst<TeachersRow>(TeachersRow.Fields.UserId == User.GetIdentifier());

            var activationt = uow.Connection.TryFirst<ActivationRow>(ActivationRow.Fields.ExamListId == couponcode.ExamListId.Value && ActivationRow.Fields.TeacherId == Teacher.Id.Value );
            if (activationt != null)
                throw new ValidationError("User Already have activation");



            //if (couponcode.ValidityType != null)
            //{
            //    ValidityInDays = couponcode.ValidityInDays;
            //}

            ////if (Row.EDeviceLockingType == null)
            ////    Row.EDeviceLockingType = EDeviceLockingType.UnlimitedDevices;
            //if (couponcode.ValidityType == ValidityType.FixedDate)
            //{
            //    DateTime dor = couponcode.ValidTill.Value;
            //    DateTime doj = DateTime.Now;

            //    var totalmonths = (dor.Year - doj.Year) * 12 + dor.Month - doj.Month;
            //    totalmonths += dor.Day < doj.Day ? -1 : 0;

            //    // var years = totalmonths / 12;
            //    days = (couponcode.ValidTill.Value - DateTime.Now).TotalDays;
            //}
            //else
            //{
            //    days = ValidityInDays.Value;
            //}


            if (couponcode.ValidityType == EValidityType.Unlimited)
                couponcode.ValidDate = new DateTime(2099, 12, 31);
            KeyGenAsRow keygenrow = new KeyGenAsRow();
            
            keygenrow.ValidityType = couponcode.ValidityType;
            keygenrow.ValidityInDays = couponcode.ValidityInDays;
            keygenrow.ValidDate = couponcode.ValidDate;
            
            keygenrow.EStatus = KeyStatus.Activated;
            
            keygenrow.ExamListId = couponcode.ExamListId;
            
            keygenrow.Quantity = 1;
            keygenrow.IsActive = 1;
            keygenrow.Note = "generated for coupon code:"+ couponcode.Code;
            keygenrow.InsertDate = DateTime.Now;
            keygenrow.InsertUserId = 1;            
           

            int KeyGenId = (int)uow.Connection.InsertAndGetID<KeyGenAsRow>(keygenrow);

            var serialkeyrow = new SerialKeyRow();

            serialkeyrow.KeyGenAsId = KeyGenId;
            serialkeyrow.ExamListId = couponcode.ExamListId;
            serialkeyrow.ValidityType = couponcode.ValidityType;
            serialkeyrow.ValidityInDays = couponcode.ValidityInDays;
            serialkeyrow.ValidDate = couponcode.ValidDate;
            serialkeyrow.Note = "generated for coupon code:" + couponcode.Code;
            serialkeyrow.SerialKey = "To Be generated";
            serialkeyrow.EStatus = KeyStatus.Activated;
            serialkeyrow.InsertDate = DateTime.Now;
            serialkeyrow.InsertUserId = Convert.ToInt32(User.GetIdentifier());
            serialkeyrow.IsActive = 1;
            serialkeyrow.TenantId = ExamList.TenantId;
            //serialkeyrow.Te = 1;

            var Id = (int)uow.Connection.InsertAndGetID(serialkeyrow);
            var PredefinedSerialkeys = uow.Connection.TryFirst<PreDefinedKeyRow>(PreDefinedKeyRow.Fields.Id == Id);
            if (PredefinedSerialkeys == null)
                throw new ValidationError("Key not found");
            var key = new SerialKeyRow();
            key.Id = Id;
            key.SerialKey = PredefinedSerialkeys.SerialKey;
            uow.Connection.UpdateById<SerialKeyRow>(key);





            // var SerialKey = uow.Connection.TryFirst<SerialKeyRow>(SerialKeyRow.Fields.GenById == Id && SerialKeyRow.Fields.GenType == 2);

            ActivationLogRow activationLog = new ActivationLogRow();
            

            int userid = Convert.ToInt32(User.GetIdentifier());
            activationLog.TeacherId = Teacher.Id;
            DateTime? ExpiryDate;
            var userRow = uow.Connection.TryFirst<UserRow>(UserRow.Fields.UserId == userid);
            var activation = uow.Connection.TryFirst<ActivationRow>(ActivationRow.Fields.ExamListId == couponcode.ExamListId.Value && ActivationRow.Fields.TeacherId == Teacher.Id.Value);
            if (activation != null)
            {
                if (activation.ExpiryDate >= DateTime.Today)
                {
                    //resp.Note = "user already have activation for this product"; //to be confirmed
                    //resp.SerialkeyStatus = 2;
                }
                else
                {
                    int ValidityIndays;
                    DateTime UtcDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0, DateTimeKind.Utc);
                    if (couponcode.ValidityType == EValidityType.ValidityInDays)
                    {
                        ValidityIndays = couponcode.ValidityInDays.Value;
                        ExpiryDate = UtcDate.AddDays(ValidityIndays);
                    }
                    else if (serialkeyrow.ValidityType == EValidityType.FixedDate)
                    {
                        ExpiryDate = couponcode.ValidDate.Value;
                    }
                    else {
                        ExpiryDate = new DateTime(2099, 12, 31); ;

                    }
                    //activationLog.ValidFrom = UtcDate;

                    activationId = (int)uow.Connection.InsertAndGetID(new ActivationRow()
                    {
                        SerialKeyId = Id,
                        TeacherId = Teacher.Id,
                        ExamListId = couponcode.ExamListId,
                        EStatus = KeyStatus.Activated,
                        
                        InsertDate = DateTime.Now,

                        ExpiryDate = ExpiryDate,
                       
                        InsertUserId = userid,

                        TenantId = ExamList.TenantId,
                        IsActive = 1
                    });



                    //activationLog.Log = "Success";
                    activationLog.EStatus = KeyStatus.Activated;
                   // activationLog.ActivationId = activationId;
                    activationLog.SerialKeyId = Id;
                    activationLog.InsertDate = DateTime.Now;
                    activationLog.InsertUserId = userid;
                    activationLog.IsActive = 1;
                    activationLog.SerialKey = serialkeyrow.SerialKey;
                    activationLog.TeacherId = Teacher.Id;
                    activationLog.ExamListId = ExamList.Id;

                    int id = (int)uow.Connection.InsertAndGetID<ActivationLogRow>(activationLog);

                    //resp.SerialkeyStatus = 3;
                  
                    RetrieveRequest retrieverequest = new RetrieveRequest();
                    retrieverequest.ColumnSelection = RetrieveColumnSelection.Details;
                    retrieverequest.EntityId = activationId;

                  

                    


                   
                }
            }
            else
            {
                int ValidityIndays;
                DateTime UtcDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0, DateTimeKind.Utc);
                if (couponcode.ValidityType == EValidityType.ValidityInDays)
                {
                    ValidityIndays = couponcode.ValidityInDays.Value;
                    ExpiryDate = UtcDate.AddDays(ValidityIndays);
                }
                else if (serialkeyrow.ValidityType == EValidityType.FixedDate)
                {
                    ExpiryDate = couponcode.ValidDate.Value;
                }
                else
                {
                    ExpiryDate = null;

                }
                //activationLog.ValidFrom = UtcDate;

                activationId = (int)uow.Connection.InsertAndGetID(new ActivationRow()
                {
                    SerialKeyId = Id,
                    TeacherId = Teacher.Id,
                    ExamListId = couponcode.ExamListId,
                    EStatus = KeyStatus.Activated,

                    InsertDate = DateTime.Now,

                    ExpiryDate = ExpiryDate,

                    InsertUserId = userid,

                    TenantId = ExamList.TenantId,
                    IsActive = 1
                });



                //activationLog.Log = "Success";
                activationLog.EStatus = KeyStatus.Activated;
                //activationLog.ActivationId = activationId;
                activationLog.InsertDate = DateTime.Now;
                activationLog.InsertUserId = userid;
                activationLog.IsActive = 1;
                activationLog.SerialKeyId = Id;
                activationLog.SerialKey = serialkeyrow.SerialKey;
                activationLog.TeacherId = Teacher.Id;
                activationLog.ExamListId = ExamList.Id;

                int id = (int)uow.Connection.InsertAndGetID<ActivationLogRow>(activationLog);
                //resp.SerialkeyStatus = 3;

                RetrieveRequest retrieverequest = new RetrieveRequest();
                retrieverequest.ColumnSelection = RetrieveColumnSelection.Details;
                retrieverequest.EntityId = activationId;

               



              
            }
            var Coupon = new MyRow();
            Coupon.Id = couponcode.Id;
            if (couponcode.ConsumedCount == null)
                couponcode.ConsumedCount = 0;
            Coupon.ConsumedCount = (short)(couponcode.ConsumedCount.Value + 1);
            uow.Connection.UpdateById<MyRow>(Coupon);



            //uow.Commit();
            // var SerialKey = Connection.TryFirst<SerialKeyRow>(SerialKeyRow.Fields.GenById == Id.Value && SerialKeyRow.Fields.GenType == 2);
            //resp.EntityId = SerialKey.Id;
            //resp.SerialKey = SerialKey.Serial;
            var resp = new SaveResponse();
            resp.EntityId = activationId;
            return resp;
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] ICouponCodeSaveHandler handler)
        {
            return handler.Update(uow, request);
        }
 
        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] ICouponCodeDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] ICouponCodeRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow))]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] ICouponCodeListHandler handler)
        {
            return handler.List(connection, request);
        }

        [AuthorizeList(typeof(MyRow))]
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
            [FromServices] ICouponCodeListHandler handler,
            [FromServices] IExcelExporter exporter)
        {
            var data = List(connection, request, handler).Entities;
            var bytes = exporter.Export(data, typeof(Columns.CouponCodeColumns), request.ExportColumns);
            return ExcelContentResult.Create(bytes, "CouponCodeList_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
        }
    }

    public class ActivaieCouponCode
    {
        public string CouponCode { get; set; }
    }
}