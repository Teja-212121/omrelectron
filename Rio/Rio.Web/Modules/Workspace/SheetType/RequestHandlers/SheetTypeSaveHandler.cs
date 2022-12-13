using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.SheetTypeRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.SheetTypeRow;

namespace Rio.Workspace
{
    public interface ISheetTypeSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class SheetTypeSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISheetTypeSaveHandler
    {
        public SheetTypeSaveHandler(IRequestContext context)
             : base(context)
        {
        }
        protected override void BeforeSave()
        {
            base.BeforeSave();
            var sheetnumber = Row.SheetNumber.ToString();
            if (!string.IsNullOrEmpty(sheetnumber) && !string.IsNullOrEmpty(Row.Name))
                Row.SheetTypeDisplayName = Row.Name + " (" + sheetnumber + ")";
        }
    }
}