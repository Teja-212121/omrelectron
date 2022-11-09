using Serenity.ComponentModel;
using System.ComponentModel;

namespace Rio.Workspace.enums
{
    [EnumKey("Workspace.EPaperSize")]
    public enum EPaperSize
    {
        [Description("A4")]
        A4 = 4,
        [Description("A5")]
        A5 = 5
    }
}