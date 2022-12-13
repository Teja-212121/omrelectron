using FluentMigrator;

namespace Rio.Migrations.DefaultDB
{
    [Migration(20221212182000)]
    public class DefaultDB_20221212_182000_AlterExamQuestionResults : Migration
    {
        public override void Up()
        {
            Alter.Table("ExamQuestionResults").AlterColumn("StudentId").AsInt64().Nullable()
                .AddColumn("ScannedSheetId").AsGuid().Nullable().ForeignKey("ScannedSheets", "Id")
                .AddColumn("ScannedBatchId").AsGuid().Nullable().ForeignKey("ScannedBatches", "Id")
                .AddColumn("InsertDate").AsDateTime().Nullable()
                .AddColumn("InsertUserId").AsInt32().Nullable()
                .AddColumn("UpdateDate").AsDateTime().Nullable()
                .AddColumn("UpdateUserId").AsInt32().Nullable();

            Alter.Table("ExamResults").AlterColumn("StudentId").AsInt64().Nullable()
               .AddColumn("ScannedSheetId").AsGuid().Nullable().ForeignKey("ScannedSheets", "Id")
               .AddColumn("ScannedBatchId").AsGuid().Nullable().ForeignKey("ScannedBatches", "Id");

            Execute.Sql(@"CREATE FUNCTION [dbo].[Ruletype2]
(
    @Scannedoption varchar(20),
    @CorrectOption varchar(20)
)
RETURNS int
as
begin
declare @iscorrect int=0
if(@Scannedoption=@CorrectOption)
begin
set @iscorrect=0
end
else
begin
WHILE LEN(@Scannedoption) > 0
BEGIN
    DECLARE @singleoption VARCHAR(1)
	IF CHARINDEX(',',@Scannedoption) > 0
	begin
        SET  @singleoption = SUBSTRING(@Scannedoption,0,CHARINDEX(',',@Scannedoption))
		if(@Correctoption LIKE '%'+@singleoption+'%')
		begin
		set @iscorrect= 1
		break;
		end
		else
		begin
		set @Scannedoption=SUBSTRING(@Scannedoption,CHARINDEX(',',@Scannedoption)+1,LEN(@Scannedoption))
		end
		end
    ELSE
        BEGIN
        SET  @singleoption = @Scannedoption
        SET @Scannedoption = ''
		if(@Correctoption LIKE '%'+@singleoption+'%')
		begin
		set @iscorrect= 1
		break;
		end
        END

 
 end
   
 end
 return @iscorrect
 end
GO");
            Execute.Sql(@"Create FUNCTION [dbo].[Ruletype2Marks]
(
    @Scannedoption varchar(20),
    @CorrectOption varchar(20),
	@questionId int
)
RETURNS int
as
begin
declare @Score float=0
select @Score = isnull(NegativeMarks,0) from exams where Id =(select Examid from ExamQuestions where Id=@questionId)
set @Score= @Score*(-1)
if(@Scannedoption=null or @Scannedoption='')
begin
set @Score=0
end

if(@Scannedoption <> @CorrectOption)
begin
WHILE LEN(@Scannedoption) > 0
BEGIN
    DECLARE @singleoption VARCHAR(1)
	IF CHARINDEX(',',@Scannedoption) > 0
	begin
        SET  @singleoption = SUBSTRING(@Scannedoption,0,CHARINDEX(',',@Scannedoption))
		if(@Correctoption LIKE '%'+@singleoption+'%')
		begin
		set @score=(select Score from ExamQuestions where Id=@questionId)
		break;
		end
		else
		begin
		set @Scannedoption=SUBSTRING(@Scannedoption,CHARINDEX(',',@Scannedoption)+1,LEN(@Scannedoption))
		end
		end
    ELSE
        BEGIN
        SET  @singleoption = @Scannedoption
        SET @Scannedoption = ''
		if(@Correctoption LIKE '%'+@singleoption+'%')
		begin
		set @score=(select Score from ExamQuestions where Id=@questionId)
		break;
		end
        END

 
 end
   
 end
 return @score
 end
GO");
            Execute.Sql(@"CREATE FUNCTION [dbo].[Ruletype7]
(
    @Scannedoption varchar(20),
    @CorrectOption varchar(20)
)
RETURNS bit
as
begin
declare @iscorrect bit=0
WHILE LEN(@Scannedoption) > 0
BEGIN
    DECLARE @singleoption VARCHAR(1)
    IF CHARINDEX(',',@Scannedoption) > 0
	begin
        SET  @singleoption = SUBSTRING(@Scannedoption,0,CHARINDEX(',',@Scannedoption))
		if(@Correctoption LIKE '%'+@singleoption+'%')
		begin
		set @iscorrect= 1
		break;
		end
		else
		begin
		set @Scannedoption=SUBSTRING(@Scannedoption,CHARINDEX(',',@Scannedoption)+1,LEN(@Scannedoption))
		end
		end
    ELSE
        BEGIN
        SET  @singleoption = @Scannedoption
        SET @Scannedoption = ''
		if(@Correctoption LIKE '%'+@singleoption+'%')
		begin
		set @iscorrect= 1
		break;
		end
        END

 END
   return @iscorrect
 end
GO");
            Execute.Sql(@"CREATE FUNCTION [dbo].[Ruletype7Marks]
(
    @Scannedoption varchar(20),
    @CorrectOption varchar(20),
	@questionId int
)
RETURNS float
as
begin
declare @Score float=0
select @Score = isnull(NegativeMarks,0) from exams where Id =(select Examid from ExamQuestions where Id=@questionId)
set @Score= @Score*(-1)
if(@Scannedoption=null or @Scannedoption='')
begin
set @Score=0
end
else
begin 

WHILE LEN(@Scannedoption) > 0
BEGIN
    DECLARE @singleoption VARCHAR(1)
    IF CHARINDEX(',',@Scannedoption) > 0
	begin
        SET  @singleoption = SUBSTRING(@Scannedoption,0,CHARINDEX(',',@Scannedoption))
		if(@Correctoption LIKE '%'+@singleoption+'%')
		begin
		set @score=(select Score from ExamQuestions where Id=@questionId)
		break;
		end
		else
		begin
		set @Scannedoption=SUBSTRING(@Scannedoption,CHARINDEX(',',@Scannedoption)+1,LEN(@Scannedoption))
		end
		end
    ELSE
        BEGIN
        SET  @singleoption = @Scannedoption
        SET @Scannedoption = ''
		if(@Correctoption LIKE '%'+@singleoption+'%')
		begin
		set @score=(select Score from ExamQuestions where Id=@questionId)
		break;
		end
        END

 END
 end
   return @Score
 end
GO");
            
        }
        public override void Down()
        {

        }
    }
}