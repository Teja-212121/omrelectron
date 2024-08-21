using Serenity.ComponentModel;
using Serenity.Web;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.CloudStorageSetting")]
    [BasedOnRow(typeof(CloudStorageSettingRow), CheckNames = true)]
    public class CloudStorageSettingForm
    {
        [HalfWidth]
        public string CloudStorageProvidersId { get; set; }
        [HalfWidth]
        public int TenantId { get; set; }
        [HalfWidth]
        public string Parameter1 { get; set; }
        [HalfWidth]
        public string Parameter2 { get; set; }
        [HalfWidth]
        public string Parameter3 { get; set; }
        [HalfWidth]
        public string Parameter4 { get; set; }
        [HalfWidth]
        public string Parameter5 { get; set; }
        [HalfWidth]
        public string Parameter6 { get; set; }
        [HalfWidth]
        public string Parameter7 { get; set; }
        [HalfWidth]
        public string Parameter8 { get; set; }
        [HalfWidth]
        public string Parameter9 { get; set; }
        [HalfWidth]
        public string Parameter10 { get; set; }
        [HalfWidth]
        public string ParameterProvider { get; set; }
    }
}