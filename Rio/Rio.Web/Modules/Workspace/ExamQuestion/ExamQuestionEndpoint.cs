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
using MyRow = Rio.Workspace.ExamQuestionRow;

namespace Rio.Workspace.Endpoints
{
    [Route("Services/Workspace/ExamQuestion/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class ExamQuestionController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IExamQuestionSaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IExamQuestionSaveHandler handler)
        {
            return handler.Update(uow, request);
        }
 
        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] IExamQuestionDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] IExamQuestionRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow))]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] IExamQuestionListHandler handler)
        {
            return handler.List(connection, request);
        }

        [AuthorizeList(typeof(MyRow))]
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
            [FromServices] IExamQuestionListHandler handler,
            [FromServices] IExcelExporter exporter)
        {
            var data = List(connection, request, handler).Entities;
            var bytes = exporter.Export(data, typeof(Columns.ExamQuestionColumns), request.ExportColumns);
            return ExcelContentResult.Create(bytes, "ExamQuestionList_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
        }

        [AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse DeleteExamQuestion(string[] ids, IUnitOfWork uow, [FromServices] IExamQuestionDeleteHandler handler)
        {
            foreach (var id in ids)
            {
                DeleteRequest deleteRequest = new DeleteRequest();
                deleteRequest.EntityId = id;
                DeleteResponse del = handler.Delete(uow, deleteRequest);
            }
            return new SaveResponse();
        }

        [HttpPost]
        public ExcelImportResponse ExcelImport(IUnitOfWork uow, ExcelImportRequest request,
            [FromServices] IUploadStorage uploadStorage,
            [FromServices] IExamQuestionSaveHandler handler)
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
            //var p = ProductsRow.Fields;*/

            var response = new ExcelImportResponse
            {
                ErrorList = new List<string>()
            };

            var worksheet = ep.Workbook.Worksheets[0];

            for (var row = 2; row <= worksheet.Dimension.End.Row; row++)
            {
                try
                {
                    MyRow Row = new MyRow();

                    Row.ExamId = Convert.ToInt32(worksheet.Cells[row, 1].Value ?? null);
                    if (Row.ExamId == null)
                    {
                        response.ErrorList.Add("Error On Row " + row + ": ExamId Not found");
                        continue;
                    }
                    else
                    {
                        var examId = uow.Connection.TryFirst<ExamRow>(ExamRow.Fields.Id == Row.ExamId.Value);
                        if (examId == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": Invalid Exam Id!!!");
                            continue;
                        }
                        else
                            Row.ExamId = examId.Id;
                    }
                    Row.QuestionIndex = Convert.ToInt32(worksheet.Cells[row, 2].Value ?? null);
                    Row.RightOptions = Convert.ToInt16(worksheet.Cells[row, 3].Value ?? null);
                    Row.Score = Convert.ToInt32(worksheet.Cells[row, 4].Value ?? null);
                    Row.ExamSectionId = Convert.ToInt32(worksheet.Cells[row, 5].Value ?? null);
                    if (Row.ExamSectionId == null)
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Exam Section Id Not found");
                        continue;
                    }
                    /*else
                    {
                        var examsectionid = uow.Connection.TryFirst<ExamSectionRow>(ExamSectionRow.Fields.Id == Row.ExamSectionId.Value);
                        if (examsectionid == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": Invalid Exam Section Id!!!");
                            continue;
                        }
                        else
                            Row.ExamSectionId = examsectionid.Id;
                    }*/
                    Row.RuleTypeId = Convert.ToInt32(worksheet.Cells[row, 6].Value ?? null);
                    if (Row.RuleTypeId == null)
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Rule Type Id Not found");
                        continue;
                    }
                    /*else
                    {
                        var ruletypeid = uow.Connection.TryFirst<RuleTypeRow>(RuleTypeRow.Fields.Id == Row.RuleTypeId.Value);
                        if (ruletypeid == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": Invalid Rule Type Id!!!");
                            continue;
                        }
                        else
                            Row.RuleTypeId = ruletypeid.Id;
                    }*/
                    Row.TenantId = Convert.ToInt32(worksheet.Cells[row, 7].Value ?? null);
                    Row.InsertDate = DateTime.UtcNow;
                    Row.InsertUserId = Convert.ToInt32(User.GetIdentifier());

                    uow.Connection.Insert<ExamQuestionRow>(Row);
                    response.Inserted = response.Inserted + 1;


                }
                catch (Exception)/*(Exception ex)*/
                {
                    //response.ErrorList.Add("Exception on Row " + row + ": " + ex.Message);
                    throw;
                }
            }
            return response;

        }
    }
}
    
