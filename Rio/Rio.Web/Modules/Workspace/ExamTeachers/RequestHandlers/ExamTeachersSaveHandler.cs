using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.ExamTeachersRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.ExamTeachersRow;

namespace Rio.Workspace
{
    public interface IExamTeachersSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ExamTeachersSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamTeachersSaveHandler
    {
        public ExamTeachersSaveHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void BeforeSave()
        {
            base.BeforeSave();
            if (Row.RowIds != null)
            {
                string erromsg = null;
                string[] rowIds = Row.RowIds.Split(',');
                bool isassigned = false;
                var user = User.GetIdentifier();
                if (rowIds.Length > 0)
                {
                   
                    foreach (var id in rowIds)
                    {

                        //if (Row.IsMasterQuestion == true)
                       

                        if (this.Connection.Exists<MyRow>
                                    (MyRow.Fields.TeacherId ==  Request.Entity.TeacherId.Value &&
                                        MyRow.Fields.TheoryExamId == Convert.ToInt32(id)))
                        {
                            // erromsg = "Question Already assigned to this Exam.";
                            erromsg = erromsg + id.ToString() + ",";
                        }
                        else
                        {
                            isassigned = true;
                            {
                                var Exam = Connection.TryFirst<TheoryExamsRow>(TheoryExamsRow.Fields.Id == Convert.ToInt32(id));

                                this.Connection.Insert<MyRow>(new ExamTeachersRow
                                {
                                    TheoryExamId = Convert.ToInt32(id),
                                    TeacherId = Request.Entity.TeacherId,
                                    InsertDate = System.DateTime.Now,
                                    IsActive = 1,
                                    InsertUserId = Convert.ToInt32(user),
                                    TenantId=Exam.TenantId
                                });

                            }

                        }




                        if (erromsg != null)
                        {
                            if (isassigned == false)
                            {
                                erromsg = "All selected Exams already assigned to Teachers.";
                                throw new ValidationError(erromsg);
                            }
                            else
                            {
                                erromsg = "Exams With ids" + erromsg + " already Assigned to Teachers,Other Exams Successfully Assigned to  Teacher";
                                throw new ValidationError(erromsg);
                            }
                        }
                    }

                }
            }
        }

        protected override void ExecuteSave()
        {
            if (Row.RowIds == null )
            {
                base.ExecuteSave();
            }
        }

    }
}