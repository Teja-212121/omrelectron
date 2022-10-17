using Serenity.ComponentModel;
using Serenity.Web;

namespace Rio.Administration.Forms
{
    [FormScript("Administration.Tenant")]
    [BasedOnRow(typeof(TenantRow), CheckNames = true)]
    public class TenantForm
    {
        public string TenantName { get; set; }
    }
}