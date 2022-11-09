using Serenity.ComponentModel;
using Serenity.Web;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.RuleType")]
    [BasedOnRow(typeof(RuleTypeRow), CheckNames = true)]
    public class RuleTypeForm
    {
        
        public string Name { get; set; }
        
        public string Description { get; set; }
    }
}