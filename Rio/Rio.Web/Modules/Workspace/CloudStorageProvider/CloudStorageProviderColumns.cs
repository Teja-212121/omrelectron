using Serenity.ComponentModel;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.CloudStorageProvider")]
    [BasedOnRow(typeof(CloudStorageProviderRow), CheckNames = true)]
    public class CloudStorageProviderColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short NumberOfParameter { get; set; }
        [QuickFilter]
        [DisplayName("TenantName Name")]
        public string TenantTenantName { get; set; }
        public string Parameter1Title { get; set; }
        public string Parameter2Title { get; set; }
        public string Parameter3Title { get; set; }
        public string Parameter4Title { get; set; }
        public string Parameter5Title { get; set; }
        public string Parameter6Title { get; set; }
        public string Parameter7Title { get; set; }
        public string Parameter8Title { get; set; }
        public string Parameter9Title { get; set; }
        public string Parameter10Title { get; set; }
        public string ParameterProvider { get; set; }
    }
}