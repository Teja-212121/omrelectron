using Dapper;
using Microsoft.AspNetCore.Mvc;
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
using System.Linq;
using MyRow = Rio.Workspace.SerialKeyRow;

namespace Rio.Workspace.Endpoints
{
    [Route("Services/Workspace/SerialKey/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class SerialKeyController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] ISerialKeySaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] ISerialKeySaveHandler handler)
        {
            return handler.Update(uow, request);
        }

        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] ISerialKeyDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] ISerialKeyRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow))]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] ISerialKeyListHandler handler)
        {
            return handler.List(connection, request);
        }

        [AuthorizeList(typeof(MyRow))]
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
            [FromServices] ISerialKeyListHandler handler,
            [FromServices] IExcelExporter exporter)
        {
            var data = List(connection, request, handler).Entities;
            var bytes = exporter.Export(data, typeof(Columns.SerialKeyColumns), request.ExportColumns);
            return ExcelContentResult.Create(bytes, "SerialKeyList_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
        }
        [AuthorizeUpdate(typeof(MyRow))]
        public ExcelImportResponse GenerateSerialKey(GenerateCodeRequest request, [FromServices] ISqlConnections sqlConnections)
        {
            var response = new ExcelImportResponse();
            response.ErrorList = new List<string>();
            using (var Connection = sqlConnections.NewByKey("Default"))
            {
                var predefinekey = Connection.List<PreDefinedKeyRow>(PreDefinedKeyRow.Fields.EStatus == Convert.ToInt16(KeyStatus.Open));
                foreach (var key in predefinekey)
                {
                    var examlist = Connection.TryFirst<ExamListRow>(ExamListRow.Fields.Id == request.ExamListId);
                    int rowCount = Connection.ExecuteScalar<int>("SELECT Id FROM PredefinedKeys LIMIT 3;");
                    for (int i = 0; i <= rowCount; i++)
                    {
                        if(rowCount<request.Quantity)
                        {
                            MyRow codeRow = new MyRow();

                            codeRow.SerialKey = key.SerialKey;
                            codeRow.ExamListId = examlist.Id;

                            codeRow.EStatus = KeyStatus.Open;
                            codeRow.InsertDate = DateTime.Now;
                            codeRow.InsertUserId = Convert.ToInt32(User.GetIdentifier());
                            codeRow.IsActive = 1;
                            Connection.Insert<MyRow>(codeRow);
                        }
                        rowCount++;

                    }
                    key.EStatus = (PreDefinedKeyStatus?)KeyStatus.Created;
                    Connection.UpdateById(key);
                }
               
            }
            return response;
        }



        public class GenerateCodeRequest : ServiceRequest
        {
            public string Estatus { get; set; }
            public int ExamListId { get; set; }
            public int Quantity { get; set; }
            public int SerialKey { get; set; }
        }
    }

}