using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Rio.Web.Enums;
using Serenity;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using MyRow = Rio.Workspace.PreDefinedKeyRow;

namespace Rio.Workspace.Endpoints
{
    [Route("Services/Workspace/PreDefinedKey/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class PreDefinedKeyController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IPreDefinedKeySaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IPreDefinedKeySaveHandler handler)
        {
            return handler.Update(uow, request);
        }

        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] IPreDefinedKeyDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] IPreDefinedKeyRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow))]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] IPreDefinedKeyListHandler handler)
        {
            return handler.List(connection, request);
        }

        [AuthorizeList(typeof(MyRow))]
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
            [FromServices] IPreDefinedKeyListHandler handler,
            [FromServices] IExcelExporter exporter)
        {
            var data = List(connection, request, handler).Entities;
            var bytes = exporter.Export(data, typeof(Columns.PreDefinedKeyColumns), request.ExportColumns);
            return ExcelContentResult.Create(bytes, "PreDefinedKeyList_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
        }
        [HttpPost]
        public ExcelImportResponse ExcelImport(IUnitOfWork uow, ExcelImportRequest request,
            [FromServices] IUploadStorage uploadStorage,
            [FromServices] IPreDefinedKeySaveHandler handler)
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

                    Row.SerialKey = Convert.ToString(worksheet.Cells[row, 1].Value ?? "").Trim();
                    if (string.IsNullOrEmpty(Row.SerialKey))
                    {
                        response.ErrorList.Add("Error On Row " + row + ": SerialKey Not found");
                        continue;
                    }
                    Row.EStatus = PreDefinedKeyStatus.Open;
                    Row.InsertDate = DateTime.Now;
                    Row.InsertUserId = Convert.ToInt32(User.GetIdentifier());

                    uow.Connection.Insert(Row);
                    response.Inserted = response.Inserted + 1;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return response;
        }
    }
}