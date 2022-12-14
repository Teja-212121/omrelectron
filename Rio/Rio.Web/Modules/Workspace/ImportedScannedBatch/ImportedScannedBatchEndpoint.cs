using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Serenity;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using MyRow = Rio.Workspace.ImportedScannedBatchRow;
using MyScannedSheetRow = Rio.Workspace.ImportedScannedSheetRow;
using MyScannedQuestionRow = Rio.Workspace.ImportedScannedQuestionRow;

namespace Rio.Workspace.Endpoints
{
    [Route("Services/Workspace/ImportedScannedBatch/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class ImportedScannedBatchController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IImportedScannedBatchSaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IImportedScannedBatchSaveHandler handler)
        {
            return handler.Update(uow, request);
        }
 
        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] IImportedScannedBatchDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] IImportedScannedBatchRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow))]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] IImportedScannedBatchListHandler handler)
        {
            return handler.List(connection, request);
        }

        [AuthorizeList(typeof(MyRow))]
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
            [FromServices] IImportedScannedBatchListHandler handler,
            [FromServices] IExcelExporter exporter)
        {
            var data = List(connection, request, handler).Entities;
            var bytes = exporter.Export(data, typeof(Columns.ImportedScannedBatchColumns), request.ExportColumns);
            return ExcelContentResult.Create(bytes, "ImportedScannedBatchList_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
        }

        [HttpPost]
        public ExcelImportResponse InsertStudentSelectedDetail(IUnitOfWork uow, ExcelImportRequest request)
        {
            request.CheckNotNull();
            var response = new ExcelImportResponse();
            response.ErrorList = new List<string>();

            return response;
        }
        [HttpPost]
        public ExcelImportResponse ExcelImport(IUnitOfWork uow, ExcelImportRequest request,
            [FromServices] IUploadStorage uploadStorage,
            [FromServices] IImportedScannedBatchSaveHandler handler)
        {

            if (request is null)
                throw new ArgumentNullException(nameof(request));
            if (string.IsNullOrWhiteSpace(request.FileName))
                throw new ArgumentNullException(nameof(request.FileName));

            if (uploadStorage is null)
                throw new ArgumentNullException(nameof(uploadStorage));

            UploadPathHelper.CheckFileNameSecurity(request.FileName);

            if (!request.FileName.StartsWith("temporary/", StringComparison.OrdinalIgnoreCase))
                throw new ArgumentOutOfRangeException(nameof(request.FileName));

            ExcelPackage ep = new();
            using (var fs = uploadStorage.OpenFile(request.FileName))
                ep.Load(fs);

            var p = MyRow.Fields;
            //var p = ProductsRow.Fields;

            var response = new ExcelImportResponse
            {
                ErrorList = new List<string>()
            };

            var worksheet = ep.Workbook.Worksheets[0];
            var scanbatchid = new Guid();
            var scansheetid = new Guid();

            for (var row = 2; row <= worksheet.Dimension.End.Row; row++)
            {
                try
                {
                   
                    MyRow Row = new MyRow();
                    MyScannedSheetRow sheetRow = new MyScannedSheetRow();
                    MyScannedQuestionRow questionRow = new MyScannedQuestionRow();
                    
                    string guidString = Convert.ToString(worksheet.Cells[row, 1].Value);
                    if (string.IsNullOrEmpty(guidString))
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Scanned Batch Id Not found");
                        continue;
                    }
                    if (scanbatchid != new Guid(guidString))
                    {
                        Row.Id = new Guid(guidString);
                        scanbatchid = new Guid(guidString);
                        Row.Name = Convert.ToString(worksheet.Cells[row, 2].Value ?? "").Trim();
                        Row.TenantId = Convert.ToInt32(worksheet.Cells[row, 19].Value ?? null);
                        Row.InsertDate = DateTime.UtcNow;
                        Row.InsertUserId = Convert.ToInt32(User.GetIdentifier());
                        uow.Connection.Insert<MyRow>(Row);
                    }
                    
                    string guidSheetString = Convert.ToString(worksheet.Cells[row, 4].Value);
                    if (string.IsNullOrEmpty(guidSheetString))
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Scanned Batch Id Not found");
                        continue;
                    }
                    if (scansheetid != new Guid(guidSheetString))
                    {
                        sheetRow.Id = new Guid(guidSheetString);
                        scansheetid = new Guid(guidSheetString);
                        sheetRow.SheetNumber = Convert.ToString(worksheet.Cells[row, 5].Value ?? "").Trim();
                        sheetRow.ScannedRollNo = Convert.ToString(worksheet.Cells[row, 6].Value ?? null);
                        sheetRow.CorrectedRollNo = Convert.ToString(worksheet.Cells[row, 7].Value ?? null);
                        sheetRow.ScannedExamNo = Convert.ToString(worksheet.Cells[row, 8].Value ?? null);
                        sheetRow.CorrectedExamNo = Convert.ToString(worksheet.Cells[row, 9].Value ?? null);
                        sheetRow.ExamSetNo = Convert.ToString(worksheet.Cells[row, 10].Value ?? null);
                        sheetRow.ScannedImageSourcePath = Convert.ToString(worksheet.Cells[row, 11].Value ?? "").Trim();
                        Int16? ScannedStatus = Convert.ToInt16(worksheet.Cells[row, 12].Value ?? null);
                        if (ScannedStatus != null)
                        {
                            if (ScannedStatus == 0)
                                sheetRow.ScannedStatus = enums.EScannedStatus.OpenSheet;
                            else if (ScannedStatus == 1)
                                sheetRow.ScannedStatus = enums.EScannedStatus.FailedSheet;
                            else if (ScannedStatus == 2)
                                sheetRow.ScannedStatus = enums.EScannedStatus.WarningSheet;
                            else if (ScannedStatus == 3)
                                sheetRow.ScannedStatus = enums.EScannedStatus.SuccessSheet;
                            else
                            {
                                response.ErrorList.Add("Error On Row " + row + ": Invalid Scanned Status");
                                continue;
                            }
                        }
                        sheetRow.SheetTypeId = Convert.ToInt32(worksheet.Cells[row, 13].Value ?? null);
                        sheetRow.ScannedAt = DateTime.UtcNow;
                        sheetRow.ResultProcessed = Convert.ToBoolean(worksheet.Cells[row, 15].Value ?? null);
                        sheetRow.OCRData1Key = Convert.ToString(worksheet.Cells[row, 16].Value ?? "").Trim();
                        sheetRow.OCRData1Value = Convert.ToString(worksheet.Cells[row, 17].Value ?? "").Trim();
                        sheetRow.OCRData2Key = Convert.ToString(worksheet.Cells[row, 18].Value ?? "").Trim();
                        sheetRow.OCRData2Value = Convert.ToString(worksheet.Cells[row, 19].Value ?? "").Trim();
                        sheetRow.OCRData3Key = Convert.ToString(worksheet.Cells[row, 20].Value ?? "").Trim();
                        sheetRow.OCRData3Value = Convert.ToString(worksheet.Cells[row, 21].Value ?? "").Trim();
                        sheetRow.ICRData1Key = Convert.ToString(worksheet.Cells[row, 22].Value ?? "").Trim();
                        sheetRow.ICRData1Value = Convert.ToString(worksheet.Cells[row, 23].Value ?? "").Trim();
                        sheetRow.ICRData2Key = Convert.ToString(worksheet.Cells[row, 24].Value ?? "").Trim();
                        sheetRow.ICRData2Value = Convert.ToString(worksheet.Cells[row, 25].Value ?? "").Trim();
                        sheetRow.ICRData3Key = Convert.ToString(worksheet.Cells[row, 26].Value ?? "").Trim();
                        sheetRow.ICRData3Value = Convert.ToString(worksheet.Cells[row, 27].Value ?? "").Trim();
                        sheetRow.ScannedBatchId = new Guid(guidString);
                        sheetRow.TenantId = Convert.ToInt32(worksheet.Cells[row, 19].Value ?? null);
                        sheetRow.InsertDate = DateTime.UtcNow;
                        sheetRow.InsertUserId = Convert.ToInt32(User.GetIdentifier());

                        uow.Connection.Insert<MyScannedSheetRow>(sheetRow);
                    }
                    
                    questionRow.QuestionIndex = Convert.ToInt32(worksheet.Cells[row, 16].Value ?? null);
                    questionRow.ScannedSheetId = new Guid(guidSheetString);
                    questionRow.ScannedOptions = Convert.ToString(worksheet.Cells[row, 17].Value ?? null);
                    questionRow.CorrectedOptions = Convert.ToString(worksheet.Cells[row, 18].Value ?? null);
                    questionRow.TenantId = Convert.ToInt32(worksheet.Cells[row, 19].Value ?? null);
                    questionRow.InsertDate = DateTime.UtcNow;
                    questionRow.InsertUserId = Convert.ToInt32(User.GetIdentifier());

                    uow.Connection.Insert<MyScannedQuestionRow>(questionRow);
                    response.Inserted = response.Inserted + 1;
                }
                catch (Exception)
                {
                    //response.ErrorList.Add("Exception on Row " + row + ": " + ex.Message);
                    throw;
                }
            }
            return response;
        }
    }
}