using Serenity.ComponentModel;
using System.ComponentModel;

namespace Rio.Workspace.enums
{
    [EnumKey("Workspace.EScannedStatus")]
    public enum EScannedStatus
    {
        [Description("Open Sheet")]
        OpenSheet = 0,
        [Description("Failed Sheet")]
        FailedSheet = 1,
        [Description("Warning Sheet")]
        WarningSheet = 2,
        [Description("Successful Sheet")]
        SuccessSheet = 3
    }
}