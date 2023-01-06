using Serenity.Services;
using System;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ImportedScannedSheetRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ImportedScannedSheetRow;

namespace Rio.Workspace
{
    public interface IImportedScannedSheetSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ImportedScannedSheetSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IImportedScannedSheetSaveHandler
    {
        public ImportedScannedSheetSaveHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void BeforeSave()
        {
            base.BeforeSave();
            var scannedRollNo = Row.CorrectedRollNo.ToString();
            var scannedExamNo = Row.CorrectedExamNo.ToString();
            if (!string.IsNullOrEmpty(scannedExamNo) && !string.IsNullOrEmpty(scannedRollNo))
                Row.ImportScannedSheetDisplayName = Row.CorrectedRollNo + " (" + Row.CorrectedExamNo + ")";

            if (IsUpdate)
            {
                if (Old.CorrectedExamNo != Row.CorrectedExamNo || Old.CorrectedRollNo != Row.CorrectedRollNo)
                    Row.IsRectified = true;
            }
        }

        protected override void SetInternalFields()
        {
            base.SetInternalFields();
            if (IsCreate)
            {
                if (Row.Id == null)
                    Row.Id = Guid.NewGuid();
            }
        }
    }
}