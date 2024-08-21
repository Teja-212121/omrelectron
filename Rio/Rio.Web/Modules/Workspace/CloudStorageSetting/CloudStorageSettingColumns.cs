using Serenity.ComponentModel;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.CloudStorageSetting")]
    [BasedOnRow(typeof(CloudStorageSettingRow), CheckNames = true)]
    public class CloudStorageSettingColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string CloudStorageProvidersName { get; set; }
        [QuickFilter]
        [DisplayName("Tenant Name")]
        public string TenantTenantName { get; set; }
        public string Parameter1 { get; set; }
        public string Parameter2 { get; set; }
        public string Parameter3 { get; set; }
        public string Parameter4 { get; set; }
        public string Parameter5 { get; set; }
        public string Parameter6 { get; set; }
        public string Parameter7 { get; set; }
        public string Parameter8 { get; set; }
        public string Parameter9 { get; set; }
        public string Parameter10 { get; set; }
        public string ParameterProvider { get; set; }
    }
}