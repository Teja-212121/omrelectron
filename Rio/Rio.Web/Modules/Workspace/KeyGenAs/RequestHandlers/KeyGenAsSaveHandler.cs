using Rio.Web.Enums;
using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.KeyGenAsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.KeyGenAsRow;

namespace Rio.Workspace
{
    public interface IKeyGenAsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class KeyGenAsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IKeyGenAsSaveHandler
    {
        public KeyGenAsSaveHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void AfterSave()
        {
            base.AfterSave();
            if (IsCreate)
            {
                int days = 0;
                for (int i=0;i<Row.Quantity;i++)
                {

                    var serialkeyrow = new SerialKeyRow();
                    
                    serialkeyrow.KeyGenAsId = Row.Id;
                    serialkeyrow.ExamListId = Row.ExamListId;
                    serialkeyrow.ValidityType = Row.ValidityType;
                    serialkeyrow.ValidityInDays = Row.ValidityInDays;
                    serialkeyrow.ValidDate = Row.ValidDate;
                    serialkeyrow.Note = Row.Note;
                    serialkeyrow.SerialKey = "To Be generated";
                    serialkeyrow.EStatus = KeyStatus.Open;
                    serialkeyrow.InsertDate = DateTime.Now;
                    serialkeyrow.InsertUserId =Convert.ToInt32( User.GetIdentifier());
                    serialkeyrow.IsActive = 1;

                    var Id = (int)Connection.InsertAndGetID(serialkeyrow);
                    var PredefinedSerialkeys = Connection.TryFirst<PreDefinedKeyRow>(PreDefinedKeyRow.Fields.Id == Id);
                    if (PredefinedSerialkeys == null)
                        throw new ValidationError("Key not found");
                    var key = new SerialKeyRow();
                    key.Id = Id;
                    key.SerialKey = PredefinedSerialkeys.SerialKey;
                    Connection.UpdateById<SerialKeyRow>(key);

                   

                }
            }
        }
    }
}