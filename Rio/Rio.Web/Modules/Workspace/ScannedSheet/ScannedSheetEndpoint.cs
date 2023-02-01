using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using Org.BouncyCastle.Crypto;
using Serenity;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using MyRow = Rio.Workspace.ScannedSheetRow;

namespace Rio.Workspace.Endpoints
{
    [Route("Services/Workspace/ScannedSheet/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class ScannedSheetController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IScannedSheetSaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IScannedSheetSaveHandler handler)
        {
            return handler.Update(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Updateresults(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IScannedSheetSaveHandler handler)
        {
            ISqlDialect sqlDialect = uow.Connection.GetDialect();

            Guid sheetid = new Guid(request.EntityId.ToString());
            var result = uow.Connection.TryFirst<ExamQuestionResultRow>(ExamQuestionResultRow.Fields.ScannedBatchId == sheetid);
            if (result != null)
                throw new ValidationError("Result already exists");
            var Scannedsheet = uow.Connection.TryFirst<MyRow>(MyRow.Fields.Id == sheetid);
            var Exams = uow.Connection.TryFirst<ExamRow>(ExamRow.Fields.Code == Scannedsheet.CorrectedExamNo && MyRow.Fields.TenantId == Scannedsheet.TenantId.Value);
            string sqlQuery = "select Distinct RuleTypeId from ExamQuestions where Examid= " + Exams.Id.ToString();

            string query = "";
            List<int> RuleTypes = uow.Connection.Query<int>(sqlQuery, commandType: System.Data.CommandType.Text).ToList();
            foreach (int ruletype in RuleTypes)
            {
                if (sqlDialect is SqliteDialect)
                {
                    if (ruletype == 1)
                    {
                        //query = query + " declare @Score float " +
                        //    "select @Score = isnull(NegativeMarks,0) from exams where Id =" + Exams.Id + " " +
                        //    "set @Score= @Score*(-1) ";
                        query = query + " Insert into ExamQuestionResults (StudentId,ScannedBatchId,ScannedSheetId,RollNumber,SheetNumber,SheetGuid,ExamId,QuestionIndex,IsAttempted,IsCorrect,ObtainedMarks,TenantId) " +
                            " select s.Id,ss.ScannedBatchId,ss.Id,ss.CorrectedRollNo,ss.SheetNumber,ss.Id,e.Id,eq.QuestionIndex," +
                            " case when sq.CorrectedOptions is null then 0 else 1 end as IsAttempted,case  when SQ.CorrectedOptions =EQ.RightOptions then 1 else 0 end as IsCorrect, " +
                            " case when SQ.CorrectedOptions is null then 0 when SQ.CorrectedOptions =EQ.RightOptions then EQ.Score else (ifnull(e.NegativeMarks,0)*(-1)) end as ObtainedMarks,ss.TenantId" +
                            " from ScannedQuestions SQ inner join ScannedSheets SS on sq.ScannedSheetId=ss.Id" +
                            " inner join Exams E on ss.CorrectedExamNo=E.Code" +
                            " inner join ExamQuestions EQ on EQ.QuestionIndex=sq.QuestionIndex and eq.ExamId=e.Id" +
                            " left join Students s on ss.CorrectedRollNo=s.RollNo and ss.TenantId=s.TenantId" +
                            " where ss.CorrectedRollNo=" + Scannedsheet.CorrectedRollNo + " and ss.CorrectedExamNo=" + Scannedsheet.CorrectedExamNo + " and RuletypeId=1 and ss.tenantId=" + Scannedsheet.TenantId;
                    }

                    if (ruletype == 2)
                    {

                        query = query + " Insert into ExamQuestionResults (StudentId,ScannedBatchId,ScannedSheetId,RollNumber,SheetNumber,SheetGuid,ExamId,QuestionIndex,IsAttempted,IsCorrect,ObtainedMarks,TenantId) " +
                            " select s.Id,ss.ScannedBatchId,ss.Id,ss.CorrectedRollNo,ss.SheetNumber,ss.Id,e.Id,eq.QuestionIndex," +
                            " case when sq.CorrectedOptions is null then 0 else 1 end as IsAttempted," +
                            " (select dbo.Ruletype2(sq.CorrectedOptions,EQ.RightOptions)) as IsCorrect," +
                            " (select dbo.Ruletype2Marks(sq.CorrectedOptions,EQ.RightOptions,EQ.Id)) as score,ss.TenantId" +
                            " from ScannedQuestions SQ  inner join ScannedSheets SS on sq.ScannedSheetId=ss.Id" +
                            " inner join Exams E on ss.CorrectedExamNo=E.Code inner join ExamQuestions EQ on EQ.QuestionIndex=sq.QuestionIndex and eq.ExamId=e.Id " +
                            " left join Students s on ss.CorrectedRollNo=s.RollNo and ss.TenantId=s.TenantId" +
                            " where ss.CorrectedRollNo=" + Scannedsheet.CorrectedRollNo + " and ss.CorrectedExamNo=" + Scannedsheet.CorrectedExamNo + " and RuletypeId=2 and ss.tenantId=" + Scannedsheet.TenantId;
                    }

                    if (ruletype == 3)
                    {

                        query = query + " Insert into ExamQuestionResults (StudentId,ScannedBatchId,ScannedSheetId,RollNumber,SheetNumber,SheetGuid,ExamId,QuestionIndex,IsAttempted,IsCorrect,ObtainedMarks,TenantId) " +
                            " select s.Id,ss.ScannedBatchId,ss.Id,s.RollNo,ss.SheetNumber,ss.Id,e.Id,eq.QuestionIndex," +
                            " case when sq.CorrectedOptions is null then 0 else 1 end as IsAttempted,1 as IsCorrect,EQ.Score,ss.TenantId" +
                            " from ScannedQuestions SQ inner join ScannedSheets SS on sq.ScannedSheetId=ss.Id" +
                            " inner join Exams E on ss.CorrectedExamNo=E.Code inner join ExamQuestions EQ on EQ.QuestionIndex=sq.QuestionIndex and eq.ExamId=e.Id" +
                            " left join Students s on ss.CorrectedRollNo=s.RollNo and ss.TenantId=s.TenantId" +
                            " where ss.CorrectedRollNo=" + Scannedsheet.CorrectedRollNo + " and ss.CorrectedExamNo=" + Scannedsheet.CorrectedExamNo + " and RuletypeId=3 and ss.tenantId=" + Scannedsheet.TenantId;
                    }

                    if (ruletype == 5)
                    {

                        query = query + " Insert into ExamQuestionResults (StudentId,ScannedBatchId,ScannedSheetId,RollNumber,SheetNumber,SheetGuid,ExamId,QuestionIndex,IsAttempted,IsCorrect,ObtainedMarks,TenantId) " +
                             " select s.Id,ss.ScannedBatchId,ss.Id,s.RollNo,ss.SheetNumber,ss.Id,e.Id,eq.QuestionIndex," +
                             " case when sq.CorrectedOptions is null then 0 else 1 end as IsAttempted,case  when SQ.CorrectedOptions =EQ.RightOptions then 1 else 0 end as IsCorrect, " +
                            " case when SQ.CorrectedOptions is null then 0 when SQ.CorrectedOptions =EQ.RightOptions then EQ.Score else @Score end as ObtainedMarks,ss.TenantId" +
                            " from ScannedQuestions SQ inner join ScannedSheets SS on sq.ScannedSheetId=ss.Id" +
                            " inner join Exams E on ss.CorrectedExamNo=E.Code" +
                            " inner join ExamQuestions EQ on EQ.QuestionIndex=sq.QuestionIndex and eq.ExamId=e.Id" +
                            " left join Students s on ss.CorrectedRollNo=s.RollNo and ss.TenantId=s.TenantId" +
                            " where ss.CorrectedRollNo=" + Scannedsheet.CorrectedRollNo + " and ss.CorrectedExamNo=" + Scannedsheet.CorrectedExamNo + " and RuletypeId=5 and ss.tenantId=" + Scannedsheet.TenantId;
                    }

                    if (ruletype == 6)
                    {

                        query = query + " Insert into ExamQuestionResults (StudentId,ScannedBatchId,ScannedSheetId,RollNumber,SheetNumber,SheetGuid,ExamId,QuestionIndex,IsAttempted,IsCorrect,ObtainedMarks,TenantId) " +
                            " select s.Id,ss.ScannedBatchId,ss.Id,s.RollNo,ss.SheetNumber,ss.Id,e.Id,eq.QuestionIndex," +
                            " case when sq.CorrectedOptions is null then 0 else 1 end as IsAttempted," +
                            " case  when SQ.CorrectedOptions =EQ.RightOptions then 1 else 0 end as IsCorrect, " +
                            " case when SQ.CorrectedOptions is null then 0 else EQ.Score  end as ObtainedMarks,ss.TenantId" +
                            " from ScannedQuestions SQ inner join ScannedSheets SS on sq.ScannedSheetId=ss.Id " +
                            " inner join Exams E on ss.CorrectedExamNo=E.Code inner join ExamQuestions EQ on EQ.QuestionIndex=sq.QuestionIndex and eq.ExamId=e.Id" +
                            " left join Students s on ss.CorrectedRollNo=s.RollNo and ss.TenantId=s.TenantId" +
                            " where ss.CorrectedRollNo=" + Scannedsheet.CorrectedRollNo + " and ss.CorrectedExamNo=" + Scannedsheet.CorrectedExamNo + " and RuletypeId=6 and ss.tenantId=" + Scannedsheet.TenantId;
                    }

                    if (ruletype == 7)
                    {

                        query = query + " Insert into ExamQuestionResults (StudentId,ScannedBatchId,ScannedSheetId,RollNumber,SheetNumber,SheetGuid,ExamId,QuestionIndex,IsAttempted,IsCorrect,ObtainedMarks,TenantId) " +
                             " select s.Id,ss.ScannedBatchId,ss.Id,s.RollNo,ss.SheetNumber,ss.Id,e.Id,eq.QuestionIndex," +
                             " case when sq.CorrectedOptions is null then 0 else 1 end as IsAttempted," +
                            " (select dbo.Ruletype7(sq.CorrectedOptions,EQ.RightOptions)) as IsCorrect, " +
                            " (select dbo.Ruletype7Marks(sq.CorrectedOptions,EQ.RightOptions,EQ.Id)) as score,ss.TenantId" +
                            " from ScannedQuestions SQ inner join ScannedSheets SS on sq.ScannedSheetId=ss.Id" +
                            " inner join Exams E on ss.CorrectedExamNo=E.Code inner join ExamQuestions EQ on EQ.QuestionIndex=sq.QuestionIndex and eq.ExamId=e.Id " +
                            " left join Students s on ss.CorrectedRollNo=s.RollNo and ss.TenantId=s.TenantId" +
                            " where ss.CorrectedRollNo=" + Scannedsheet.CorrectedRollNo + " and ss.CorrectedExamNo=" + Scannedsheet.CorrectedExamNo + " and RuletypeId=7 and ss.tenantId=" + Scannedsheet.TenantId;
                    }

                    query = query + "  insert into examresults ";

                }
                else if (sqlDialect is SqlServer2012Dialect)
                {

                }
            }
            uow.Connection.Execute(query);

            return new SaveResponse();
        }

        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] IScannedSheetDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] IScannedSheetRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow))]
        public ListResponse<MyRow> List(IDbConnection connection, MyCustomListRequest customrequest,
            [FromServices] IScannedSheetListHandler handler)
        {
            return handler.List(connection, customrequest);
        }

        public class MyCustomListRequest : ListRequest
        {
            public bool OCRandCorrectedRollNo { get; set; }
        }

        [HttpPost]
        public SaveResponse InsertScannedBatchData(IUnitOfWork uow, SaveRequest<List<MyRow>> request, [FromServices] IScannedSheetSaveHandler ScannedSheethandler)
        {

            var resp = new SaveResponse();

            foreach (ScannedSheetRow ScannedSheet in request.Entity)
            {
                List<ScannedQuestionRow> questions = new List<ScannedQuestionRow>();
                questions = ScannedSheet.ScannedQuestions;
                //ScanSheetRow scanSheet = ScannedSheet;

                uow.Connection.Insert<MyRow>(ScannedSheet);
                //ScannedSheet.ScannedQuestions = questions;
                //ScannedSheethandler.Create(uow, request1);
                if (questions != null)
                {
                    foreach (ScannedQuestionRow ScannedQuestion in questions)
                    {
                        uow.Connection.Insert<ScannedQuestionRow>(ScannedQuestion);
                    }

                }

            }

            return resp;
        }

        [AuthorizeList(typeof(MyRow))]
        public FileContentResult ListExcel(IDbConnection connection, MyCustomListRequest request,
            [FromServices] IScannedSheetListHandler handler,
            [FromServices] IExcelExporter exporter)
        {
            var data = List(connection, request, handler).Entities;
            var bytes = exporter.Export(data, typeof(Columns.ScannedSheetColumns), request.ExportColumns);
            return ExcelContentResult.Create(bytes, "ScannedSheetList_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse UpdateResult(string[] ids, IUnitOfWork uow, [FromServices] IScannedSheetSaveHandler handler)
        {
            ISqlDialect sqlDialect = uow.Connection.GetDialect();
            string errorids = "";
            foreach (var id in ids)
            {
                Guid sheetid = new Guid(id.ToString().ToUpper());
                string gid = id.ToString().ToUpper();
                var Scannedsheet = uow.Connection.TryFirst<MyRow>(MyRow.Fields.Id == sheetid);
                var Exams = uow.Connection.TryFirst<ExamRow>(ExamRow.Fields.Code == Scannedsheet.CorrectedExamNo && MyRow.Fields.TenantId == Scannedsheet.TenantId.Value);
                var ExamSection = uow.Connection.TryFirst<ExamSectionRow>(ExamSectionRow.Fields.ExamId == Exams.Id.Value);
                var ExamResult = uow.Connection.TryFirst<ExamResultRow>(ExamResultRow.Fields.ScannedSheetId == sheetid);
                if (sqlDialect is SqliteDialect)
                {
                    if (ExamResult != null)
                    {
                        if (string.IsNullOrEmpty(errorids))
                            errorids = Scannedsheet.CorrectedRollNo;
                        else
                            errorids = errorids + "," + Scannedsheet.CorrectedRollNo;
                    }
                    else
                    {
                        //string sqlQuery = "select Distinct RuleTypeId from ExamQuestions where Examid= " + Exams.Id.ToString();

                        string query = "";
                        //List<int> RuleTypes = uow.Connection.Query<int>(sqlQuery, commandType: System.Data.CommandType.Text).ToList();
                        #region New Logic
                        //foreach (int ruletype in RuleTypes)
                        //{

                        //    if (ruletype == 4)
                        //    {
                        //        var Scandata = uow.Connection.List<GetScanDataRow>(GetScanDataRow.Fields.ScanSheetId == Scannedsheet.Id.Value && GetScanDataRow.Fields.RuleTypeId == 4);

                        //        foreach (GetScanDataRow scanned in Scandata)
                        //        {
                        //            ExamQuestionResultRow examQuestionResult = new ExamQuestionResultRow();

                        //            examQuestionResult.StudentId = scanned.StudentId;
                        //            examQuestionResult.RollNumber = Convert.ToInt64(scanned.CorrectedRollNo);
                        //            examQuestionResult.SheetNumber = scanned.SheetNumber;
                        //            examQuestionResult.SheetGuid = scanned.ScanSheetId;
                        //            examQuestionResult.ExamId = scanned.ExamId;
                        //            examQuestionResult.QuestionIndex = scanned.QuestionIndex;
                        //            examQuestionResult.TenantId = scanned.TenantId;
                        //            examQuestionResult.InsertUserId = Convert.ToInt32(User.GetIdentifier());
                        //            examQuestionResult.InsertDate = DateTime.Now;
                        //            if (string.IsNullOrEmpty(scanned.CorrectedOptions))
                        //            {
                        //                examQuestionResult.IsAttempted = false;
                        //                examQuestionResult.ObtainedMarks = 0;
                        //                examQuestionResult.IsCorrect = false;
                        //            }
                        //            else
                        //            {
                        //                if (scanned.CorrectedOptions.Length > 1)
                        //                {
                        //                    examQuestionResult.IsAttempted = true;
                        //                    examQuestionResult.ObtainedMarks = 0;
                        //                    examQuestionResult.IsCorrect = false;
                        //                }
                        //                else
                        //                {
                        //                    if (!scanned.RightOptions.Contains(scanned.CorrectedOptions))
                        //                    {
                        //                        examQuestionResult.IsAttempted = true;
                        //                        examQuestionResult.ObtainedMarks = 0;
                        //                        examQuestionResult.IsCorrect = false;
                        //                    }
                        //                    else
                        //                    {

                        //                        int selectedoption = Convert.ToInt32(scanned.CorrectedOptions);
                        //                        string[] score = scanned.Score.Split(',');
                        //                        if (selectedoption <= score.Length && selectedoption > 0)
                        //                        {
                        //                            int scoreAt = selectedoption - 1;
                        //                            float marksobtained = Convert.ToSingle(score[scoreAt]);
                        //                            examQuestionResult.IsAttempted = true;
                        //                            examQuestionResult.ObtainedMarks = marksobtained;
                        //                            examQuestionResult.IsCorrect = true;
                        //                        }
                        //                        else
                        //                        {
                        //                            examQuestionResult.IsAttempted = true;
                        //                            examQuestionResult.ObtainedMarks = 0;
                        //                            examQuestionResult.IsCorrect = true;
                        //                        }
                        //                    }

                        //                }



                        //            }
                        //            uow.Connection.Insert<ExamQuestionResultRow>(examQuestionResult);
                        //        }
                        //    }
                        //    if (ruletype == 1)
                        //    {
                        //        //query = query + " declare @Score float " +
                        //        //    "select @Score = isnull(NegativeMarks,0) from exams where Id =" + Exams.Id + " " +
                        //        //    "set @Score= @Score*(-1) ";
                        //        query = " Insert into ExamQuestionResults (StudentId,ScannedBatchId,ScannedSheetId,RollNumber,SheetNumber,SheetGuid,ExamId,QuestionIndex,IsAttempted,IsCorrect,ObtainedMarks,TenantId,InsertDate,InsertUserId) " +
                        //            " select s.Id,ss.ScannedBatchId,ss.Id,ss.CorrectedRollNo,ss.SheetNumber,ss.Id,e.Id,eq.QuestionIndex," +
                        //            " case when sq.CorrectedOptions is null then 0 else 1 end as IsAttempted,case  when SQ.CorrectedOptions =EQ.RightOptions then 1 else 0 end as IsCorrect, " +
                        //            " case when SQ.CorrectedOptions is null then 0 when SQ.CorrectedOptions =EQ.RightOptions then EQ.Score else (ifnull(e.NegativeMarks,0)*(-1)) end as ObtainedMarks,ss.TenantId" +
                        //            " ,datetime('now')," + User.GetIdentifier() + "" +
                        //            " from ScannedQuestions SQ inner join ScannedSheets SS on sq.ScannedSheetId=ss.Id" +
                        //            " inner join Exams E on ss.CorrectedExamNo=E.Code" +
                        //            " inner join ExamQuestions EQ on EQ.QuestionIndex=sq.QuestionIndex and eq.ExamId=e.Id" +
                        //            " left join Students s on ss.CorrectedRollNo=s.RollNo and ss.TenantId=s.TenantId" +
                        //            " where ss.Id='" + id.ToString().ToUpper() + "' and ss.CorrectedExamNo=" + Scannedsheet.CorrectedExamNo + " and RuletypeId=1 and ss.tenantId=" + Scannedsheet.TenantId;
                        //        if (!string.IsNullOrEmpty(query))
                        //            uow.Connection.Execute(query);
                        //    }

                        //    if (ruletype == 2)
                        //    {
                        //        var Scandata = uow.Connection.List<GetScanDataRow>(GetScanDataRow.Fields.ScanSheetId == Scannedsheet.Id.Value && GetScanDataRow.Fields.RuleTypeId == 2);

                        //        //string Querytogetdata = "select s.Id as StudentId,e.Id as ExamId,e.NegativeMarks,eq.QuestionIndex,ss.TenantId,ss.Id as ScanSheetId,ss.ScannedBatchId as ScanBatchId," +
                        //        //   " eq.Score,ss.CorrectedRollNo,ss.SheetNumber,eq.RightOptions,sq.CorrectedOptions " +
                        //        //   " from ScannedQuestions SQ inner join ScannedSheets SS on sq.ScannedSheetId=ss.Id" +
                        //        //   " inner join Exams E on ss.CorrectedExamNo=E.Code" +
                        //        //   " inner join ExamQuestions EQ on EQ.QuestionIndex=sq.QuestionIndex and eq.ExamId=e.Id" +
                        //        //   " left join Students s on ss.CorrectedRollNo=s.RollNo and ss.TenantId=s.TenantId" +
                        //        //   " where ss.Id='" + gid + "' and ss.CorrectedExamNo=" + Scannedsheet.CorrectedExamNo + " and RuletypeId=2 and ss.tenantId=" + Scannedsheet.TenantId;
                        //        //List<ScannedData> RuleType2Data = uow.Connection.Query<ScannedData>(Querytogetdata).ToList();

                        //        foreach (GetScanDataRow scanned in Scandata)
                        //        {
                        //            ExamQuestionResultRow examQuestionResult = new ExamQuestionResultRow();

                        //            examQuestionResult.StudentId = scanned.StudentId;
                        //            examQuestionResult.RollNumber = Convert.ToInt64(scanned.CorrectedRollNo);
                        //            examQuestionResult.SheetNumber = scanned.SheetNumber;
                        //            examQuestionResult.SheetGuid = scanned.ScanSheetId;
                        //            examQuestionResult.ExamId = scanned.ExamId;
                        //            examQuestionResult.QuestionIndex = scanned.QuestionIndex;
                        //            examQuestionResult.TenantId = scanned.TenantId;
                        //            examQuestionResult.InsertUserId = Convert.ToInt32(User.GetIdentifier());
                        //            examQuestionResult.InsertDate = DateTime.Now;
                        //            if (string.IsNullOrEmpty(scanned.CorrectedOptions))
                        //            {
                        //                examQuestionResult.IsAttempted = false;
                        //                examQuestionResult.ObtainedMarks = 0;
                        //                examQuestionResult.IsCorrect = false;
                        //            }
                        //            else
                        //            {
                        //                examQuestionResult.ObtainedMarks = scanned.NegativeMarks * (-1);
                        //                examQuestionResult.IsCorrect = false;
                        //                examQuestionResult.IsAttempted = true;
                        //                if (scanned.CorrectedOptions == scanned.RightOptions)
                        //                    examQuestionResult.ObtainedMarks = scanned.NegativeMarks * (-1);
                        //                else
                        //                {
                        //                    if (scanned.CorrectedOptions.Length == 1)
                        //                    {
                        //                        if (scanned.RightOptions.Contains(scanned.CorrectedOptions))
                        //                        {
                        //                            examQuestionResult.ObtainedMarks = Convert.ToSingle(scanned.Score);
                        //                            examQuestionResult.IsCorrect = true;
                        //                        }
                        //                    }
                        //                    else
                        //                    {
                        //                        if (scanned.CorrectedOptions.Contains(","))
                        //                        {
                        //                            string[] nums = scanned.CorrectedOptions.Split(',');
                        //                            foreach (string s in nums)
                        //                            {
                        //                                if (scanned.RightOptions.Contains(s))
                        //                                {
                        //                                    examQuestionResult.ObtainedMarks = Convert.ToSingle(scanned.Score);
                        //                                    examQuestionResult.IsCorrect = true;
                        //                                    break;
                        //                                }
                        //                            }
                        //                        }
                        //                    }
                        //                }
                        //            }
                        //            uow.Connection.Insert<ExamQuestionResultRow>(examQuestionResult);
                        //        }
                        //    }

                        //    if (ruletype == 3)
                        //    {
                        //        query = "";
                        //        query = " Insert into ExamQuestionResults (StudentId,ScannedBatchId,ScannedSheetId,RollNumber,SheetNumber,SheetGuid,ExamId,QuestionIndex,IsAttempted,IsCorrect,ObtainedMarks,TenantId,InsertDate,InsertUserId) " +
                        //            " select s.Id,ss.ScannedBatchId,ss.Id,ss.CorrectedRollNo,ss.SheetNumber,ss.Id,e.Id,eq.QuestionIndex," +
                        //            " case when sq.CorrectedOptions is null then 0 else 1 end as IsAttempted,1 as IsCorrect,EQ.Score,ss.TenantId" +
                        //            " ,datetime('now')," + User.GetIdentifier() + "" +
                        //            " from ScannedQuestions SQ inner join ScannedSheets SS on sq.ScannedSheetId=ss.Id" +
                        //            " inner join Exams E on ss.CorrectedExamNo=E.Code" +
                        //            " inner join ExamQuestions EQ on EQ.QuestionIndex=sq.QuestionIndex and eq.ExamId=e.Id" +
                        //            " left join Students s on ss.CorrectedRollNo=s.RollNo and ss.TenantId=s.TenantId" +
                        //             " where ss.Id='" + id.ToString().ToUpper() + "' and ss.CorrectedExamNo=" + Scannedsheet.CorrectedExamNo + " and RuletypeId=3 and ss.tenantId=" + Scannedsheet.TenantId;
                        //        if (!string.IsNullOrEmpty(query))
                        //            uow.Connection.Execute(query);
                        //    }



                        //    if (ruletype == 5)
                        //    {
                        //        query = "";

                        //        query = " Insert into ExamQuestionResults (StudentId,ScannedBatchId,ScannedSheetId,RollNumber,SheetNumber,SheetGuid,ExamId,QuestionIndex,IsAttempted,IsCorrect,ObtainedMarks,TenantId,InsertDate,InsertUserId) " +
                        //           " select s.Id,ss.ScannedBatchId,ss.Id,ss.CorrectedRollNo,ss.SheetNumber,ss.Id,e.Id,eq.QuestionIndex," +
                        //    " case when sq.CorrectedOptions is null then 0 else 1 end as IsAttempted,case  when SQ.CorrectedOptions =EQ.RightOptions then 1 else 0 end as IsCorrect, " +
                        //            " case when SQ.CorrectedOptions is null then 0 when SQ.CorrectedOptions =EQ.RightOptions then EQ.Score else (ifnull(e.NegativeMarks,0)*(-1)) end as ObtainedMarks,ss.TenantId" +
                        //            " ,datetime('now')," + User.GetIdentifier() + "" +
                        //            " from ScannedQuestions SQ inner join ScannedSheets SS on sq.ScannedSheetId=ss.Id" +
                        //            " inner join Exams E on ss.CorrectedExamNo=E.Code" +
                        //            " inner join ExamQuestions EQ on EQ.QuestionIndex=sq.QuestionIndex and eq.ExamId=e.Id" +
                        //            " left join Students s on ss.CorrectedRollNo=s.RollNo and ss.TenantId=s.TenantId" +
                        //            " where ss.Id='" + id.ToString().ToUpper() + "' and ss.CorrectedExamNo=" + Scannedsheet.CorrectedExamNo + " and RuletypeId=5 and ss.tenantId=" + Scannedsheet.TenantId;
                        //        if (!string.IsNullOrEmpty(query))
                        //            uow.Connection.Execute(query);
                        //    }

                        //    if (ruletype == 6)
                        //    {
                        //        query = "";

                        //        query = " Insert into ExamQuestionResults (StudentId,ScannedBatchId,ScannedSheetId,RollNumber,SheetNumber,SheetGuid,ExamId,QuestionIndex,IsAttempted,IsCorrect,ObtainedMarks,TenantId,InsertDate,InsertUserId) " +
                        //           " select s.Id,ss.ScannedBatchId,ss.Id,ss.CorrectedRollNo,ss.SheetNumber,ss.Id,e.Id,eq.QuestionIndex," +
                        //            " case when sq.CorrectedOptions is null then 0 else 1 end as IsAttempted," +
                        //            " case  when SQ.CorrectedOptions =EQ.RightOptions then 1 else 0 end as IsCorrect, " +
                        //            " case when SQ.CorrectedOptions is null then 0 else EQ.Score  end as ObtainedMarks,ss.TenantId" +
                        //            " ,datetime('now')," + User.GetIdentifier() + "" +
                        //            " from ScannedQuestions SQ inner join ScannedSheets SS on sq.ScannedSheetId=ss.Id" +
                        //            " inner join Exams E on ss.CorrectedExamNo=E.Code" +
                        //            " inner join ExamQuestions EQ on EQ.QuestionIndex=sq.QuestionIndex and eq.ExamId=e.Id" +
                        //            " left join Students s on ss.CorrectedRollNo=s.RollNo and ss.TenantId=s.TenantId" +
                        //             " where ss.Id='" + id.ToString().ToUpper() + "' and ss.CorrectedExamNo=" + Scannedsheet.CorrectedExamNo + " and RuletypeId=6 and ss.tenantId=" + Scannedsheet.TenantId;
                        //        if (!string.IsNullOrEmpty(query))
                        //            uow.Connection.Execute(query);
                        //    }

                        //    if (ruletype == 7)
                        //    {
                        //        var Scandata = uow.Connection.List<GetScanDataRow>(GetScanDataRow.Fields.ScanSheetId == Scannedsheet.Id.Value && GetScanDataRow.Fields.RuleTypeId == 7);

                        //        foreach (GetScanDataRow scanned in Scandata)
                        //        {
                        //            ExamQuestionResultRow examQuestionResult = new ExamQuestionResultRow();

                        //            examQuestionResult.StudentId = scanned.StudentId;
                        //            examQuestionResult.RollNumber = Convert.ToInt64(scanned.CorrectedRollNo);
                        //            examQuestionResult.SheetNumber = scanned.SheetNumber;
                        //            examQuestionResult.SheetGuid = scanned.ScanSheetId;
                        //            examQuestionResult.ExamId = scanned.ExamId;
                        //            examQuestionResult.QuestionIndex = scanned.QuestionIndex;
                        //            examQuestionResult.TenantId = scanned.TenantId;
                        //            examQuestionResult.InsertUserId = Convert.ToInt32(User.GetIdentifier());
                        //            examQuestionResult.InsertDate = DateTime.Now;
                        //            if (string.IsNullOrEmpty(scanned.CorrectedOptions))
                        //            {
                        //                examQuestionResult.IsAttempted = false;
                        //                examQuestionResult.ObtainedMarks = 0;
                        //                examQuestionResult.IsCorrect = false;
                        //            }
                        //            else
                        //            {
                        //                examQuestionResult.ObtainedMarks = scanned.NegativeMarks * (-1);
                        //                examQuestionResult.IsCorrect = false;
                        //                examQuestionResult.IsAttempted = true;
                        //                if (scanned.CorrectedOptions == scanned.RightOptions)
                        //                {
                        //                    examQuestionResult.ObtainedMarks = Convert.ToSingle(scanned.Score);
                        //                    examQuestionResult.IsCorrect = true;
                        //                }
                        //                else
                        //                {
                        //                    if (scanned.CorrectedOptions.Length == 1)
                        //                    {
                        //                        if (scanned.RightOptions.Contains(scanned.CorrectedOptions))
                        //                        {
                        //                            examQuestionResult.ObtainedMarks = Convert.ToSingle(scanned.Score);
                        //                            examQuestionResult.IsCorrect = true;
                        //                        }
                        //                    }
                        //                    else
                        //                    {
                        //                        if (scanned.CorrectedOptions.Contains(","))
                        //                        {
                        //                            string[] nums = scanned.CorrectedOptions.Split(',');
                        //                            foreach (string s in nums)
                        //                            {
                        //                                if (scanned.RightOptions.Contains(s))
                        //                                {
                        //                                    examQuestionResult.ObtainedMarks = Convert.ToSingle(scanned.Score);
                        //                                    examQuestionResult.IsCorrect = true;
                        //                                    break;
                        //                                }
                        //                            }
                        //                        }
                        //                    }
                        //                }
                        //            }
                        //            uow.Connection.Insert<ExamQuestionResultRow>(examQuestionResult);
                        //        }
                        //    }

                        //}
                        #endregion
                        #region Old Logic
                        query = "Insert into ExamQuestionResults (ExamId,ExamQuestionId,ExamSectionId,StudentId,RollNumber,SheetNumber,SheetGuid,QuestionIndex,IsAttempted,IsCorrect,ObtainedMarks,TenantId,ScannedSheetId,ScannedBatchId,InsertDate,InsertUserId)" +
                                " Select ExamId,ExamQuestionId,ExamSectionId,(SELECT Id from Students s WHERE s.RollNo=CorrectedRollNo and s.TenantId=TenantId) as StudentId,CorrectedRollNo,SheetNumber, " +
                                " ScannedSheetId, QuestionIndex,( case when CorrectedOptions is null then 0 else 1 end)as IsAttempted," +
                                " ( Case When Result > 0 then 1 else 0 end) as IsCorrect,CAST(Result AS FLOAT) as Result,TenantId,ScannedSheetId,ScannedBatchId," +
                                " datetime('now')," + User.GetIdentifier() + "" +
                                " From  ( Select QA.ExamId,QA.Id as ExamQuestionId,QA.ExamSectionId,  QA.QuestionIndex,  SQ.CorrectedOptions, qa.RightOptions, QA.Score, " +
                                " (Case when QA.RuleTypeId is null or QA.RuleTypeId = 1 then " +
                                " Case when SQ.CorrectedOptions is null  then 0  when SQ.CorrectedOptions = qa.RightOptions then QA.Score else (Select(round((QA.Score * NegativeMarks),2) * -1) From Exams where id = " + Exams.Id + ")  End " +
                                //" when QA.RuleTypeId = 2 then" +
                                //" case when SQ.CorrectedOptions is null then 0 when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, 1, pos-1) AS A From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, pos+1, pos-1) AS B From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*2)+1, pos-1) AS C From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*3)+1, pos-1) AS D From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*4)+1, pos-1) AS E From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score" +
                                //" else  (Select(round((QA.Score * NegativeMarks),2) * -1) From Exams where id = " + Exams.Id + ") End " +
                                " when QA.RuleTypeId = 3 then  QA.Score " +
                                //" when QA.RuleTypeId = 4 then " +
                                //" Case when SQ.CorrectedOptions is null  then 0 " +
                                //" when SQ.CorrectedOptions = 1 then (SELECT substr(qa.Score, 1, pos-1) AS A From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = 2 then (SELECT substr(qa.Score, pos+1, pos-1) AS B From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = 3 then (SELECT substr(qa.Score, (pos*2)+1, pos-1) AS C From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = 4 then (SELECT substr(qa.Score, (pos*3)+1, pos-1) AS D From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = 5 then (SELECT substr(qa.Score, (pos*4)+1, pos-1) AS E From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*5)+1, pos) AS F From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*5)+1, pos-1) AS F From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*6)+2, pos) AS G From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*6)+1, pos-1) AS G From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*7)+3, pos) AS H From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*7)+1, pos-1) AS H From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*8)+4, pos) AS I From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*8)+1, pos-1) AS I From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*9)+5, pos) AS J From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*9)+1, pos-1) AS J From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*10)+6) AS K From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*10)+1, pos-1) AS K From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions)) " +
                                //" else (Select(round((QA.Score * NegativeMarks),2) * -1) From Exams where id = " + Exams.Id + " )  End " +
                                " when QA.RuleTypeId = 5 then " +
                                " Case when SQ.CorrectedOptions is null  then 0 " +
                                " when SQ.CorrectedOptions = qa.RightOptions then QA.Score " +
                                " else (Select(round((QA.Score * NegativeMarks),2) * -1) From Exams where id = " + Exams.Id + ") End " +
                                " when QA.RuleTypeId = 6 then " +
                                " Case when SQ.CorrectedOptions is null  then 0  else  QA.Score  End " +
                                //" when QA.RuleTypeId = 7 then " +
                                //" case  when SQ.CorrectedOptions is null then 0 " +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, 1, pos-1) AS A From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, pos+1, pos-1) AS B From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*2)+1, pos-1) AS C From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*3)+1, pos-1) AS D From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*4)+1, pos-1) AS E From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                                //" when SQ.CorrectedOptions = (SELECT REPLACE(qa.RightOptions, ',', '')) then QA.Score " +
                                //" else  (Select(round((QA.Score * NegativeMarks),2) * -1) From Exams where id = " + Exams.Id + ")  End " +
                                " End ) as Result, TotalMarks, RuleTypeId, qa.RightOptions,ss.CorrectedRollNo,ss.CorrectedExamNo,ss.SheetNumber,ss.ScannedSheetId,ss.ScannedBatchId,ss.TenantId " +
                                " from ExamQuestions as QA inner join Exams E on QA.ExamId=E.Id " +
                                " left join (select CorrectedRollNo,CorrectedExamNo,SheetNumber,id as ScannedSheetId,ScannedBatchId,TenantId FROM ScannedSheets where Id='" + id.ToString().ToUpper() + "') as SS " +
                                " on E.Code=ss.CorrectedExamNo AND E.TenantId=ss.TenantId left Join ( select 1 as TestId, QuestionIndex,  CorrectedOptions from ScannedQuestions where ScannedSheetId = '" + id.ToString().ToUpper() + "' ) as SQ " +
                                " On  QA.QuestionIndex = SQ.QuestionIndex  where QA.ExamId = " + Exams.Id + " and QA.RuleTypeId in (1,3,5,6) ) as StudentResult ";

                        if (!string.IsNullOrEmpty(query))
                            uow.Connection.Execute(query);
                        #endregion

                        string Examresultquery = "  insert into ExamResults (StudentId, RollNumber, SheetNumber, SheetGuid, ExamId, TotalMarks, ObtainedMarks, Percentage, TotalQuestions, TotalAttempted," +" TotalNotAttempted, TotalRightAnswers, TotalWrongAnswers, InsertDate, InsertUserId, IsActive, TenantId, ScannedBatchId, ScannedSheetId)" +
                            "  select s.Id,ss.CorrectedRollNo,ss.SheetNumber,ss.Id,e.Id,e.TotalMarks," +
                            "  (select sum(ObtainedMarks) from ExamQuestionResults WHERE ScannedSheetId=ss.Id) as ObtainedMarks," +
                            " ((select sum(ObtainedMarks) from ExamQuestionResults WHERE ScannedSheetId=ss.Id)/e.TotalMarks)*100 as Percentage, e.TotalQuestions, " +
                            " (select count(Id) from ExamQuestionResults WHERE ScannedSheetId=ss.Id and IsAttempted=1 ) as TotalAttempted," +
                            " (SELECT e.TotalQuestions-(select count(Id) from ExamQuestionResults WHERE ScannedSheetId=ss.Id and IsAttempted=1)) as TotalNotAttempted," +
                            "  (select count(Id) from ExamQuestionResults WHERE ScannedSheetId=ss.Id and IsCorrect=1) as TotalRightAnswers," +
                            "  ((select count(Id) from ExamQuestionResults WHERE ScannedSheetId=ss.Id and IsAttempted=1) -(select ifnull(count(Id),0) from ExamQuestionResults WHERE ScannedSheetId=ss.Id and IsCorrect=1)) as TotalWrongAnswers," +
                            "  datetime('now'),1,1,ss.TenantId,ss.ScannedBatchId,ss.Id" +
                            "  from  ScannedSheets SS inner join Exams E on ss.CorrectedExamNo=E.Code and ss.TenantId=E.TenantId" +
                            "  left join Students s on ss.CorrectedRollNo=s.RollNo and ss.TenantId=s.TenantId" +
                            " where ss.Id='" + id.ToString().ToUpper() + "'   and ss.tenantId=" + Scannedsheet.TenantId;

                        if (!string.IsNullOrEmpty(Examresultquery))
                            uow.Connection.Execute(Examresultquery);
                        if (ExamSection != null)
                        {
                            string ExamSectionresultquery = "  insert into ExamSectionResults (StudentId, RollNumber,SheetNumber,SheetGuid,ExamId,ExamSectionId,TotalMarks,ObtainedMarks,Percentage,TotalQuestions,TotalAttempted," +
                                " TotalNotAttempted,TotalRightAnswers,TotalWrongAnswers,InsertDate,InsertUserId,IsActive,TenantId)" +
                                "  select s.Id,ss.CorrectedRollNo,ss.SheetNumber,ss.Id,e.Id,Es.Id," +
                                "  (select sum(Score) from Examquestions WHERE ExamSectionId=ES.Id) as TotalMarks," +
                                "  (select sum(ObtainedMarks) from ExamQuestionResults WHERE  ExamSectionId=ES.Id and ScannedSheetId=ss.Id) as ObtainedMarks," +
                                " ((select sum(ObtainedMarks) from ExamQuestionResults WHERE  ExamSectionId=ES.Id and ScannedSheetId=ss.Id)/(select sum(Score) from Examquestions WHERE ExamSectionId=ES.Id))*100 as Percentage," +
                                "  (select count(Id) from Examquestions WHERE ExamSectionId=ES.Id ) as TotalQuestions," +
                                "  (select count(Id) from ExamQuestionResults WHERE ExamSectionId=ES.Id and ScannedSheetId=ss.Id and IsAttempted=1 ) as TotalAttempted," +
                                "  ((select count(Id) from Examquestions WHERE ExamSectionId=ES.Id )-(select count(Id) from ExamQuestionResults WHERE ExamSectionId=ES.Id and ScannedSheetId=ss.Id and IsAttempted=1)) as TotalNotAttempted," +
                                "   (select count(Id) from ExamQuestionResults WHERE ExamSectionId=ES.Id and ScannedSheetId=ss.Id and IsCorrect=1) as TotalRightAnswers," +
                                "   ((select count(Id) from ExamQuestionResults WHERE ExamSectionId=ES.Id and ScannedSheetId=ss.Id and IsAttempted=1) -(select ifnull(count(Id),0) from ExamQuestionResults WHERE ExamSectionId=ES.Id and ScannedSheetId=ss.Id and IsCorrect=1)) as TotalWrongAnswers," +
                                "   datetime('now'),1,1,ss.TenantId   from  ScannedSheets SS inner join Exams E on ss.CorrectedExamNo=E.Code and ss.TenantId=E.TenantId" +
                                "   inner join ExamSections Es on Es.ExamId=E.Id    left join Students s on ss.CorrectedRollNo=s.RollNo and ss.TenantId=s.TenantId" +
                                "  where ss.Id='" + id.ToString().ToUpper() + "'   and ss.tenantId=" + Scannedsheet.TenantId;

                            uow.Connection.Execute(ExamSectionresultquery);

                        }
                    }
                }
                else if (sqlDialect is SqlServer2012Dialect)
                {
                    string query = "";

                    query = "Insert into ExamQuestionResults (ExamId,ExamQuestionId,ExamSectionId,StudentId,RollNumber,SheetNumber,SheetGuid,QuestionIndex,IsAttempted,IsCorrect,ObtainedMarks,TenantId,ScannedSheetId,ScannedBatchId,InsertDate,InsertUserId)" +
                                " Select ExamId,ExamQuestionId,ExamSectionId,(SELECT Id from Students s WHERE s.RollNo=CorrectedRollNo and s.TenantId=TenantId) as StudentId,CorrectedRollNo,SheetNumber," +
                                " ScannedSheetId, QuestionIndex,(case when CorrectedOptions is null then 0 else 1 end)as IsAttempted," +
                                "(Case When Result > 0 then 1 else 0 end) as IsCorrect, CAST(Result AS FLOAT) as Result,TenantId,ScannedSheetId,ScannedBatchId, getdate()," + User.GetIdentifier() + "" +
                                "From (Select QA.ExamId,QA.Id as ExamQuestionId,QA.ExamSectionId, QA.QuestionIndex, SQ.CorrectedOptions, qa.RightOptions, QA.Score," +
                                " (Case when QA.RuleTypeId is null or QA.RuleTypeId = 1 then " +
                                " (Case when SQ.CorrectedOptions is null  then 0  when SQ.CorrectedOptions = qa.RightOptions then QA.Score else (Select(round((QA.Score * NegativeMarks),2) * -1) From Exams where id = " + Exams.Id + ")End)" +
                                //" when QA.RuleTypeId = 2 then" +
                                //" case when SQ.CorrectedOptions is null then 0 when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, 1, pos-1) AS A From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, pos+1, pos-1) AS B From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*2)+1, pos-1) AS C From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*3)+1, pos-1) AS D From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*4)+1, pos-1) AS E From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score" +
                                //" else  (Select(round((QA.Score * NegativeMarks),2) * -1) From Exams where id = " + Exams.Id + ") End " +
                                "when QA.RuleTypeId = 3 then QA.Score " +
                                //" when QA.RuleTypeId = 4 then " +
                                //" Case when SQ.CorrectedOptions is null  then 0 " +
                                //" when SQ.CorrectedOptions = 1 then (SELECT substr(qa.Score, 1, pos-1) AS A From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = 2 then (SELECT substr(qa.Score, pos+1, pos-1) AS B From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = 3 then (SELECT substr(qa.Score, (pos*2)+1, pos-1) AS C From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = 4 then (SELECT substr(qa.Score, (pos*3)+1, pos-1) AS D From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = 5 then (SELECT substr(qa.Score, (pos*4)+1, pos-1) AS E From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*5)+1, pos) AS F From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*5)+1, pos-1) AS F From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*6)+2, pos) AS G From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*6)+1, pos-1) AS G From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*7)+3, pos) AS H From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*7)+1, pos-1) AS H From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*8)+4, pos) AS I From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*8)+1, pos-1) AS I From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*9)+5, pos) AS J From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*9)+1, pos-1) AS J From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*10)+6) AS K From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*10)+1, pos-1) AS K From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions)) " +
                                //" else (Select(round((QA.Score * NegativeMarks),2) * -1) From Exams where id = " + Exams.Id + " )  End " +
                                " when QA.RuleTypeId = 5 then " +
                                " Case when SQ.CorrectedOptions is null then 0 " +
                                " when SQ.CorrectedOptions = qa.RightOptions then QA.Score " +
                                " else (Select(round((QA.Score * NegativeMarks),2) * -1) From Exams where id = " + Exams.Id + ") End " +
                                " when QA.RuleTypeId = 6 then " +
                                " Case when SQ.CorrectedOptions is null then 0 else QA.Score End " +
                                //" when QA.RuleTypeId = 7 then " +
                                //" case  when SQ.CorrectedOptions is null then 0 " +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, 1, pos-1) AS A From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, pos+1, pos-1) AS B From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*2)+1, pos-1) AS C From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*3)+1, pos-1) AS D From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*4)+1, pos-1) AS E From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                                //" when SQ.CorrectedOptions = (SELECT REPLACE(qa.RightOptions, ',', '')) then QA.Score " +
                                //" else  (Select(round((QA.Score * NegativeMarks),2) * -1) From Exams where id = " + Exams.Id + ")  End " +
                                " End) as Result, TotalMarks, RuleTypeId, ss.CorrectedRollNo, ss.CorrectedExamNo, ss.SheetNumber, ss.ScannedSheetId, ss.ScannedBatchId,ss.TenantId " +
                                " from ExamQuestions as QA inner join Exams E on QA.ExamId=E.Id " +
                                " left join (select CorrectedRollNo,CorrectedExamNo,SheetNumber,id as ScannedSheetId,ScannedBatchId,TenantId FROM ScannedSheets where Id='" + id.ToString().ToUpper() + "') as SS " +
                                " on E.Code=CorrectedExamNo AND E.TenantId=SS.TenantId left Join (select 1 as TestId, QuestionIndex, CorrectedOptions from ScannedQuestions where ScannedSheetId = '" + id.ToString().ToUpper() + "' ) as SQ " +
                                " On QA.QuestionIndex = SQ.QuestionIndex where QA.ExamId = " + Exams.Id + "and QA.RuleTypeId in (1,3,5,6)) as StudentResult";

                    if (!string.IsNullOrEmpty(query))
                        uow.Connection.Execute(query);

                    string Examresultquery = "  insert into ExamResults (StudentId, RollNumber,SheetNumber,SheetGuid,ExamId,TotalMarks,ObtainedMarks,Percentage,TotalQuestions,TotalAttempted," +
                            "  TotalNotAttempted,TotalRightAnswers,TotalWrongAnswers,InsertDate,InsertUserId,IsActive,TenantId,ScannedBatchId,ScannedSheetId)" +
                            "  select s.Id,ss.CorrectedRollNo,ss.SheetNumber,ss.Id,e.Id,e.TotalMarks," +
                            "  (select sum(ObtainedMarks) from ExamQuestionResults WHERE ScannedSheetId=ss.Id) as ObtainedMarks," +
                            " ((select sum(ObtainedMarks) from ExamQuestionResults WHERE ScannedSheetId=ss.Id)/e.TotalMarks)*100 as Percentage, e.TotalQuestions, " +
                            " (select count(Id) from ExamQuestionResults WHERE ScannedSheetId=ss.Id and IsAttempted=1 ) as TotalAttempted," +
                            " (SELECT e.TotalQuestions-(select count(Id) from ExamQuestionResults WHERE ScannedSheetId=ss.Id and IsAttempted=1)) as TotalNotAttempted," +
                            "  (select count(Id) from ExamQuestionResults WHERE ScannedSheetId=ss.Id and IsCorrect=1) as TotalRightAnswers," +
                            "  ((select count(Id) from ExamQuestionResults WHERE ScannedSheetId=ss.Id and IsAttempted=1) -(select isnull(count(Id),0) from ExamQuestionResults WHERE ScannedSheetId=ss.Id and IsCorrect=1)) as TotalWrongAnswers," +
                            "  getdate(),1,1,ss.TenantId,ss.ScannedBatchId,ss.Id" +
                            "  from  ScannedSheets SS inner join Exams E on ss.CorrectedExamNo=E.Code and ss.TenantId=E.TenantId" +
                            "  left join Students s on ss.CorrectedRollNo=s.RollNo and ss.TenantId=s.TenantId" +
                            " where ss.Id='" + id.ToString().ToUpper() + "'   and ss.tenantId=" + Scannedsheet.TenantId;

                    if (!string.IsNullOrEmpty(Examresultquery))
                        uow.Connection.Execute(Examresultquery);
                }
            }
            if (!string.IsNullOrEmpty(errorids))
                throw new ValidationError("Result already generated for Roll number" + errorids + " .Other results generated successfully");
            return new SaveResponse();
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse UpdateDisplayname(string[] ids, [FromServices] ISqlConnections SqlConnections, [FromServices] IScannedSheetSaveHandler handler)
        {
            using (var connection = SqlConnections.NewByKey("Default"))
            {
                foreach (var id in ids)
                {
                    Guid sheetid = new Guid(id.ToString().ToUpper());
                    var scannedsheet = connection.TryFirst<MyRow>(MyRow.Fields.Id == sheetid);
                    if (scannedsheet != null)
                    {
                        if (!string.IsNullOrEmpty(scannedsheet.CorrectedExamNo) && !string.IsNullOrEmpty(scannedsheet.CorrectedRollNo))
                            scannedsheet.ScannedSheetDisplayName = scannedsheet.CorrectedRollNo + " (" + scannedsheet.CorrectedExamNo + ")";
                        connection.UpdateById<MyRow>(scannedsheet);
                    }

                }
            }

            return new SaveResponse();
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse UpdateCorrectedRollNumber(string[] ids, [FromServices] ISqlConnections SqlConnections, [FromServices] IScannedSheetSaveHandler handler)
        {
            using (var connection = SqlConnections.NewByKey("Default"))
            {
                foreach (var id in ids)
                {
                    Guid sheetid = new Guid(id.ToString().ToUpper());
                    var scannedsheet = connection.TryFirst<MyRow>(MyRow.Fields.Id == sheetid);
                    if (scannedsheet != null)
                    {
                        if (!string.IsNullOrEmpty(scannedsheet.OCRData1Value) && !string.IsNullOrEmpty(scannedsheet.CorrectedRollNo))
                        {
                            if (scannedsheet.OCRData1Value == "A-Za-z0-9")
                            {
                                scannedsheet.CorrectedRollNo = scannedsheet.OCRData1Value;
                            }
                        }
                        connection.UpdateById<MyRow>(scannedsheet);
                    }
                }
            }
            return new SaveResponse();
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse RecalculateResult(string[] ids, IUnitOfWork uow, [FromServices] IScannedSheetSaveHandler handler)
        {
            ISqlDialect sqlDialect = uow.Connection.GetDialect();
            string errorids = "";
            foreach (var id in ids)
            {
                string query = "";
                string Deletequery1 = "";
                string Deletequery2 = "";
                string Deletequery3 = "";
                Guid sheetid = new Guid(id.ToString().ToUpper());
                string gid = id.ToString().ToUpper();
                var Scannedsheet = uow.Connection.TryFirst<MyRow>(MyRow.Fields.Id == sheetid);
                var Exams = uow.Connection.TryFirst<ExamRow>(ExamRow.Fields.Code == Scannedsheet.CorrectedExamNo && MyRow.Fields.TenantId == Scannedsheet.TenantId.Value);
                var ExamSection = uow.Connection.TryFirst<ExamSectionRow>(ExamSectionRow.Fields.ExamId == Exams.Id.Value);
                var ExamResult = uow.Connection.TryFirst<ExamResultRow>(ExamResultRow.Fields.ScannedSheetId == sheetid);

                if (sqlDialect is SqliteDialect)
                {
                    if (ExamResult != null)
                    {
                        Deletequery1 = "Delete from ExamResults where ScannedSheetId='" + id.ToString().ToUpper() + "'";
                        Deletequery2 = "Delete from ExamQuestionResults where ScannedSheetId='" + id.ToString().ToUpper() + "' ";
                        Deletequery3 = "Delete from ExamSectionResults where SheetGuid='" + id.ToString().ToUpper() + "' ";
                        uow.Connection.Execute(Deletequery1);
                        uow.Connection.Execute(Deletequery2);
                        uow.Connection.Execute(Deletequery3);
                    }
                    //string sqlQuery = "select Distinct RuleTypeId from ExamQuestions where Examid= " + Exams.Id.ToString();


                    //List<int> RuleTypes = uow.Connection.Query<int>(sqlQuery, commandType: System.Data.CommandType.Text).ToList();

                    #region Old Logic
                    query = "Insert into ExamQuestionResults (ExamId,ExamQuestionId,ExamSectionId,StudentId,RollNumber,SheetNumber,SheetGuid,QuestionIndex,IsAttempted,IsCorrect,ObtainedMarks,TenantId,ScannedSheetId,ScannedBatchId,InsertDate,InsertUserId)" +
                            " Select ExamId,ExamQuestionId,ExamSectionId,(SELECT Id from Students s WHERE s.RollNo=CorrectedRollNo and s.TenantId=TenantId) as StudentId,CorrectedRollNo,SheetNumber, " +
                            " ScannedSheetId, QuestionIndex,( case when CorrectedOptions is null then 0 else 1 end)as IsAttempted," +
                            " ( Case When Result > 0 then 1 else 0 end) as IsCorrect,CAST(Result AS FLOAT) as Result,TenantId,ScannedSheetId,ScannedBatchId," +
                            " datetime('now')," + User.GetIdentifier() + "" +
                            " From  ( Select QA.ExamId,QA.Id as ExamQuestionId,QA.ExamSectionId,  QA.QuestionIndex,  SQ.CorrectedOptions, qa.RightOptions, QA.Score, " +
                            " (Case when QA.RuleTypeId is null or QA.RuleTypeId = 1 then " +
                            " Case when SQ.CorrectedOptions is null  then 0  when SQ.CorrectedOptions = qa.RightOptions then QA.Score else (Select(round((QA.Score * NegativeMarks),2) * -1) From Exams where id = " + Exams.Id + ")  End " +
                            //" when QA.RuleTypeId = 2 then" +
                            //" case when SQ.CorrectedOptions is null then 0 when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, 1, pos-1) AS A From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                            //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, pos+1, pos-1) AS B From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score" +
                            //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*2)+1, pos-1) AS C From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score" +
                            //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*3)+1, pos-1) AS D From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score" +
                            //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*4)+1, pos-1) AS E From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score" +
                            //" else  (Select(round((QA.Score * NegativeMarks),2) * -1) From Exams where id = " + Exams.Id + ") End " +
                            " when QA.RuleTypeId = 3 then  QA.Score " +
                            //" when QA.RuleTypeId = 4 then " +
                            //" Case when SQ.CorrectedOptions is null  then 0 " +
                            //" when SQ.CorrectedOptions = 1 then (SELECT substr(qa.Score, 1, pos-1) AS A From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                            //" when SQ.CorrectedOptions = 2 then (SELECT substr(qa.Score, pos+1, pos-1) AS B From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                            //" when SQ.CorrectedOptions = 3 then (SELECT substr(qa.Score, (pos*2)+1, pos-1) AS C From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                            //" when SQ.CorrectedOptions = 4 then (SELECT substr(qa.Score, (pos*3)+1, pos-1) AS D From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                            //" when SQ.CorrectedOptions = 5 then (SELECT substr(qa.Score, (pos*4)+1, pos-1) AS E From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                            //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*5)+1, pos) AS F From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*5)+1, pos-1) AS F From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                            //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*6)+2, pos) AS G From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*6)+1, pos-1) AS G From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                            //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*7)+3, pos) AS H From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*7)+1, pos-1) AS H From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                            //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*8)+4, pos) AS I From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*8)+1, pos-1) AS I From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                            //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*9)+5, pos) AS J From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*9)+1, pos-1) AS J From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                            //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*10)+6) AS K From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*10)+1, pos-1) AS K From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions)) " +
                            //" else (Select(round((QA.Score * NegativeMarks),2) * -1) From Exams where id = " + Exams.Id + " )  End " +
                            " when QA.RuleTypeId = 5 then " +
                            " Case when SQ.CorrectedOptions is null  then 0 " +
                            " when SQ.CorrectedOptions = qa.RightOptions then QA.Score " +
                            " else (Select(round((QA.Score * NegativeMarks),2) * -1) From Exams where id = " + Exams.Id + ") End " +
                            " when QA.RuleTypeId = 6 then " +
                            " Case when SQ.CorrectedOptions is null  then 0  else  QA.Score  End " +
                            //" when QA.RuleTypeId = 7 then " +
                            //" case  when SQ.CorrectedOptions is null then 0 " +
                            //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, 1, pos-1) AS A From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                            //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, pos+1, pos-1) AS B From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                            //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*2)+1, pos-1) AS C From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                            //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*3)+1, pos-1) AS D From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                            //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*4)+1, pos-1) AS E From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                            //" when SQ.CorrectedOptions = (SELECT REPLACE(qa.RightOptions, ',', '')) then QA.Score " +
                            //" else  (Select(round((QA.Score * NegativeMarks),2) * -1) From Exams where id = " + Exams.Id + ")  End " +
                            " End ) as Result, TotalMarks, RuleTypeId, qa.RightOptions,ss.CorrectedRollNo,ss.CorrectedExamNo,ss.SheetNumber,ss.ScannedSheetId,ss.ScannedBatchId,ss.TenantId " +
                            " from ExamQuestions as QA inner join Exams E on QA.ExamId=E.Id " +
                            " left join (select CorrectedRollNo,CorrectedExamNo,SheetNumber,id as ScannedSheetId,ScannedBatchId,TenantId FROM ScannedSheets where Id='" + id.ToString().ToUpper() + "') as SS " +
                            " on E.Code=ss.CorrectedExamNo AND E.TenantId=ss.TenantId left Join ( select 1 as TestId, QuestionIndex,  CorrectedOptions from ScannedQuestions where ScannedSheetId = '" + id.ToString().ToUpper() + "' ) as SQ " +
                            " On  QA.QuestionIndex = SQ.QuestionIndex  where QA.ExamId = " + Exams.Id + " and QA.RuleTypeId in (1,3,5,6) ) as StudentResult ";

                    if (!string.IsNullOrEmpty(query))
                        uow.Connection.Execute(query);
                    #endregion

                    string Examresultquery = "  insert into ExamResults (StudentId, RollNumber, SheetNumber, SheetGuid, ExamId, TotalMarks, ObtainedMarks, Percentage, TotalQuestions, TotalAttempted," + " TotalNotAttempted, TotalRightAnswers, TotalWrongAnswers, InsertDate, InsertUserId, IsActive, TenantId, ScannedBatchId, ScannedSheetId)" +
                        "  select s.Id,ss.CorrectedRollNo,ss.SheetNumber,ss.Id,e.Id,e.TotalMarks," +
                        "  (select sum(ObtainedMarks) from ExamQuestionResults WHERE ScannedSheetId=ss.Id) as ObtainedMarks," +
                        " ((select sum(ObtainedMarks) from ExamQuestionResults WHERE ScannedSheetId=ss.Id)/e.TotalMarks)*100 as Percentage, e.TotalQuestions, " +
                        " (select count(Id) from ExamQuestionResults WHERE ScannedSheetId=ss.Id and IsAttempted=1 ) as TotalAttempted," +
                        " (SELECT e.TotalQuestions-(select count(Id) from ExamQuestionResults WHERE ScannedSheetId=ss.Id and IsAttempted=1)) as TotalNotAttempted," +
                        "  (select count(Id) from ExamQuestionResults WHERE ScannedSheetId=ss.Id and IsCorrect=1) as TotalRightAnswers," +
                        "  ((select count(Id) from ExamQuestionResults WHERE ScannedSheetId=ss.Id and IsAttempted=1) -(select ifnull(count(Id),0) from ExamQuestionResults WHERE ScannedSheetId=ss.Id and IsCorrect=1)) as TotalWrongAnswers," +
                        "  datetime('now'),1,1,ss.TenantId,ss.ScannedBatchId,ss.Id" +
                        "  from  ScannedSheets SS inner join Exams E on ss.CorrectedExamNo=E.Code and ss.TenantId=E.TenantId" +
                        "  left join Students s on ss.CorrectedRollNo=s.RollNo and ss.TenantId=s.TenantId" +
                        " where ss.Id='" + id.ToString().ToUpper() + "'   and ss.tenantId=" + Scannedsheet.TenantId;

                    if (!string.IsNullOrEmpty(Examresultquery))
                        uow.Connection.Execute(Examresultquery);
                    if (ExamSection != null)
                    {
                        string ExamSectionresultquery = "  insert into ExamSectionResults (StudentId, RollNumber,SheetNumber,SheetGuid,ExamId,ExamSectionId,TotalMarks,ObtainedMarks,Percentage,TotalQuestions,TotalAttempted," +
                            " TotalNotAttempted,TotalRightAnswers,TotalWrongAnswers,InsertDate,InsertUserId,IsActive,TenantId)" +
                            "  select s.Id,ss.CorrectedRollNo,ss.SheetNumber,ss.Id,e.Id,Es.Id," +
                            "  (select sum(Score) from Examquestions WHERE ExamSectionId=ES.Id) as TotalMarks," +
                            "  (select sum(ObtainedMarks) from ExamQuestionResults WHERE  ExamSectionId=ES.Id and ScannedSheetId=ss.Id) as ObtainedMarks," +
                            " ((select sum(ObtainedMarks) from ExamQuestionResults WHERE  ExamSectionId=ES.Id and ScannedSheetId=ss.Id)/(select sum(Score) from Examquestions WHERE ExamSectionId=ES.Id))*100 as Percentage," +
                            "  (select count(Id) from Examquestions WHERE ExamSectionId=ES.Id ) as TotalQuestions," +
                            "  (select count(Id) from ExamQuestionResults WHERE ExamSectionId=ES.Id and ScannedSheetId=ss.Id and IsAttempted=1 ) as TotalAttempted," +
                            "  ((select count(Id) from Examquestions WHERE ExamSectionId=ES.Id )-(select count(Id) from ExamQuestionResults WHERE ExamSectionId=ES.Id and ScannedSheetId=ss.Id and IsAttempted=1)) as TotalNotAttempted," +
                            "   (select count(Id) from ExamQuestionResults WHERE ExamSectionId=ES.Id and ScannedSheetId=ss.Id and IsCorrect=1) as TotalRightAnswers," +
                            "   ((select count(Id) from ExamQuestionResults WHERE ExamSectionId=ES.Id and ScannedSheetId=ss.Id and IsAttempted=1) -(select ifnull(count(Id),0) from ExamQuestionResults WHERE ExamSectionId=ES.Id and ScannedSheetId=ss.Id and IsCorrect=1)) as TotalWrongAnswers," +
                            "   datetime('now'),1,1,ss.TenantId   from  ScannedSheets SS inner join Exams E on ss.CorrectedExamNo=E.Code and ss.TenantId=E.TenantId" +
                            "   inner join ExamSections Es on Es.ExamId=E.Id    left join Students s on ss.CorrectedRollNo=s.RollNo and ss.TenantId=s.TenantId" +
                            "  where ss.Id='" + id.ToString().ToUpper() + "'   and ss.tenantId=" + Scannedsheet.TenantId;

                        uow.Connection.Execute(ExamSectionresultquery);

                    }
                }
                else if (sqlDialect is SqlServer2012Dialect)
                {

                    if (ExamResult != null)
                    {
                        Deletequery1 = "Delete from ExamResults where ScannedSheetId='" + id.ToString().ToUpper() + "'";
                        Deletequery2 = "Delete from ExamQuestionResults where ScannedSheetId='" + id.ToString().ToUpper() + "' ";
                        Deletequery3 = "Delete from ExamSectionResults where SheetGuid='" + id.ToString().ToUpper() + "' ";
                        uow.Connection.Execute(Deletequery1);
                        uow.Connection.Execute(Deletequery2);
                        uow.Connection.Execute(Deletequery3);
                    }
                    #region OldLogic
                    query = "Insert into ExamQuestionResults (ExamId,ExamQuestionId,ExamSectionId,StudentId,RollNumber,SheetNumber,SheetGuid,QuestionIndex,IsAttempted,IsCorrect,ObtainedMarks,TenantId,ScannedSheetId,ScannedBatchId,InsertDate,InsertUserId)" +
                                " Select ExamId,ExamQuestionId,ExamSectionId,(SELECT Id from Students s WHERE s.RollNo=CorrectedRollNo and s.TenantId=TenantId) as StudentId,CorrectedRollNo,SheetNumber," +
                                " ScannedSheetId, QuestionIndex,\r\n(case when CorrectedOptions is null then 0 else 1 end)as IsAttempted," +
                                "(Case When Result > 0 then 1 else 0 end) as IsCorrect, CAST(Result AS FLOAT) as Result,TenantId,ScannedSheetId,ScannedBatchId, getdate()," + User.GetIdentifier() + "" +
                                "From (Select QA.ExamId,QA.Id as ExamQuestionId,QA.ExamSectionId, QA.QuestionIndex, SQ.CorrectedOptions, qa.RightOptions, QA.Score," +
                                " (Case when QA.RuleTypeId is null or QA.RuleTypeId = 1 then " +
                                " (Case when SQ.CorrectedOptions is null  then 0  when SQ.CorrectedOptions = qa.RightOptions then QA.Score else (Select(round((QA.Score * NegativeMarks),2) * -1) From Exams where id = " + Exams.Id + ")End)" +
                                //" when QA.RuleTypeId = 2 then" +
                                //" case when SQ.CorrectedOptions is null then 0 when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, 1, pos-1) AS A From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, pos+1, pos-1) AS B From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*2)+1, pos-1) AS C From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*3)+1, pos-1) AS D From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*4)+1, pos-1) AS E From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score" +
                                //" else  (Select(round((QA.Score * NegativeMarks),2) * -1) From Exams where id = " + Exams.Id + ") End " +
                                "when QA.RuleTypeId = 3 then QA.Score " +
                                //" when QA.RuleTypeId = 4 then " +
                                //" Case when SQ.CorrectedOptions is null  then 0 " +
                                //" when SQ.CorrectedOptions = 1 then (SELECT substr(qa.Score, 1, pos-1) AS A From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = 2 then (SELECT substr(qa.Score, pos+1, pos-1) AS B From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = 3 then (SELECT substr(qa.Score, (pos*2)+1, pos-1) AS C From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = 4 then (SELECT substr(qa.Score, (pos*3)+1, pos-1) AS D From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = 5 then (SELECT substr(qa.Score, (pos*4)+1, pos-1) AS E From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*5)+1, pos) AS F From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*5)+1, pos-1) AS F From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*6)+2, pos) AS G From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*6)+1, pos-1) AS G From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*7)+3, pos) AS H From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*7)+1, pos-1) AS H From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*8)+4, pos) AS I From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*8)+1, pos-1) AS I From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*9)+5, pos) AS J From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*9)+1, pos-1) AS J From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions))" +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*10)+6) AS K From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then (SELECT substr(qa.Score, (pos*10)+1, pos-1) AS K From(select qa.Score, instr(qa.Score, ',') AS pos from ExamQuestions)) " +
                                //" else (Select(round((QA.Score * NegativeMarks),2) * -1) From Exams where id = " + Exams.Id + " )  End " +
                                " when QA.RuleTypeId = 5 then " +
                                " Case when SQ.CorrectedOptions is null then 0 " +
                                " when SQ.CorrectedOptions = qa.RightOptions then QA.Score " +
                                " else (Select(round((QA.Score * NegativeMarks),2) * -1) From Exams where id = " + Exams.Id + ") End " +
                                " when QA.RuleTypeId = 6 then " +
                                " Case when SQ.CorrectedOptions is null then 0 else QA.Score End " +
                                //" when QA.RuleTypeId = 7 then " +
                                //" case  when SQ.CorrectedOptions is null then 0 " +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, 1, pos-1) AS A From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, pos+1, pos-1) AS B From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*2)+1, pos-1) AS C From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*3)+1, pos-1) AS D From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                                //" when SQ.CorrectedOptions = (SELECT substr(qa.RightOptions, (pos*4)+1, pos-1) AS E From(select qa.RightOptions, instr(qa.RightOptions, ',') AS pos from ExamQuestions)) then QA.Score " +
                                //" when SQ.CorrectedOptions = (SELECT REPLACE(qa.RightOptions, ',', '')) then QA.Score " +
                                //" else  (Select(round((QA.Score * NegativeMarks),2) * -1) From Exams where id = " + Exams.Id + ")  End " +
                                " End) as Result, TotalMarks, RuleTypeId, ss.CorrectedRollNo, ss.CorrectedExamNo, ss.SheetNumber, ss.ScannedSheetId, ss.ScannedBatchId,ss.TenantId " +
                                " from ExamQuestions as QA inner join Exams E on QA.ExamId=E.Id " +
                                " left join (select CorrectedRollNo,CorrectedExamNo,SheetNumber,id as ScannedSheetId,ScannedBatchId,TenantId FROM ScannedSheets where Id='" + id.ToString().ToUpper() + "') as SS " +
                                " on E.Code=CorrectedExamNo AND E.TenantId=SS.TenantId left Join (select 1 as TestId, QuestionIndex, CorrectedOptions from ScannedQuestions where ScannedSheetId = '" + id.ToString().ToUpper() + "' ) as SQ " +
                                " On QA.QuestionIndex = SQ.QuestionIndex where QA.ExamId = " + Exams.Id + "and QA.RuleTypeId in (1,3,5,6)) as StudentResult";
                    #endregion
                    if (!string.IsNullOrEmpty(query))
                        uow.Connection.Execute(query);

                    string Examresultquery = "  insert into ExamResults (StudentId, RollNumber, SheetNumber, SheetGuid, ExamId, TotalMarks, ObtainedMarks, Percentage, TotalQuestions, TotalAttempted," + " TotalNotAttempted, TotalRightAnswers, TotalWrongAnswers, InsertDate, InsertUserId, IsActive, TenantId, ScannedBatchId, ScannedSheetId)" +
                        "  select s.Id,ss.CorrectedRollNo,ss.SheetNumber,ss.Id,e.Id,e.TotalMarks," +
                        "  (select sum(ObtainedMarks) from ExamQuestionResults WHERE ScannedSheetId=ss.Id) as ObtainedMarks," +
                        " ((select sum(ObtainedMarks) from ExamQuestionResults WHERE ScannedSheetId=ss.Id)/e.TotalMarks)*100 as Percentage, e.TotalQuestions, " +
                        " (select count(Id) from ExamQuestionResults WHERE ScannedSheetId=ss.Id and IsAttempted=1 ) as TotalAttempted," +
                        " (SELECT e.TotalQuestions-(select count(Id) from ExamQuestionResults WHERE ScannedSheetId=ss.Id and IsAttempted=1)) as TotalNotAttempted," +
                        "  (select count(Id) from ExamQuestionResults WHERE ScannedSheetId=ss.Id and IsCorrect=1) as TotalRightAnswers," +
                        "  ((select count(Id) from ExamQuestionResults WHERE ScannedSheetId=ss.Id and IsAttempted=1) -(select isnull(count(Id),0) from ExamQuestionResults WHERE ScannedSheetId=ss.Id and IsCorrect=1)) as TotalWrongAnswers," +
                        "  getdate(),1,1,ss.TenantId,ss.ScannedBatchId,ss.Id" +
                        "  from  ScannedSheets SS inner join Exams E on ss.CorrectedExamNo=E.Code and ss.TenantId=E.TenantId" +
                        "  left join Students s on ss.CorrectedRollNo=s.RollNo and ss.TenantId=s.TenantId" +
                        " where ss.Id='" + id.ToString().ToUpper() + "'   and ss.tenantId=" + Scannedsheet.TenantId;

                    if (!string.IsNullOrEmpty(Examresultquery))
                        uow.Connection.Execute(Examresultquery);
                    /*if (ExamSection != null)
                    {
                        string ExamSectionresultquery = "  insert into ExamSectionResults (StudentId, RollNumber,SheetNumber,SheetGuid,ExamId,ExamSectionId,TotalMarks,ObtainedMarks,Percentage,TotalQuestions,TotalAttempted," +
                            " TotalNotAttempted,TotalRightAnswers,TotalWrongAnswers,InsertDate,InsertUserId,IsActive,TenantId)" +
                            "  select s.Id,ss.CorrectedRollNo,ss.SheetNumber,ss.Id,e.Id,Es.Id," +
                            "  (select sum(Score) from Examquestions WHERE ExamSectionId=ES.Id) as TotalMarks," +
                            "  (select sum(ObtainedMarks) from ExamQuestionResults WHERE  ExamSectionId=ES.Id and ScannedSheetId=ss.Id) as ObtainedMarks," +
                            " ((select sum(ObtainedMarks) from ExamQuestionResults WHERE  ExamSectionId=ES.Id and ScannedSheetId=ss.Id)/(select sum(Score) from Examquestions WHERE ExamSectionId=ES.Id))*100 as Percentage," +
                            "  (select count(Id) from Examquestions WHERE ExamSectionId=ES.Id ) as TotalQuestions," +
                            "  (select count(Id) from ExamQuestionResults WHERE ExamSectionId=ES.Id and ScannedSheetId=ss.Id and IsAttempted=1 ) as TotalAttempted," +
                            "  ((select count(Id) from Examquestions WHERE ExamSectionId=ES.Id )-(select count(Id) from ExamQuestionResults WHERE ExamSectionId=ES.Id and ScannedSheetId=ss.Id and IsAttempted=1)) as TotalNotAttempted," +
                            "   (select count(Id) from ExamQuestionResults WHERE ExamSectionId=ES.Id and ScannedSheetId=ss.Id and IsCorrect=1) as TotalRightAnswers," +
                            "   ((select count(Id) from ExamQuestionResults WHERE ExamSectionId=ES.Id and ScannedSheetId=ss.Id and IsAttempted=1) -(select ifnull(count(Id),0) from ExamQuestionResults WHERE ExamSectionId=ES.Id and ScannedSheetId=ss.Id and IsCorrect=1)) as TotalWrongAnswers," +
                            "   datetime('now'),1,1,ss.TenantId   from  ScannedSheets SS inner join Exams E on ss.CorrectedExamNo=E.Code and ss.TenantId=E.TenantId" +
                            "   inner join ExamSections Es on Es.ExamId=E.Id    left join Students s on ss.CorrectedRollNo=s.RollNo and ss.TenantId=s.TenantId" +
                            "  where ss.Id='" + id.ToString().ToUpper() + "'   and ss.tenantId=" + Scannedsheet.TenantId;

                        uow.Connection.Execute(ExamSectionresultquery);
                    }*/
                }
            }
            if (!string.IsNullOrEmpty(errorids))
                throw new ValidationError("Result already generated for Roll number" + errorids + " .Other results generated successfully");
            return new SaveResponse();
        }
    }
    public class ScannedData
    {

        public int? StudentId { get; set; }
        public int? ExamId { get; set; }
        public float? NegativeMarks { get; set; }
        public int? QuestionIndex { get; set; }
        public int? TenantId { get; set; }
        public Guid? ScanBatchId { get; set; }
        public Guid? ScanSheetId { get; set; }
        public string Score { get; set; }
        public string CorrectedRollNo { get; set; }
        public string CorrectedOptions { get; set; }
        public string RightOptions { get; set; }
        public string SheetNumber { get; set; }
    }
}