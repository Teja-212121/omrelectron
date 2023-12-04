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
                        Row.Note = "ERROR:Serial key is already activated  for that examlist " ;
                     
                    }
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

                        Response.EntityId = ActvtnId;

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



