using Serenity;

namespace Rio
{
    public class GridPageModel
    {
        public string Module { get; set; }
        public LocalText PageTitle { get; set; }
        public bool ESModules { get; set; } = true;
    }
}