using FluentMigrator;
using System;

namespace Rio.Migrations.DefaultDB
{

    [Migration(20221014031500)]
    public class DefaultDB_20221014_031500_QuestionReports : Migration
    {
        public override void Up()
        {

            Execute.Sql(@"Create View vw_QuestionReport
as
Select sq.Id,Eq.Id as ExamQuestionId,ER.Id as ExamResultid,Esr.Id as ExamSectionresultId, Er.ExamId as ExamId, eq.QuestionIndex,sq.ScannedOptions,sq.CorrectedOptions,
case when sq.ScannedOptions = sq.CorrectedOptions THEN 'Correct' ELSE 'Wrong' END as Status,eq.InsertDate,e.Name,
eq.Score,er.RollNumber,S.FullName as StudentName,esr.TotalMarks,esr.TotalAttempted,esr.TotalRightAnswers,esr.TotalWrongAnswers
FROM
ExamQuestions eq INNER JOIN ScannedQuestions sq on eq.QuestionIndex = sq.QuestionIndex
inner JOIN ExamResults er on eq.ExamId = er.ExamId
inner JOIN Students S on Er.StudentId = S.Id
INNER JOIN ExamSectionResults esr on esr.ExamId=eq.ExamId
INNER JOIN Exams e on eq.ExamId=e.Id");

        }
        public override void Down()
        {

        }
    }
}