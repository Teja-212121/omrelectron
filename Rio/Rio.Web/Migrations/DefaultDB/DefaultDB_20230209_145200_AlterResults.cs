using FluentMigrator;
using Serenity.Extensions;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20230209145200)]
    public class DefaultDB_20230209_145200_AlterResults : Migration
    {
        public override void Up()
        {

            Alter.Table("ExamResults").AlterColumn("RollNumber").AsString(100).Nullable();
            Alter.Table("ExamSectionResults").AlterColumn("RollNumber").AsString(100).Nullable();
            Alter.Table("ExamQuestionResults").AlterColumn("RollNumber").AsString(100).Nullable();
            Alter.Table("ExamGroupWiseResults").AlterColumn("RollNumber").AsString(100).Nullable();
            Alter.Table("ExamRankWiseResults").AlterColumn("RollNumber").AsString(100).Nullable();

            Execute.Sql(@"Drop View vw_ExamResultReport");

            Execute.Sql(@"CREATE VIEW [vw_ExamResultReport]
            as
            select eqr.Id, eqr.ScannedSheetId, eqr.RollNumber, e.Id as ExamId, e.Code as ExamCode, eqr.QuestionIndex, eqr.IsAttempted, eqr.IsCorrect, eq.RightOptions, sq.CorrectedOptions, eq.Score, eqr.ObtainedMarks
            FROM ExamQuestionResults eqr
            LEFT JOIN Exams e on e.Id = eqr.ExamId
            INNER JOIN ExamQuestions eq on eq.QuestionIndex = eqr.QuestionIndex and eq.examId=eqr.examid
            LEFT JOIN ScannedQuestions sq on sq.QuestionIndex = eqr.QuestionIndex and sq.ScannedSheetId = eqr.ScannedSheetId");

        }
        public override void Down() { }
    }
}