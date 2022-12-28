using FluentMigrator;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20221228140500)]
    public class DefaultDB_20221228_140500_GetScanData : Migration
    {
        public override void Up()
        {
            Execute.Sql(@"CREATE VIEW GetScanData
as
select sq.Id, s.Id as StudentId,e.Id as ExamId,e.NegativeMarks,eq.QuestionIndex,ss.TenantId,ss.Id as ScanSheetId,ss.ScannedBatchId as ScanBatchId, 
eq.Score,ss.CorrectedRollNo,ss.SheetNumber,eq.RightOptions,sq.CorrectedOptions,eq.RuleTypeId  
from ScannedQuestions SQ inner join ScannedSheets SS on sq.ScannedSheetId=ss.Id 
inner join Exams E on ss.CorrectedExamNo=E.Code inner join ExamQuestions EQ on EQ.QuestionIndex=sq.QuestionIndex and eq.ExamId=e.Id 
left join Students s on ss.CorrectedRollNo=s.RollNo and ss.TenantId=s.TenantId");
        }
        public override void Down() { }
    }
}