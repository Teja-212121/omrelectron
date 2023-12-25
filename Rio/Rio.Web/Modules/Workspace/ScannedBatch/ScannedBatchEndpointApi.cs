using Microsoft.AspNetCore.Mvc;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
using MyRow = Rio.Workspace.ScannedBatchRow;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Serenity;
using Newtonsoft.Json;

namespace Rio.Workspace.Endpoints
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("Api/Services/Workspace/ScannedBatch/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow)),IgnoreAntiforgeryToken]
    public class ScannedBatchApiController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IScannedBatchSaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IScannedBatchSaveHandler handler)
        {
            return handler.Update(uow, request);
        }

        [HttpPost]
        public SaveResponse InsertScannedBatchData(IUnitOfWork uow, SaveRequest<MyRow> request, [FromServices] IScannedBatchSaveHandler handler, [FromServices] IScannedSheetSaveHandler ScannedSheethandler)
        {
            
            var resp =new SaveResponse();

            foreach (ScannedSheetRow ScannedSheet in request.Entity.ScannedSheets)
            {
                List<ScannedQuestionRow> questions = new List<ScannedQuestionRow>();
                questions = ScannedSheet.ScannedQuestions;
                var scansheet = new ScannedSheetRow() {
                    Id = ScannedSheet.Id,
                    SheetTypeId = ScannedSheet.SheetTypeId,
                    ScannedAt = ScannedSheet.ScannedAt,
                    ScannedSheetDisplayName = ScannedSheet.ScannedSheetDisplayName,
                    ScannedRollNo = ScannedSheet.ScannedRollNo,
                    ScannedExamNo = ScannedSheet.ScannedExamNo,
                    CorrectedRollNo = ScannedSheet.CorrectedRollNo,
                    CorrectedExamNo = ScannedSheet.CorrectedExamNo,
                    ExamSetNo = ScannedSheet.ExamSetNo,
                    ScannedImageSourcePath = ScannedSheet.ScannedImageSourcePath,
                    ScannedImage = ScannedSheet.ScannedImage,
                    ScannedBatchId = ScannedSheet.ScannedBatchId,
                    ScannedStatus = ScannedSheet.ScannedStatus,
                    ScannedSystemErrors = ScannedSheet.ScannedSystemErrors,
                    ScannedUserErrors = ScannedSheet.ScannedUserErrors,
                    ResultProcessed = ScannedSheet.ResultProcessed,
                    ImageBase64 = ScannedSheet.ImageBase64,
                    IsRectified = ScannedSheet.IsRectified,
                    IsActive = ScannedSheet.IsActive,
                    TenantId = ScannedSheet.TenantId,
                    InsertDate=DateTime.Now,
                    InsertUserId=Convert.ToInt32(User.GetIdentifier()),

                    OCRData1Key = ScannedSheet.OCRData1Key,
                    OCRData1Value = ScannedSheet.OCRData1Value,
                    OCRData2Key = ScannedSheet.OCRData2Key,
                    //OCRData2Value = ScannedSheet.OCRData2Value,
                    //OCRData3Key = ScannedSheet.OCRData3Key,
                    //OCRData3Value = ScannedSheet.OCRData3Value,
                    ICRData1Key = ScannedSheet.ICRData1Key,
                    ICRData1Value = ScannedSheet.ICRData1Value,
                    ICRData2Key = ScannedSheet.ICRData2Key,
                    ICRData2Value = ScannedSheet.ICRData2Value,
                    //ICRData3Key = ScannedSheet.ICRData3Key,
                    //ICRData3Value = ScannedSheet.ICRData3Value
                };
                //ScanSheetRow scanSheet = ScannedSheet;

                uow.Connection.Insert<ScannedSheetRow>(scansheet);
                //ScannedSheet.ScannedQuestions = questions;
                //ScannedSheethandler.Create(uow, request1);
                if (questions != null)
                {
                    foreach (ScannedQuestionRow ScannedQuestion in questions)
                    {
                        ScannedQuestion.InsertDate = DateTime.Now;
                        ScannedQuestion.InsertUserId = Convert.ToInt32(User.GetIdentifier());
                        uow.Connection.Insert<ScannedQuestionRow>(ScannedQuestion);
                    }

                }

            }
           
            return resp;
        }

        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] IScannedBatchDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] IScannedBatchRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow))]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] IScannedBatchListHandler handler)
        {
            return handler.List(connection, request);
        }

        [AuthorizeList(typeof(MyRow))]
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
            [FromServices] IScannedBatchListHandler handler,
            [FromServices] IExcelExporter exporter)
        {
            var data = List(connection, request, handler).Entities;
            var bytes = exporter.Export(data, typeof(Columns.ScannedBatchColumns), request.ExportColumns);
            return ExcelContentResult.Create(bytes, "ScannedBatchList_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
        }


    }
    public class ScanSheetRow
    {
        public GuidField Id{ get; set; }
        public Int32Field SheetTypeId{get; set;}
        public DateTimeField ScannedAt{get; set;}
        public StringField ScannedSheetDisplayName{get; set;}
        public StringField SheetNumber{get; set;}
        public StringField ScannedRollNo{get; set;}
        public StringField ScannedExamNo{get; set;}
        public StringField CorrectedRollNo{get; set;}
        public StringField CorrectedExamNo{get; set;}
        public StringField ExamSetNo{get; set;}
        public StringField ScannedImageSourcePath{get; set;}
        public StringField ScannedImage{get; set;}
        public GuidField ScannedBatchId{get; set;}
        public Int16Field ScannedStatus{get; set;}
        public StringField ScannedSystemErrors{get; set;}
        public StringField ScannedUserErrors{get; set;}
        public StringField ScannedComments{get; set;}
        public StringField ImageBase64{get; set;}
        public BooleanField ResultProcessed{get; set;}
        public BooleanField IsRectified{get; set;}
        public Int16Field IsActive{get; set;}
        public Int32Field TenantId{get; set;}

        public StringField OCRData1Key{get; set;}
        public StringField OCRData1Value{get; set;}
        public StringField OCRData2Key{get; set;}
        public StringField OCRData2Value{get; set;}
        public StringField OCRData3Key{get; set;}
        public StringField OCRData3Value{get; set;}
        public StringField ICRData1Key{get; set;}
        public StringField ICRData1Value{get; set;}
        public StringField ICRData2Key{get; set;}
        public StringField ICRData2Value{get; set;}
        public StringField ICRData3Key{get; set;}
        public StringField ICRData3Value{get; set;}
    }
}