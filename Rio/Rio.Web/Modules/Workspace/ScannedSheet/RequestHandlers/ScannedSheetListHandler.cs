using Serenity.Data;
using Serenity.Services;
using static Rio.Workspace.Endpoints.ScannedSheetController;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Rio.Workspace.ScannedSheetRow>;
using MyRow = Rio.Workspace.ScannedSheetRow;

namespace Rio.Workspace
{
    public interface IScannedSheetListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ScannedSheetListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IScannedSheetListHandler
    {
        public ScannedSheetListHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void ApplyFilters(SqlQuery query)
        {
            base.ApplyFilters(query);
            var request = Request as MyCustomListRequest;
            if (request != null)
            {
                if (request.OCRandCorrectedRollNo == true)
                {
                    // do query here, like bellow:
                    query.Where(MyRow.Fields.CorrectedRollNo != MyRow.Fields.OCRData1Value);
                }
            }
        }
    }
}