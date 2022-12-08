using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Rio.Web;
using Serenity;
using Serenity.Data;
using Serenity.Extensions;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using MyRow = Rio.Workspace.StudentRow;

namespace Rio.Workspace.Endpoints
{
    [Route("Services/Workspace/Student/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class StudentController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IStudentSaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IStudentSaveHandler handler)
        {
            return handler.Update(uow, request);
        }
 
        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] IStudentDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] IStudentRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow))]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] IStudentListHandler handler)
        {
            return handler.List(connection, request);
        }

        [AuthorizeList(typeof(MyRow))]
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
            [FromServices] IStudentListHandler handler,
            [FromServices] IExcelExporter exporter)
        {
            var data = List(connection, request, handler).Entities;
            var bytes = exporter.Export(data, typeof(Columns.StudentColumns), request.ExportColumns);
            return ExcelContentResult.Create(bytes, "StudentList_" +
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
            [FromServices] IStudentSaveHandler handler)
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

            for (var row = 2; row <= worksheet.Dimension.End.Row; row++)
            {
                try
                {
                    MyRow Row = new MyRow();

                    /*Row.Id = Convert.ToInt32(worksheet.Cells[row, 1].Value ?? null);
                    if (Row.Id == null)
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Id Not found");
                        continue;
                    }*/
                    Row.RollNo = Convert.ToInt64(worksheet.Cells[row, 1].Value ?? null);
                    if (Row.RollNo == null)
                    {
                        response.ErrorList.Add("Error On Row " + row + ": RollNo Not found");
                        continue;
                    }
                    if (Row.RollNo != 0)
                    {


                        Row.FullName = Convert.ToString(worksheet.Cells[row, 2].Value ?? "").Trim();
                        if (string.IsNullOrEmpty(Row.FullName))
                        {
                            response.ErrorList.Add("Error On Row " + row + ": FullName Not found");
                            continue;
                        }
                        Row.Email = Convert.ToString(worksheet.Cells[row, 3].Value ?? "").Trim();
                        if (string.IsNullOrEmpty(Row.Email))
                        {
                            response.ErrorList.Add("Error On Row " + row + ": Email Not found");
                            continue;
                        }
                        Row.Mobile = Convert.ToString(worksheet.Cells[row, 4].Value ?? "").Trim();
                        if (string.IsNullOrEmpty(Row.Mobile))
                        {
                            response.ErrorList.Add("Error On Row " + row + ": Mobile Not found");
                            continue;
                        }
                        Row.Dob = Convert.ToDateTime(worksheet.Cells[row, 5].Value ?? null);
                        Int16? Gender = Convert.ToInt16(worksheet.Cells[row, 6].Value ?? null);
                        if (Gender != null)
                        {

                            if (Gender == 1)
                            {
                                Row.Gender = Web.Enums.Gender.Male;
                            }
                            else if (Gender == 2)
                                Row.Gender = Web.Enums.Gender.Female;
                            else if (Gender == 3)
                                Row.Gender = Web.Enums.Gender.Other;
                            else
                            {
                                response.ErrorList.Add("Error On Row " + row + ": Invalid Gender");
                                continue;
                            }
                        }

                        Row.Note = Convert.ToString(worksheet.Cells[row, 7].Value ?? "").Trim();
                        Row.InsertDate = DateTime.UtcNow;
                        Row.InsertUserId = Convert.ToInt32(User.GetIdentifier());
                        Row.TenantId = Convert.ToInt32(worksheet.Cells[row, 8].Value ?? null);
                        var tenantid = User.GetTenantId();
                        /*Row.TenantId = student.TenantId;*/
                        if (Permissions.HasPermission("Administration.Security"))
                        {
                            uow.Connection.Insert<StudentRow>(Row);
                            response.Inserted = response.Inserted + 1;
                        }
                        else
                        {
                            if (Row.TenantId != tenantid)
                            {
                                response.ErrorList.Add("Error On Row " + row + ": TenantId doest not belong to Student!!");
                                continue;
                            }
                            else
                            {
                                uow.Connection.Insert<StudentRow>(Row);
                                response.Inserted = response.Inserted + 1;
                            }
                        }

                    }

                }
                catch (Exception)
                {
                    //response.ErrorList.Add("Exception on Row " + row + ": " + ex.Message);
                    throw;
                }
            }
            return response;
        }

        [AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse DeleteStudent(string[] ids, IUnitOfWork uow, [FromServices] IStudentDeleteHandler handler)
        {
            foreach (var id in ids)
            {
                DeleteRequest deleteRequest = new DeleteRequest();
                deleteRequest.EntityId = id;
                DeleteResponse del = handler.Delete(uow, deleteRequest);
            }
            return new SaveResponse();
        }
    }
}