
using Serenity.Data;
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Rio.Workspace.CloudStorageProviderRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Rio.Workspace.CloudStorageProviderRow;

namespace Rio.Workspace
{
    public interface ICloudStorageProviderSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class CloudStorageProviderSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICloudStorageProviderSaveHandler
    {
        public CloudStorageProviderSaveHandler(IRequestContext context)
             : base(context)
        {
        }
        //protected override void BeforeSave()
        //{
        //    base.BeforeSave();
        //    var str = "";
        //    var count = 0;

           
        //    foreach (var field in Row.GetTableFields())
        //    {
        //        if ((field.Name.StartsWith("Parameter") && Row.GetType().GetProperty(field.Name)?.GetValue(Row, null) != null) && field.Name != "ParameterProvider")
        //        {
        //            var fieldValue = Row.GetType().GetProperty(field.Name)?.GetValue(Row, null);
        //            if (fieldValue != null)
        //            {
        //                str += $"{field.Name}: {fieldValue}";
        //                count++;
        //                if (count < Row.GetTableFields().Count(f => f.Name.StartsWith("Parameter") && Row.GetType().GetProperty(f.Name)?.GetValue(Row, null) != null))
        //                {
        //                    str += ", ";
        //                }
        //            }
        //        }
        //    }
        //    Row.ParameterProvider = str;
        //}
    }
}