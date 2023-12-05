using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using Rio.Administration;
using Rio.Web.Enums;
using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Collections.Generic;
using System.Net;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ActivationLogRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ActivationLogRow;

namespace Rio.Workspace
{
    public interface IActivationLogSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

    public class ActivationLogSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IActivationLogSaveHandler
    {
        public ActivationLogSaveHandler(IRequestContext context)
             : base(context)
        {
        }
        Int32 ActvtnId;
        protected override void BeforeSave()
        {
            base.BeforeSave();


            var SerialKey = Connection.TryFirst<SerialKeyRow>(SerialKeyRow.Fields.SerialKey == Row.SerialKey);
            if (SerialKey == null)
            {
                Row.Note = "ERROR:Invalid Serial Key";

            }
            else
            {
                if (Connection.Exists<SerialKeyRow>(SerialKeyRow.Fields.EStatus == Convert.ToInt16(KeyStatus.Activated) && SerialKeyRow.Fields.SerialKey == Row.SerialKey))
                {
                    Row.Note = "ERROR: SerialKey is already Activated!!!";


                }

                if (!Connection.Exists<SerialKeyRow>(SerialKeyRow.Fields.SerialKey == Row.SerialKey && SerialKeyRow.Fields.EStatus == Convert.ToInt32(KeyStatus.Open) && SerialKeyRow.Fields.ExamListId == Convert.ToInt32(Row.ExamListId)))
                {
                    if (Row.EStatus != 0)
                    {
                        Row.Note = "ERROR:Serial key and Examlist Mismatched" ;
                     
                    }
                }
                if (Row.EStatus != 0)
                {

                    //Check UserId and DeviceId Relationship (Both Must Exist)
                    //Get Product and Match SerialKey with Correct Product
                    //Get User and Assign SerialKey
                    if (Connection.Exists<UserRow>(
                               UserRow.Fields.UserId == Convert.ToInt32(Row.TeacherId)))
                    {
                        //throw new ValidationError("EmailInUse", Texts.Validation.CantFindUserWithEmail);
                        UserRow userRow = Connection.Single<UserRow>(UserRow.Fields.UserId == Convert.ToInt32(Row.TeacherId));

                        var teacherid = Convert.ToInt32(User.GetIdentifier());
                        //Row.DeviceId = userRow.DeviceId;
                        //Row.DeviceType = userRow.DeviceType;
                        var serialkeyrow = Connection.TryFirst<SerialKeyRow>(SerialKeyRow.Fields.SerialKey == Row.SerialKey);
                        ExamListRow productsT = Connection.Single<ExamListRow>(ExamListRow.Fields.Id == serialkeyrow.ExamListId.Value);

                        //CHECK FOR SERIALKEY
                        var activation = Connection.TryFirst<ActivationRow>(ActivationRow.Fields.ExamListId == serialkeyrow.ExamListId.Value && ActivationRow.Fields.TeacherId == User.GetIdentifier());
                        if (activation != null)
                        {
                            var actvnlog = Connection.TryFirst<MyRow>(MyRow.Fields.ActivationId == activation.Id.Value);
                            if (actvnlog != null)
                            {
                                throw new ValidationError("ERROR: User already have subscription in " + productsT.Name);

                            }

                        }
                    }

                    //                    //CHECK FOR SERIALKEY
                    //                    if (Connection.Exists<SerialKeyRow>(SerialKeyRow.Fields.EStatus == Convert.ToInt32(KeyStatus.Open) && SerialKeyRow.Fields.SerialKey == Row.SerialKey) && Row.EStatus != 0)
                    //                    {
                    //                        SerialKeyRow productSerial = Connection.Single<SerialKeyRow>(SerialKeyRow.Fields.SerialKey == Row.SerialKey);
                    //                       var serialId = Convert.ToInt32(productSerial.Id);
                    //                        var examlistId = Convert.ToInt32(productSerial.ExamListId);
                    //                        var teacherid = Convert.ToInt32(User.GetIdentifier());
                    //                          DateTime UtcDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0, DateTimeKind.Utc);
                    //                        if (productSerial.ValidityType == EValidityType.ValidityInDays)
                    //                        {
                    //                            var ValidityIndays = (int)productSerial.ValidityInDays;
                    //                            //Row.ValidTo = UtcDate.AddDays(ValidityIndays);
                    //                        }
                    //                        if (productSerial.ValidityType == EValidityType.FixedDate)
                    //                        {
                    //                            Row.ValidTo = productSerial.ValidTill;
                    //                        }
                    //                        Row.ValidFrom = UtcDate;
                    //                        // Row.AllowedDevices = productSerial.AllowedDevices;
                    //                        ExamListRow product = Connection.Single<ExamListRow>(ExamListRow.Fields.Id == examlistId);
                    //                        publisherId = Convert.ToInt32(product.UserId);
                    //;
                    //                        int activationId = (int)Connection.InsertAndGetID(new ActivationRow()
                    //                        {
                    //                            SerialKeyId = serialId,
                    //                            UserId = subscriberId,
                    //                            ProductId = productId,
                    //                            EKeyStatus = 1,
                    //                            PublisherId = publisherId,
                    //                            InsertDate = DateTime.Now,
                    //                            DeviceKey = Row.DeviceKey,
                    //                            ValidFrom = Row.ValidFrom,
                    //                            ValidTo = Row.ValidTo,

                    //                            InsertUserId = loginUser,

                    //                            IsActive = 1
                    //                        });
                    //                        ActvtnId = activationId;

                    //                        Row.Note = "Success";
                    //                        Row.EStatus = KeyStatus.Activated;
                    //                        Row.ActivationId = activationId;
                    //                        Row.SerialKeyId = serialId;


                    //                    }
                    //                    else
                    //                    {
                    //                        if (String.IsNullOrEmpty(Row.Note))
                    //                            Row.Note = "ERROR: SerialKey not available for activation!";
                    //                        //Row.EStatus = 0;
                    //                    }
                    //                    if (!Connection.Exists<SerialKeyRow>(SerialKeyRow.Fields.SerialKey == Row.SerialKey))
                    //                    {
                    //                        Row.Note = "ERROR:Invalid Serial key";
                    //                       // Row.EStatus = 0;

                    //                    }
                    //                    //if (Row.Status == 0)
                    //                    //    Row.AllowedDevices = "1";
                }
            }

                //CHECK FOR SERIALKEY
                if (Connection.Exists<SerialKeyRow>(SerialKeyRow.Fields.EStatus == Convert.ToInt32(KeyStatus.Open) && SerialKeyRow.Fields.SerialKey == Row.SerialKey) && Row.EStatus != 0)
            {
                var teacher = Connection.TryFirst<TeachersRow>(TeachersRow.Fields.UserId == Convert.ToInt32(User.GetIdentifier()));
                SerialKeyRow productSerial = Connection.Single<SerialKeyRow>(SerialKeyRow.Fields.SerialKey == Row.SerialKey);

                // Check if productSerial is not null
                if (productSerial != null)
                {
                    var serialId = Convert.ToInt32(productSerial.Id);
                    var examlistId = Convert.ToInt32(productSerial.ExamListId);

                    // Check if the referenced SerialKeyRow exists before inserting into ActivationRow
                    if (Connection.Exists<SerialKeyRow>(SerialKeyRow.Fields.Id == serialId))
                    {
                        int activationId = (int)Connection.InsertAndGetID(new ActivationRow()
                        {
                            SerialKeyId = serialId,
                            TeacherId = Row.TeacherId,
                            ExamListId = examlistId,
                            EStatus = KeyStatus.Activated,
                            InsertDate = DateTime.Now,
                            InsertUserId = Convert.ToInt32(User.GetIdentifier()),
                            IsActive = 1
                        });
                        ActvtnId = activationId;
                        productSerial.EStatus = KeyStatus.Activated;
                        Connection.UpdateById(productSerial);

                       // Response.EntityId = ActvtnId;

                        Row.Note = "Serial Key: " + Row.SerialKey + " is Successfully Activated!!";
                        // ...
                    }
                    else
                    {
                        // Handle the case where the referenced SerialKeyRow does not exist
                        Row.Note = "ERROR: Referenced SerialKeyRow does not exist";
                       
                    }
                }
                else
                {
                    // Handle the case where productSerial is null
                    Row.Note = "ERROR: SerialKey not found";
                  
                }
            }
            else
            {
                if (String.IsNullOrEmpty(Row.Note))
                    Row.Note = "ERROR: SerialKey not available for activation!";
               
            }
            if (!Connection.Exists<SerialKeyRow>(SerialKeyRow.Fields.SerialKey == Row.SerialKey))
            {
                Row.Note = "ERROR:Invalid Serial key";
                

            }
        }
        protected override void AfterSave()
        {
            base.AfterSave();
            if (IsCreate)
            {
               
                var serialkey = Connection.TryFirst<SerialKeyRow>(SerialKeyRow.Fields.SerialKey == Row.SerialKey);
               
                   
                    var actvation = Connection.TryFirst<ActivationRow>(ActivationRow.Fields.Id == ActvtnId);
                    if (actvation != null)
                    {
                        
                      Connection.UpdateById<ActivationRow>(actvation);
                    Response.EntityId = ActvtnId;
                }
            }
            
        }

    }
}



