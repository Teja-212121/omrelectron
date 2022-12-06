using Microsoft.AspNetCore.Mvc;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
using MyRow = Rio.Workspace.ImportedScannedSheetRow;

namespace Rio.Workspace.Endpoints
{
    [Route("Services/Workspace/ImportedScannedSheet/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class ImportedScannedSheetController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IImportedScannedSheetSaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IImportedScannedSheetSaveHandler handler)
        {
            return handler.Update(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse ProcessResult(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IImportedScannedSheetSaveHandler handler)
        {
            SaveResponse saveResponse = new SaveResponse();
            var importedScannedQuestions = uow.Connection.List<ImportedScannedQuestionRow>(ImportedScannedQuestionRow.Fields.ScannedSheetId == request.Entity.ScannedBatchId.Value);
            var Exam = uow.Connection.TryFirst<ExamRow>(ExamRow.Fields.Code == request.Entity.CorrectedExamNo.ToString() && ExamRow.Fields.TenantId == request.Entity.TenantId.Value);
            if (Exam == null)
                throw new ValidationError("Exam Not found");
            if (importedScannedQuestions.Count > 0)
            {
                foreach (ImportedScannedQuestionRow question in importedScannedQuestions)
                {
                    var ExamQuestion = uow.Connection.TryFirst<ExamQuestionRow>(ExamQuestionRow.Fields.ExamId == Exam.Id.Value && ExamQuestionRow.Fields.QuestionIndex == Exam.Id.Value);
                    if (ExamQuestion != null)
                    {
                        var ExamQuestionResult = new ExamQuestionResultRow();
                        ExamQuestionResult.QuestionIndex = question.QuestionIndex;
                        ExamQuestionResult.RollNumber = request.Entity.CorrectedRollNo;
                        ExamQuestionResult.ExamId = Exam.Id;
                        ExamQuestionResult.SheetGuid = request.Entity.Id;
                        ExamQuestionResult.SheetNumber = request.Entity.SheetNumber;
                        if (ExamQuestion.RuleTypeId == 1)
                        {

                        }
                        else if (ExamQuestion.RuleTypeId ==2)
                        {

                        }
                        else if (ExamQuestion.RuleTypeId == 3)
                        {

                        }

                    }
                }
            }

            return saveResponse;
        }

        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] IImportedScannedSheetDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] IImportedScannedSheetRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow))]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] IImportedScannedSheetListHandler handler)
        {
            return handler.List(connection, request);
        }

        [AuthorizeList(typeof(MyRow))]
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
            [FromServices] IImportedScannedSheetListHandler handler,
            [FromServices] IExcelExporter exporter)
        {
            var data = List(connection, request, handler).Entities;
            var bytes = exporter.Export(data, typeof(Columns.ImportedScannedSheetColumns), request.ExportColumns);
            return ExcelContentResult.Create(bytes, "ImportedScannedSheetList_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
        }
    }
}