using FluentMigrator;
using System;

namespace Rio.Migrations.DefaultDB
{

    [Migration(20221013043300)]
    public class DefaultDB_20221013_043300_SectionReport : Migration
    {
        public override void Up()
        {

            Execute.Sql(@"Create view vw_SectionReport
as
SELECT eq.QuestionIndex, sq.ScannedOptions, sq.CorrectedOptions, eq.Score, es.Name as SectionName,er.RollNumber,s.FullName,
case when sq.ScannedOptions=sq.CorrectedOptions then 'Correct' else 'Wrong' end as Status,
er.TotalAttempted,errw.Rank,esr.TotalMarks,esr.TotalRightAnswers,esr.TotalWrongAnswers
FROM 
ExamQuestions eq INNER JOIN ScannedQuestions sq on eq.QuestionIndex=sq.QuestionIndex 
INNER JOIN ExamSections es on es.Id = eq.ExamSectionId
INNER JOIN ExamResults er on eq.ExamId=er.ExamId
INNER JOIN Students S on Er.StudentId=S.Id
INNER join ExamResultsRankWise errw on er.ExamId=errw.ExamId
INNER JOIN ExamSectionResults esr on esr.ExamId=eq.ExamId");

        }
        public override void Down()
        {

        }
    }
}