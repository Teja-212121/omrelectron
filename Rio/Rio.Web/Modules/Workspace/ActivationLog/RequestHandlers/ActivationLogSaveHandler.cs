using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using Rio.Administration;
using Rio.Web;
using Rio.Web.Enums;
using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
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
                Row.Note = "Serial Key does not exist";
            }
            else
            {
                if (Connection.Exists<SerialKeyRow>(SerialKeyRow.Fields.EStatus == Convert.ToInt16(KeyStatus.Activated) && SerialKeyRow.Fields.SerialKey == Row.SerialKey))
                {
                    Row.Note = "This  SerialKey is already Activated!!!";
                }
                else if (!Connection.Exists<SerialKeyRow>(SerialKeyRow.Fields.SerialKey == Row.SerialKey && SerialKeyRow.Fields.EStatus == Convert.ToInt32(KeyStatus.Open) && SerialKeyRow.Fields.ExamListId == SerialKey.ExamListId.Value))
                {
                    Row.Note = "This Serial key and Examlist Mismatched";
                }
                else if (Connection.Exists<UserRow>(UserRow.Fields.UserId == Convert.ToInt32(User.GetIdentifier())))
                {
                    //throw new ValidationError("EmailInUse", Texts.Validation.CantFindUserWithEmail);
                    var user = Connection.TryFirst<UserRow>(UserRow.Fields.UserId == Convert.ToInt32(User.GetIdentifier()));
                    var teacher = Connection.TryFirst<TeachersRow>(TeachersRow.Fields.UserId == user.UserId.Value);

                    var serialkeyrow = Connection.TryFirst<SerialKeyRow>(SerialKeyRow.Fields.SerialKey == Row.SerialKey);
                    ExamListRow examList = Connection.Single<ExamListRow>(ExamListRow.Fields.Id == serialkeyrow.ExamListId.Value);

                    //CHECK FOR SERIALKEY
                    var activation = Connection.TryFirst<ActivationRow>(ActivationRow.Fields.SerialKeyId == serialkeyrow.Id.Value && ActivationRow.Fields.ExamListId == serialkeyrow.ExamListId.Value && ActivationRow.Fields.TeacherId == Convert.ToInt32(User.GetIdentifier()));
                    if (activation != null)
                    {
                        throw new ValidationError("ERROR: Teacher already have activated SerialKey " + serialkeyrow.SerialKey + " for " + examList.Name);
                    }
                    else
                    {
                        if (Connection.Exists<SerialKeyRow>(SerialKeyRow.Fields.EStatus == Convert.ToInt32(KeyStatus.Open) && SerialKeyRow.Fields.SerialKey == Row.SerialKey))
                        {
                            SerialKeyRow productSerial = Connection.Single<SerialKeyRow>(SerialKeyRow.Fields.SerialKey == Row.SerialKey);

                            // Check if productSerial is not null
                            if (productSerial != null)
                            {
                                var serialId = Convert.ToInt32(productSerial.Id);
                                var examlist = Connection.TryFirst<ExamListRow>(ExamListRow.Fields.Id == productSerial.ExamListId.Value);


                                // Check if the referenced SerialKeyRow exists before inserting into ActivationRow
                                if (Connection.Exists<SerialKeyRow>(SerialKeyRow.Fields.Id == serialId))
                                {
                                    int activationId = (int)Connection.InsertAndGetID(new ActivationRow()
                                    {
                                        SerialKeyId = serialId,
                                        TeacherId = teacher.Id,
                                        ExamListId = examlist.Id,
                                        EStatus = KeyStatus.Activated,
                                        InsertDate = DateTime.Now,
                                        InsertUserId = Convert.ToInt32(User.GetIdentifier()),
                                        IsActive = 1
                                    });
                                    ActvtnId = activationId;

                                    GroupRow group = new GroupRow();
                                    group.Name = examlist.Name + "_" + activationId;
                                    group.InsertDate = DateTime.Now;
                                    group.InsertUserId = Convert.ToInt32(User.GetIdentifier());
                                    group.IsActive = 1;
                                    group.TenantId = User.GetTenantId();
                                    Connection.Insert(group);

                                    productSerial.EStatus = KeyStatus.Activated;
                                    Connection.UpdateById(productSerial);
                                    Row.Code = productSerial.SerialKey;
                                    Row.ExamListId= examlist.Id;
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
                    }
                }
            }

            if (!Connection.Exists<SerialKeyRow>(SerialKeyRow.Fields.SerialKey == Row.SerialKey))
            {
                Row.Note = "ERROR:Serial does not exist ";
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



