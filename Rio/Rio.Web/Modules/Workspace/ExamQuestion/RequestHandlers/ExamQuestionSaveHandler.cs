using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using Serenity.Data;
using Serenity.Services;
using System;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ExamQuestionRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ExamQuestionRow;

namespace Rio.Workspace
{
    public interface IExamQuestionSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

    public class ExamQuestionSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamQuestionSaveHandler
    {
        public ExamQuestionSaveHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void BeforeSave()
        {
            base.BeforeSave();
            if (Row.RowIds != null)
            {
                string[] rowIds = Row.RowIds.Split(',');
                if (rowIds.Length > 0)
                {
                    foreach (var id in rowIds)
                    {
                        ExamQuestionRow examQuestionRow = Connection.ById<ExamQuestionRow>(id);
                        if (examQuestionRow.ExamSectionId == null)
                        {
                            examQuestionRow.ExamSectionId = Request.Entity.ExamSectionId;
                            Connection.UpdateById<ExamQuestionRow>(examQuestionRow);
                        }
                        else
                        {
                            throw new ValidationError("Exam Question already assigned to Exam Section");
                        }
                    }
                }
            }

            var examquestion = Connection.TryFirst<MyRow>(MyRow.Fields.ExamId == Row.ExamId.Value && MyRow.Fields.QuestionIndex == Row.QuestionIndex.Value);
            if (IsCreate)
            {
                if (examquestion != null)

                    throw new ValidationError("Question Index already exists to for other Question!");
            }
            else {
                if(examquestion.Id!=Row.Id.Value)
                    throw new ValidationError("Question Index already exists to for other Question!");

            }

            if(Row.RuleTypeId == 1 && Row.RightOption.Length > 1)
            {
                throw new ValidationError("Right Options should not contain Multiple Options!");
            }
            
        }

        protected override void ExecuteSave()
        {
            if (Row.RowIds == null)
            {
                base.ExecuteSave();
            }
        }
    }
}