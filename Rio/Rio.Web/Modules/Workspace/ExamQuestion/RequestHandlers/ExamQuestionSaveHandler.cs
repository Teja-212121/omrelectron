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

            /*if(IsCreate)
            {
                if(Row.QuestionIndex != null)
                {
                    if (Row.QuestionIndex == Request.Entity.QuestionIndex)
                    {
                        throw new ValidationError("Question Index already assigned to Question!");
                    }
                    else
                    {
                        Row.QuestionIndex = Request.Entity.QuestionIndex;
                    }
                }
                else
                {
                    
                    
                }
            }
            if(IsUpdate)
            {
                if (Row.QuestionIndex != null)
                {
                    if (Row.Id == Request.Entity.Id)
                    {
                        ExamQuestionRow examQuestionRow = Connection.ById<ExamQuestionRow>(Row.Id);
                        if (examQuestionRow.QuestionIndex == Row.QuestionIndex)
                        {
                            throw new ValidationError("Question Index already assigned to Question");
                        }
                        else
                        {
                            examQuestionRow.QuestionIndex = Request.Entity.QuestionIndex;
                        }
                    }
                }
            }*/
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