using FluentMigrator;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20230104161500)]
    public class DefaultDB_20230104_161500_ExamResultReportView : Migration
    {
        public override void Up()
        {
            Execute.Sql(@"CREATE VIEW [vw_ExamResultReport]
as
select eqr.Id, eqr.ScannedSheetId, eqr.RollNumber, e.Id as ExamId, e.Code as ExamCode, eqr.QuestionIndex, eqr.IsAttempted, eqr.IsCorrect, eq.RightOptions, sq.CorrectedOptions, eq.Score, eqr.ObtainedMarks
FROM ExamQuestionResults eqr
LEFT JOIN Exams e on e.Id = eqr.ExamId
INNER JOIN ExamQuestions eq on eq.QuestionIndex = eqr.QuestionIndex and eq.examId=eqr.examid
INNER JOIN ScannedQuestions sq on sq.QuestionIndex = eqr.QuestionIndex and sq.ScannedSheetId = eqr.ScannedSheetId");
        }
        public override void Down() { }
    }
}