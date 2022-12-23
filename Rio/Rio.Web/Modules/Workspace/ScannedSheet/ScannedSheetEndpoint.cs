using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Crypto;
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
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] IScannedSheetListHandler handler)
        {
            return handler.List(connection, request);
        }

        [AuthorizeList(typeof(MyRow))]
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
            [FromServices] IScannedSheetListHandler handler,
            [FromServices] IExcelExporter exporter)
        {
            var data = List(connection, request, handler).Entities;
            var bytes = exporter.Export(data, typeof(Columns.ScannedSheetColumns), request.ExportColumns);
            return ExcelContentResult.Create(bytes, "ScannedSheetList_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
        }

        [AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse UpdateResult(string[] ids, IUnitOfWork uow, [FromServices] IScannedSheetSaveHandler handler)
        {
            foreach (var id in ids)
            {
                Guid sheetid = new Guid(id.ToString());
                var Scannedsheet = uow.Connection.TryFirst<MyRow>(MyRow.Fields.Id == sheetid);
                var Exams = uow.Connection.TryFirst<ExamRow>(ExamRow.Fields.Code == Scannedsheet.CorrectedExamNo && MyRow.Fields.TenantId == Scannedsheet.TenantId.Value);
                string sqlQuery = "select Distinct RuleTypeId from ExamQuestions where Examid= " + Exams.Id.ToString();

                string query = "";
                string Examresultquery = "";
                List<int> RuleTypes = uow.Connection.Query<int>(sqlQuery, commandType: System.Data.CommandType.Text).ToList();
                foreach (int ruletype in RuleTypes)
                {
                    if (ruletype == 1)
                    {
                        //query = query + " declare @Score float " +
                        //    "select @Score = isnull(NegativeMarks,0) from exams where Id =" + Exams.Id + " " +
                        //    "set @Score= @Score*(-1) ";
                        query = query + " Insert into ExamQuestionResults (StudentId,ScannedBatchId,ScannedSheetId,RollNumber,SheetNumber,SheetGuid,ExamId,QuestionIndex,IsAttempted,IsCorrect,ObtainedMarks,TenantId,InsertDate,InsertUserId) " +
                            " select s.Id,ss.ScannedBatchId,ss.Id,ss.CorrectedRollNo,ss.SheetNumber,ss.Id,e.Id,eq.QuestionIndex," +
                            " case when sq.CorrectedOptions is null then 0 else 1 end as IsAttempted,case  when SQ.CorrectedOptions =EQ.RightOptions then 1 else 0 end as IsCorrect, " +
                            " case when SQ.CorrectedOptions is null then 0 when SQ.CorrectedOptions =EQ.RightOptions then EQ.Score else (ifnull(e.NegativeMarks,0)*(-1)) end as ObtainedMarks,ss.TenantId" +
                            " ,datetime('now'),"+User.GetIdentifier()+"" +
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
                            " select s.Id,ss.ScannedBatchId,ss.Id,s.CorrectedRollNo,ss.SheetNumber,ss.Id,e.Id,eq.QuestionIndex," +
                            " case when sq.CorrectedOptions is null then 0 else 1 end as IsAttempted,1 as IsCorrect,EQ.Score,ss.TenantId" +
                            " from ScannedQuestions SQ inner join ScannedSheets SS on sq.ScannedSheetId=ss.Id" +
                            " inner join Exams E on ss.CorrectedExamNo=E.Code inner join ExamQuestions EQ on EQ.QuestionIndex=sq.QuestionIndex and eq.ExamId=e.Id" +
                            " left join Students s on ss.CorrectedRollNo=s.RollNo and ss.TenantId=s.TenantId" +
                            " where ss.CorrectedRollNo=" + Scannedsheet.CorrectedRollNo + " and ss.CorrectedExamNo=" + Scannedsheet.CorrectedExamNo + " and RuletypeId=3 and ss.tenantId=" + Scannedsheet.TenantId;
                    }

                    if (ruletype == 5)
                    {

                        query = query + " Insert into ExamQuestionResults (StudentId,ScannedBatchId,ScannedSheetId,RollNumber,SheetNumber,SheetGuid,ExamId,QuestionIndex,IsAttempted,IsCorrect,ObtainedMarks,TenantId) " +
                             " select s.Id,ss.ScannedBatchId,ss.Id,ss.CorrectedRollNo,ss.SheetNumber,ss.Id,e.Id,eq.QuestionIndex," +
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
                            " select s.Id,ss.ScannedBatchId,ss.Id,ss.CorrectedRollNo,ss.SheetNumber,ss.Id,e.Id,eq.QuestionIndex," +
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
                             " select s.Id,ss.ScannedBatchId,ss.Id,ss.CorrectedRollNo,ss.SheetNumber,ss.Id,e.Id,eq.QuestionIndex," +
                             " case when sq.CorrectedOptions is null then 0 else 1 end as IsAttempted," +
                            " (select dbo.Ruletype7(sq.CorrectedOptions,EQ.RightOptions)) as IsCorrect, " +
                            " (select dbo.Ruletype7Marks(sq.CorrectedOptions,EQ.RightOptions,EQ.Id)) as score,ss.TenantId" +
                            " from ScannedQuestions SQ inner join ScannedSheets SS on sq.ScannedSheetId=ss.Id" +
                            " inner join Exams E on ss.CorrectedExamNo=E.Code inner join ExamQuestions EQ on EQ.QuestionIndex=sq.QuestionIndex and eq.ExamId=e.Id " +
                            " left join Students s on ss.CorrectedRollNo=s.RollNo and ss.TenantId=s.TenantId" +
                            " where ss.CorrectedRollNo=" + Scannedsheet.CorrectedRollNo + " and ss.CorrectedExamNo=" + Scannedsheet.CorrectedExamNo + " and RuletypeId=7 and ss.tenantId=" + Scannedsheet.TenantId;
                    }

                    

                }
                Examresultquery = "  insert into ExamResults (StudentId, RollNumber,SheetNumber,SheetGuid,ExamId,TotalMarks,ObtainedMarks,Percentage,TotalQuestions,TotalAttempted," +
                    "  TotalNotAttempted,TotalRightAnswers,TotalWrongAnswers,InsertDate,InsertUserId,IsActive,TenantId,ScannedBatchId,ScannedSheetId)" +
                    "  select s.Id,ss.CorrectedRollNo,ss.SheetNumber,ss.Id,e.Id,e.TotalMarks,  " +
                    "(select sum(ObtainedMarks) from ExamQuestionResults WHERE CorrectedRollNo=ss.CorrectedRollNo), e.TotalQuestions," +
                    " ((select sum(ObtainedMarks) from ExamQuestionResults WHERE CorrectedRollNo=ss.CorrectedRollNo)/e.TotalMarks)*100," +
                    " (select count(Id) from ExamQuestionResults WHERE CorrectedRollNo=ss.CorrectedRollNo and IsAttempted=1)," +
                    " (SELECT e.TotalQuestions-(select count(Id) from ExamQuestionResults WHERE CorrectedRollNo=ss.CorrectedRollNo and IsAttempted=1))," +
                    "  (select count(Id) from ExamQuestionResults WHERE CorrectedRollNo=ss.CorrectedRollNo and IsCorrect=1)," +
                    "  (SELECT e.TotalQuestions-(select ifnull(count(Id),0) from ExamQuestionResults WHERE CorrectedRollNo=ss.CorrectedRollNo and IsCorrect=1))," +
                    "  datetime('now'),1,1,ss.TenantId,ss.ScannedBatchId,ss.Id \r\n from  ScannedSheets SS inner join Exams E on ss.CorrectedExamNo=E.Code" +
                    "  left join Students s on ss.CorrectedRollNo=s.RollNo and ss.TenantId=s.TenantId " +                       
                        " where ss.CorrectedRollNo=" + Scannedsheet.CorrectedRollNo + " and ss.CorrectedExamNo=" + Scannedsheet.CorrectedExamNo + "  and ss.tenantId=" + Scannedsheet.TenantId;
                uow.Connection.Execute(query);
                uow.Connection.Execute(Examresultquery);
            }
            return new SaveResponse();
        }
    }
}