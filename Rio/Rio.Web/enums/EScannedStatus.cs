using Serenity.ComponentModel;
using System.ComponentModel;

namespace Rio.Workspace.enums
{
    [EnumKey("Workspace.EScannedStatus")]
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