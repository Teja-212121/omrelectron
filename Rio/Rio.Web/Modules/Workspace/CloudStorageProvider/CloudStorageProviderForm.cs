using Serenity.ComponentModel;
using Serenity.Web;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.CloudStorageProvider")]
    [BasedOnRow(typeof(CloudStorageProviderRow), CheckNames = true)]
    public class CloudStorageProviderForm
    {
        public string Id { get; set; }

        public string Name { get; set; }
        [TextAreaEditor(Rows =3)]
        public string Description { get; set; }
        [HalfWidth]
        public short NumberOfParameter { get; set; }
        [HalfWidth]
        public int TenantId { get; set; }
        [HalfWidth]
        public string Parameter1Title { get; set; }
        [HalfWidth]
        public string Parameter2Title { get; set; }
        [HalfWidth]
        public string Parameter3Title { get; set; }
        [HalfWidth]
        public string Parameter4Title { get; set; }
        [HalfWidth]
        public string Parameter5Title { get; set; }
        [HalfWidth]
        public string Parameter6Title { get; set; }
        [HalfWidth]
        public string Parameter7Title { get; set; }
        [HalfWidth]
        public string Parameter8Title { get; set; }
        [HalfWidth]
        public string Parameter9Title { get; set; }
        [HalfWidth]
        public string Parameter10Title { get; set; }
        [HalfWidth]
        public string ParameterProvider { get; set; }
    }
}