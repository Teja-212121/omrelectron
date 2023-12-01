using Microsoft.AspNetCore.Mvc;
using Rio.Web;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
using MyRow = Rio.Workspace.ExamListExamsRow;

namespace Rio.Workspace.Endpoints
{
    [Route("Services/Workspace/ExamListExams/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class ExamListExamsController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IExamListExamsSaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IExamListExamsSaveHandler handler)
        {
            return handler.Update(uow, request);
        }

        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] IExamListExamsDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] IExamListExamsRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow))]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] IExamListExamsListHandler handler)
        {
            return handler.List(connection, request);
        }

        [AuthorizeList(typeof(MyRow))]
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
            [FromServices] IExamListExamsListHandler handler,
            [FromServices] IExcelExporter exporter)
        {
            var data = List(connection, request, handler).Entities;
            var bytes = exporter.Export(data, typeof(Columns.ExamListExamsColumns), request.ExportColumns);
            return ExcelContentResult.Create(bytes, "ExamListExamsList_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
        }

        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse AssignExamList(IUnitOfWork uow, SaveRequest<MyRow> request, [FromServices] IExamRetrieveHandler handler)
        {
            SaveResponse saveResponse = new SaveResponse();

            if (request.Entity.RowIds != null)
            {
                string[] rowIds = request.Entity.RowIds.Split(',');
                string erromsg = null;
                bool issingleadded = false;
                if (rowIds.Length > 0)
                {

                    int i = 1;

                    foreach (var id in rowIds)
                    {
                        if (uow.Connection.Exists<MyRow>
                                    (MyRow.Fields.ExamId == id))
                        {
                            erromsg = erromsg + id + ",";
                        }
                        else
                        {
                            var exam = uow.Connection.TryFirst<ExamRow>(ExamRow.Fields.Id == Convert.ToInt32(id));

                            var Id = uow.Connection.InsertAndGetID(new MyRow
                            {
                                ExamListId = request.Entity.ExamListId,
                                ExamId = Convert.ToInt32(id),
                                Priority = i,
                                StartDate =request.Entity.StartDate,
                                EndDate=request.Entity.EndDate,
                                ModelAnswerPaperStartDate=request.Entity.ModelAnswerPaperStartDate,
                                TenantId = exam.TenantId,
                                InsertDate = DateTime.Now,
                                InsertUserId = 1,
                                IsActive = 1,
                            });
                            issingleadded = true;
                        }
                        i++;
                    }
                    if (issingleadded == false)
                    {
                        throw new ValidationError("Exam Already mapped to ExamList");

                    }
                    if (erromsg != null)
                    {
                        erromsg = "Group Question with Id " + erromsg + " already Mapped To Exams.Other Questions Mapped To exam";
                        saveResponse.Error = new ServiceError();
                        saveResponse.Error.Message = erromsg;
                        //throw new ValidationError(erromsg);
                    }
                    else
                    {
                        saveResponse.Error = new ServiceError();
                        saveResponse.Error.Message = "Added Successfully";
                    }

                }
            }
            return saveResponse;
        }
    }
}