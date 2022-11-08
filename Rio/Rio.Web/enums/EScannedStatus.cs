using Serenity.ComponentModel;
using System.ComponentModel;

namespace Rio.Workspace
{
    [EnumKey("Workspace.EPaperSize")]
    public enum EScannedStatus
    {
        [Description("Successful Sheet")]
        SuccessfulSheet = 1,
        [Description("UnsuccessfulSheet")]
        UnsuccessfulSheet = 2,
        [Description("Warning Sheet")]
        WarningSheet = 3
    }
}