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

            //protected override void BeforeSave()
            //{
            //    base.BeforeSave();
            //    if (Row.RowIds != null)
            //    {
            //        string[] rowIds = Row.RowIds.Split(',');
            //        if (rowIds.Length > 0)
            //        {
            //            foreach (var id in rowIds)
            //            {
            //                ExamQuestionRow examQuestionRow = Connection.ById<ExamQuestionRow>(id);
            //                examQuestionRow.ExamSectionId = Request.Entity.ExamSectionId;
            //                Connection.UpdateById<ExamQuestionRow>(examQuestionRow);
            //            }
            //        }
            //    }
            //}

            //protected override void ExecuteSave()
            //{

            //}
       // }
    }
}